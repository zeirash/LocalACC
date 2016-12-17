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
    public partial class DetailForm : Form
    {
        Database1Entities6 de = new Database1Entities6();
        Form parent;
        bool isNotSame;

        public DetailForm(Form parent)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.parent = parent;

            updateShop_grid();
            mode(false);

            //tampilin data ke combobox
            var query = (from x in de.tblExpeditions
                         orderby x.ExpeditionName ascending
                         select new { x.ExpeditionId, x.ExpeditionName }).ToList();
            cmbExpedition.DataSource = query;
            cmbExpedition.DisplayMember = "ExpeditionName";
            cmbExpedition.ValueMember = "ExpeditionId";
            cmbExpedition.SelectedIndex = -1;
        }

        private void updateShop_grid()
        {
            BindingSource bdShop = new BindingSource();
            bdShop.DataSource = (from x in de.tblShops
                                 orderby x.ShopName
                                 where x.ShopName.Contains(txtSearch.Text)
                                 select new
                                 {
                                     Toko = x.ShopName,
                                     Alamat = x.Address,
                                     Telepon =  x.Telephone,
                                     NamaPemilik = x.OwnerName,
                                     TeleponPemilik = x.OwnerPhone
                                 }).ToList();
            shop_Grid.DataSource = bdShop;
        }

        private void update_data()
        {
            BindingSource bdExp = new BindingSource();
            bdExp.DataSource = (from x in de.tblExpeditions
                                join y in de.tblJoins on x.ExpeditionId equals y.ExpeditionId
                                join z in de.tblShops on y.ShopId equals z.ShopId
                                where z.ShopName == txtShopName.Text
                                orderby x.ExpeditionName ascending
                                select new
                                {
                                    Ekspedisi = x.ExpeditionName,
                                    Alamat = x.Address,
                                    Telepon = x.Phone,
                                    KontakTambahan = x.AdditionalContact,
                                    TeleponTambahan = x.AdditionalPhone
                                }).ToList();
            expedition_Grid.DataSource = bdExp;

            if (expedition_Grid.RowCount > 0)
            {
                foreach (DataGridViewRow rows in expedition_Grid.Rows)
                {
                    if (rows.Cells[0].Value.ToString().Equals(cmbExpedition.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        isNotSame = false;
                        break;
                    }
                    else isNotSame = true;
                }
            }
            //else if (expedition_Grid.RowCount == 0) isNotSame = true;
            cmbExpedition.SelectedIndex = -1;
        }

        private void mode(bool change)
        {
            cmbExpedition.Enabled = change;
            btnSubmit.Enabled = change;
            btnCancel.Enabled = change;
            btnAddExpedition.Enabled = !change;
            btnRemove.Enabled = !change;
            btnViewTransaction.Enabled = !change;
            shop_Grid.Enabled = !change;
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            if (txtShopName.Text == "") MessageBox.Show("Toko harus dipilih");
            else
            {
                var query = (from x in de.tblShops
                             where x.ShopName == txtShopName.Text
                             select x.ShopId).FirstOrDefault();
                int currentId = query;

                TransactionForm transactionForm = new TransactionForm(currentId);
                transactionForm.MdiParent = parent;
                transactionForm.Show();
                transactionForm.WindowState = FormWindowState.Minimized;
                transactionForm.WindowState = FormWindowState.Maximized;
                this.Dispose();
            }
        }

        private void btnAddExpedition_Click(object sender, EventArgs e)
        {
            if (txtShopName.Text == "") MessageBox.Show("Toko harus dipilih");
            else
            {
                mode(true);
                cmbExpedition.SelectedIndex = -1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode(false);
            cmbExpedition.SelectedIndex = -1;
        }

        private void shop_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                txtShopName.Text = shop_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                rtxtboxShopAddress.Text = shop_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtShopNumber.Text = shop_Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtOwnerName.Text = shop_Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtOwnerNumber.Text = shop_Grid.Rows[e.RowIndex].Cells[4].Value.ToString();

                update_data();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (expedition_Grid.RowCount > 0)
            {
                foreach (DataGridViewRow rows in expedition_Grid.Rows)
                {
                    if (rows.Cells[0].Value.ToString().Equals(cmbExpedition.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        isNotSame = false;
                        break;
                    }
                    else isNotSame = true;
                }
            }
            else if (expedition_Grid.RowCount == 0) isNotSame = true;

            if (cmbExpedition.SelectedIndex == -1) MessageBox.Show("Anda harus memlih expedisinya");
            else if (!isNotSame) MessageBox.Show("Ekspedisi yang anda ingin masukan sudah ada dalam database");
            else
            {
                //belum validasi bila sudah ada (ekspedisi yg sma)
                int expeditionId = int.Parse(cmbExpedition.SelectedValue.ToString());    

                var query = (from x in de.tblShops
                             where x.ShopName == txtShopName.Text
                             select x.ShopId).FirstOrDefault();
                tblJoin newJoin = new tblJoin
                {
                    ShopId = query,
                    ExpeditionId = expeditionId
                };
                de.tblJoins.Add(newJoin);
                de.SaveChanges();
                cmbExpedition.SelectedIndex = -1;
                mode(false);
                update_data();
                MessageBox.Show("Selesai menambahkan ekspedisi");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbExpedition.SelectedIndex == -1) MessageBox.Show("Ekspedisi harus dipilih");
            else
            {
                tblJoin deleteJoin = (from x in de.tblJoins
                                      join y in de.tblExpeditions on x.ExpeditionId equals y.ExpeditionId
                                      where y.ExpeditionName == cmbExpedition.Text
                                      select x).FirstOrDefault();
                DialogResult result = MessageBox.Show("Apa Anda yakin ingin delete data?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    de.tblJoins.Remove(deleteJoin);
                    cmbExpedition.SelectedIndex = -1;
                }
                else
                {
                    cmbExpedition.SelectedIndex = -1;
                    return;
                }
                de.SaveChanges();
                update_data();
            }
        }

        private void expedition_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else cmbExpedition.Text = expedition_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updateShop_grid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateShop_grid();
        }
    }
}
