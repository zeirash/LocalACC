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
    public partial class ExpeditionForm : Form
    {
        Database1Entities6 de = new Database1Entities6();
        bool _insert, _update, isCheckedName, isCheckedNumber, isCheckedAddress, isNotSame;
        public ExpeditionForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            mode(true);
            update_data();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _insert = true;
            clear();
            mode(false);

            //set id
            int myId;
            var query = (from x in de.tblExpeditions
                         orderby x.ExpeditionId descending
                         select x).FirstOrDefault();
            if (query == null) txtExpeditionId.Text = "1";
            else
            {
                myId = query.ExpeditionId;
                myId++;
                txtExpeditionId.Text = myId.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtExpeditionId.Text == "") MessageBox.Show("Anda harus memlihi data dulu");
            else
            {
                _update = true;
                mode(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtExpeditionId.Text == "") MessageBox.Show("Anda harus memlihi data dulu");
            else
            {
                int expeditionId = int.Parse(txtExpeditionId.Text.ToString());
                tblExpedition deleteExpedition = (from x in de.tblExpeditions
                                                  where x.ExpeditionId == expeditionId
                                                  select x).FirstOrDefault();
                DialogResult result = MessageBox.Show("Apa Anda yakin ingin delete data?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    de.tblExpeditions.Remove(deleteExpedition);
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
                    tblExpedition newExpedition = new tblExpedition
                    {
                        ExpeditionName = txtExpeditionName.Text.ToUpper(),
                        Address = rtxtboxExpeditionAddress.Text.ToUpper(),
                        Phone = txtExpeditionNumber.Text,
                        AdditionalContact = txtAdditionalName.Text.ToUpper(),
                        AdditionalPhone = txtAdditionalNumber.Text
                    };
                    de.tblExpeditions.Add(newExpedition);
                    MessageBox.Show("Success input data");
                }
                else return;
            }

            else if (_update)
            {
                int expeditionId = int.Parse(txtExpeditionId.Text.ToString());
                tblExpedition updateExpedition = (from x in de.tblExpeditions
                                                  where x.ExpeditionId == expeditionId
                                                  select x).FirstOrDefault();

                input();

                if (isCheckedName && isCheckedAddress && isCheckedNumber)
                {
                    //change data in database
                    updateExpedition.ExpeditionName = txtExpeditionName.Text.ToUpper();
                    updateExpedition.Address = rtxtboxExpeditionAddress.Text.ToUpper();
                    updateExpedition.Phone = txtExpeditionNumber.Text;
                    updateExpedition.AdditionalContact = txtAdditionalName.Text.ToUpper();
                    updateExpedition.AdditionalPhone = txtAdditionalNumber.Text;

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

        private void expedition_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                txtExpeditionId.Text = expedition_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtExpeditionName.Text = expedition_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtxtboxExpeditionAddress.Text = expedition_Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtExpeditionNumber.Text = expedition_Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAdditionalName.Text = expedition_Grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAdditionalNumber.Text = expedition_Grid.Rows[e.RowIndex].Cells[5].Value.ToString();
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

        private void mode(bool change)
        {
            btnInsert.Enabled = change;
            btnUpdate.Enabled = change;
            btnDelete.Enabled = change;
            btnSubmit.Enabled = !change;
            btnCancel.Enabled = !change;
            txtExpeditionName.Enabled = !change;
            rtxtboxExpeditionAddress.Enabled = !change;
            txtExpeditionNumber.Enabled = !change;
            txtAdditionalName.Enabled = !change;
            txtAdditionalNumber.Enabled = !change;
            expedition_Grid.Enabled = change;
        }

        private void update_data()
        {
            BindingSource bd1 = new BindingSource();
            bd1.DataSource = (from x in de.tblExpeditions
                              where x.ExpeditionName.Contains(txtSearch.Text)
                              orderby x.ExpeditionName ascending
                              select new
                              {
                                  x.ExpeditionId,
                                  Ekspedisi = x.ExpeditionName,
                                  Alamat = x.Address,
                                  Telepon = x.Phone,
                                  KontakTambahan = x.AdditionalContact,
                                  TeleponTambahan = x.AdditionalPhone
                              }).ToList();
            expedition_Grid.DataSource = bd1;
        }

        private void clear()
        {
            txtExpeditionId.Text = "";
            txtExpeditionName.Text = "";
            rtxtboxExpeditionAddress.Text = "";
            txtExpeditionNumber.Text = "";
            txtAdditionalName.Text = "";
            txtAdditionalNumber.Text = "";
        }

        private void input()
        {
            //checking klo ad nama ekspedisi yg sama
            if (expedition_Grid.RowCount == 0) isNotSame = true;
            else
            {
                foreach (DataGridViewRow rows in expedition_Grid.Rows)
                {
                    if (rows.Cells[1].Value.ToString().Equals(txtExpeditionName.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        isNotSame = false;
                        break;
                    }
                    else isNotSame = true;
                }
            }
            if (_update) isNotSame = true;

            //expedition name validation
            if (txtExpeditionName.Text == "")
            {
                MessageBox.Show("Nama ekspedisi harus di isi");
                isCheckedName = false;
            }
            else if (!isNotSame)
            {
                MessageBox.Show("Ekspedisi yang ingin Anda masukkan sudah ada");
                isCheckedName = false;
            }
            else isCheckedName = true;

            //expedition address
            if (rtxtboxExpeditionAddress.Text == "")
            {
                MessageBox.Show("Alamat harus diisi");
                isCheckedAddress = false;
            }
            else isCheckedAddress = true;

            //expedition phone number validation
            if (txtExpeditionNumber.Text == "")
            {
                MessageBox.Show("Telepon ekspedisi harus diisi");
                isCheckedNumber = false;
            }
            else isCheckedNumber = true;
        }     

    }
}
