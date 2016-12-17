using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallProject
{
    public partial class ShopForm : Form
    {
        Database1Entities6 de = new Database1Entities6();
        bool _insert, _update, isCheckedName, isCheckedNumber, isCheckedAddress, isNotSame;
        public ShopForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            mode(true);
            update_data();
        }

        private void mode(bool change)
        {
            btnInsert.Enabled = change;
            btnUpdate.Enabled = change;
            btnDelete.Enabled = change;
            btnSubmit.Enabled = !change;
            btnCancel.Enabled = !change;
            txtShopName.Enabled = !change;
            rtxtboxShopAddress.Enabled = !change;
            txtShopNumber.Enabled = !change;
            txtOwnerName.Enabled = !change;
            txtOwnerNumber.Enabled = !change;
            Shop_Grid.Enabled = change;
        }

        private void update_data()
        {
            BindingSource bd1 = new BindingSource();
            bd1.DataSource = (from x in de.tblShops
                              where x.ShopName.Contains(txtSearch.Text)
                              orderby x.ShopName ascending
                              select new
                              {
                                  x.ShopId,
                                  Toko = x.ShopName,
                                  Alamat = x.Address,
                                  Telepon = x.Telephone,
                                  NamaPemilik = x.OwnerName,
                                  TeleponPemilik = x.OwnerPhone
                              }).ToList();
            Shop_Grid.DataSource = bd1;
        }

        private void clear()
        {
            txtShopId.Text = "";
            txtShopName.Text = "";
            txtShopNumber.Text = "";
            txtOwnerName.Text = "";
            rtxtboxShopAddress.Text = "";
            txtOwnerNumber.Text = "";
        }

        private void input()
        {
            //checking klo ad nama toko yg sama
            if (Shop_Grid.RowCount == 0) isNotSame = true;
            else
            {
                foreach (DataGridViewRow rows in Shop_Grid.Rows)
                {
                    if (rows.Cells[1].Value.ToString().Equals(txtShopName.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        isNotSame = false;
                        break;
                    }
                    else isNotSame = true;
                }
            }
            if (_update) isNotSame = true;

            //shop name validation
            if (txtShopName.Text == "")
            {
                MessageBox.Show("Nama toko harus diisi");
                isCheckedName = false;
            }
            else if (!isNotSame)
            {
                MessageBox.Show("Toko yang ingin Anda input sudah ada");
                isCheckedName = false;
            }
            else isCheckedName = true;

            //shop address
            if (rtxtboxShopAddress.Text == "")
            {
                MessageBox.Show("Alamat harus diisi");
                isCheckedAddress = false;
            }
            else isCheckedAddress = true;

            //shop phone number validation
            if (txtShopNumber.Text == "")
            {
                MessageBox.Show("Telepon toko harus diisi");
                isCheckedNumber = false;
            }
            else isCheckedNumber = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _insert = true;
            clear();
            mode(false);

            //set id
            int myId;
            var query = (from x in de.tblShops
                         orderby x.ShopId descending
                         select x).FirstOrDefault();
            if (query == null) txtShopId.Text = "1";
            else
            {
                myId = query.ShopId;
                myId++;
                txtShopId.Text = myId.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtShopId.Text == "") MessageBox.Show("Anda harus memilih data dulu");
            else
            {
                _update = true;
                mode(false);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            update_data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtShopId.Text == "") MessageBox.Show("Anda harus memilih data dulu");
            else
            {
                int shopId = int.Parse(txtShopId.Text.ToString());
                tblShop deleteShop = (from x in de.tblShops
                                      where x.ShopId == shopId
                                      select x).FirstOrDefault();
                DialogResult result = MessageBox.Show("Apa Anda yakin ingin delete data?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    de.tblShops.Remove(deleteShop);
                    clear();
                }
                else return;
                de.SaveChanges();
                update_data();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_insert)
            {
                input();
                
                if (isCheckedName && isCheckedAddress && isCheckedNumber)
                {
                    tblShop newShop = new tblShop
                    {
                        ShopName = txtShopName.Text.ToUpper(),
                        Address = rtxtboxShopAddress.Text.ToUpper(),
                        Telephone = txtShopNumber.Text,
                        OwnerName = txtOwnerName.Text.ToUpper(),
                        OwnerPhone = txtOwnerNumber.Text
                    };
                    de.tblShops.Add(newShop);
                    MessageBox.Show("Success input data");
                }
                else return;
            }

            else if (_update)
            {
                int shopId = int.Parse(txtShopId.Text.ToString());
                tblShop updateShop = (from x in de.tblShops
                                      where x.ShopId == shopId
                                      select x).FirstOrDefault();

                input();

                if(isCheckedName && isCheckedAddress && isCheckedNumber)
                {
                    //change data in database
                    updateShop.ShopName = txtShopName.Text.ToUpper();
                    updateShop.Address = rtxtboxShopAddress.Text.ToUpper();
                    updateShop.Telephone = txtShopNumber.Text;
                    updateShop.OwnerName = txtOwnerName.Text.ToUpper();
                    updateShop.OwnerPhone = txtOwnerNumber.Text;

                    MessageBox.Show("Success update data");
                }
                else return;
            }

            de.SaveChanges();
            update_data();
            clear();
            mode(true);
            _insert = _update = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            mode(true);
            _insert = _update = false;
            update_data();
        }

        private void Shop_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                txtShopId.Text = Shop_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtShopName.Text = Shop_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtxtboxShopAddress.Text = Shop_Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtShopNumber.Text = Shop_Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtOwnerName.Text = Shop_Grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtOwnerNumber.Text = Shop_Grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
