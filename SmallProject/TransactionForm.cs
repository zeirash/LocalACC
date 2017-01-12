using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SmallProject
{
    public partial class TransactionForm : Form
    {
        Database1Entities6 de = new Database1Entities6();
        int currentId;
        float totalJual, totalBeli, discount;
        bool _tInsert, _tUpdate, _dInsert, _dUpdate;
        bool isNotaNum, isStatus, isDiscount, isNamaBrg, isQty, isSprice, isBprice;
        DateTime date;
        string myDate;
        public TransactionForm(int currentId)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.currentId = currentId;
            //generate current time
            dtpTransactionDate.Value = dtpTransactionSearch.Value = DateTime.Now;
            //getting current selected shop
            var query = (from x in de.tblShops
                         where x.ShopId == currentId
                         select x).FirstOrDefault();

            //set label to selected shop
            lblShop.Text = query.ShopName;

            update_transaction();

            modeDetail(true);
            modeTransaction(true);
            btnDInsert.Enabled = false;
            btnDUpdate.Enabled = false;
            btnDDelete.Enabled = false;
        }

        private void update_transaction()
        {
            BindingSource bdtrans = new BindingSource();
            bdtrans.DataSource = (from x in de.tblTransactions
                                  join y in de.tblShops on x.ShopId equals y.ShopId
                                  where y.ShopName == lblShop.Text
                                  select new
                                  {
                                      x.TransactionId,
                                      NomorNota = x.NotaNumber,
                                      Diskon = x.Discount,
                                      Tanggal = x.Date,
                                      Status = x.Status,
                                      Informasi = x.Information
                                  }).ToList();
            transaction_grid.DataSource = bdtrans;
        }

        private void modeTransaction(bool change)
        {
            btnTInsert.Enabled = change;
            btnTUpdate.Enabled = change;
            btnTDelete.Enabled = change;
            btnTSubmit.Enabled = !change;
            btnTCancel.Enabled = !change;
            transaction_grid.Enabled = change;
            txtNotaNum.Enabled = !change;
            txtDiscount.Enabled = !change;
            dtpTransactionDate.Enabled = !change;
            rtxtKeterangan.Enabled = !change;
            radBlmLunas.Enabled = !change;
            radLunas.Enabled = !change;
            detail_grid.Enabled = !change;
        }

        private void modeDetail(bool change)
        {
            btnDInsert.Enabled = change;
            btnDUpdate.Enabled = change;
            btnDDelete.Enabled = change;
            btnDSubmit.Enabled = !change;
            btnDCancel.Enabled = !change;
            txtNamaBarang.Enabled = !change;
            txtQuantity.Enabled = !change;
            //txtHrgaBeli.Enabled = !change;
            txtHrgaJual.Enabled = !change;
        }

        private void update_detail()
        {
            int transactionId = int.Parse(lblTransId.Text.ToString());
            BindingSource bdDet = new BindingSource();
            bdDet.DataSource = (from x in de.tblTransactions
                                join y in de.tblDetails on x.TransactionId equals y.TransactionId
                                where x.TransactionId == transactionId
                                select new
                                {
                                    y.DetailId,
                                    NamaBarang = y.ProductName,
                                    y.Quantity,
                                    HargaJual = y.SellPrice,
                                    TotalJual = y.SellPrice * y.Quantity
                                }).ToList();
            detail_grid.DataSource = bdDet;
            this.detail_grid.Columns["HargaJual"].DefaultCellStyle.Format = "##,#";
            //this.detail_grid.Columns["HargaBeli"].DefaultCellStyle.Format = "##,#";
            this.detail_grid.Columns["TotalJual"].DefaultCellStyle.Format = "##,#";
            //this.detail_grid.Columns["TotalBeli"].DefaultCellStyle.Format = "##,#";            
        }

        private void update_sum()
        {
            if (lblTransId.Text != "")
            {
                int transactionId = int.Parse(lblTransId.Text.ToString());
                //get discount
                var query = (from x in de.tblTransactions
                             join y in de.tblDetails on x.TransactionId equals y.TransactionId
                             where x.TransactionId == transactionId
                             select x).FirstOrDefault();

                if (detail_grid.RowCount > 0)
                {
                    //totalBeli = 0;
                    totalJual = 0;
                    foreach (DataGridViewRow rows in detail_grid.Rows)
                    {
                        //totalBeli += int.Parse(rows.Cells[6].Value.ToString());
                        totalJual += int.Parse(rows.Cells[4].Value.ToString());
                    }
                    totalJual = totalJual - totalJual * (int)query.Discount / 100;

                    lblTotalJual.Text = totalJual.ToString("##,#");
                    //lblTotalModal.Text = totalBeli.ToString("##,#");
                }
            }
        }

        private void clear_transaction()
        {
            lblTransId.Text = "";
            txtNotaNum.Text = "";
            txtDiscount.Text = "";
            rtxtKeterangan.Text = "";
            radBlmLunas.Checked = false;
            radLunas.Checked = false;
            detail_grid.Rows.Clear();
        }

        private void clear_detail()
        {
            detailId.Text = "";
            txtNamaBarang.Text = "";
            txtQuantity.Text = "";
            //txtHrgaBeli.Text = "";
            txtHrgaJual.Text = "";
        }

        private void input_transaction()
        {
            //no. nota
            if (txtNotaNum.Text == "")
            {
                MessageBox.Show("Nomor nota harus diisi");
                isNotaNum = false;
            }
            else isNotaNum = true;

            //tanggal
            if (radBlmLunas.Checked == false && radLunas.Checked == false)
            {
                MessageBox.Show("Status harus diisi");
                isStatus = false;
            }
            else isStatus = true;

            //discount
            if (txtDiscount.Text != "")
            {
                Int64 temp;
                if (!(Int64.TryParse(txtDiscount.Text, out temp)))
                {
                    MessageBox.Show("Discount harus angka");
                    isDiscount = false;
                }
                else
                {
                    isDiscount = true;
                    discount = int.Parse(txtDiscount.Text.ToString());
                }
            }
            else if (txtDiscount.Text == "")
            {
                discount = 0;
                isDiscount = true;
            }
        }

        private void transaction_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                lblTransId.Text = transaction_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNotaNum.Text = transaction_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiscount.Text = transaction_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpTransactionDate.Value = Convert.ToDateTime(transaction_grid.Rows[e.RowIndex].Cells[3].Value);
                rtxtKeterangan.Text = transaction_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (transaction_grid.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Lunas")) radLunas.Checked = true;
                else radBlmLunas.Checked = true;

                update_detail();
                update_sum();
            }
        }

        private void detail_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                detailId.Text = detail_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNamaBarang.Text = detail_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = detail_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHrgaJual.Text = detail_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtHrgaJual.Text = string.Format("{0:##,#0}", int.Parse(txtHrgaJual.Text));
            }
        }

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
            date = dtpTransactionDate.Value;
        }

        private void dtpTransactionSearch_ValueChanged(object sender, EventArgs e)
        {
            date = dtpTransactionSearch.Value;
            myDate = dtpTransactionSearch.Value.ToString("dd-MMM-yy");
            date = DateTime.ParseExact(myDate, "dd-MMM-yy", CultureInfo.InvariantCulture);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            update_transaction();
            update_sum();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            BindingSource bdtrans = new BindingSource();
            bdtrans.DataSource = (from x in de.tblTransactions
                                  join y in de.tblShops on x.ShopId equals y.ShopId
                                  where y.ShopName == lblShop.Text && x.Date == date
                                  select new
                                  {
                                      x.TransactionId,
                                      NomorNota = x.NotaNumber,
                                      Diskon = x.Discount,
                                      Tanggal = x.Date,
                                      Status = x.Status,
                                      Informasi = x.Information
                                  }).ToList();
            transaction_grid.DataSource = bdtrans;
            clear_detail();
        }

        private void btnTInsert_Click(object sender, EventArgs e)
        {
            //mode
            modeTransaction(false);
            modeDetail(true);

            //======================================================================================
            _tInsert = true;
            clear_transaction();
            clear_detail();
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            if (lblTransId.Text == "") MessageBox.Show("Anda harus memilih data dulu");
            else
            {
                //mode
                modeTransaction(false);
                modeDetail(true);
                clear_detail();
                //======================================================================================
                _tUpdate = true;
            }
        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            if (lblTransId.Text == "") MessageBox.Show("Anda harus memilih data dulu");
            else
            {
                int myId = int.Parse(lblTransId.Text.ToString());
                tblTransaction deleteTransaction = (from x in de.tblTransactions
                                                    where x.TransactionId == myId
                                                    select x).FirstOrDefault();
                DialogResult result = MessageBox.Show("Apa Anda yakin ingin delete data?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var query = (from x in de.tblDetails
                                 join y in de.tblTransactions on x.TransactionId equals y.TransactionId
                                 where x.TransactionId == myId
                                 select x).Count();
                    label1.Text = query.ToString();
                    for (int i = 0; i < query; i++) {
                        tblDetail deleteRelatedDetail = (from x in de.tblDetails
                                                         join y in de.tblTransactions on x.TransactionId equals y.TransactionId
                                                         where x.TransactionId == myId
                                                         select x).FirstOrDefault();
                        de.tblDetails.Remove(deleteRelatedDetail);
                        de.SaveChanges();
                    }
                    de.tblTransactions.Remove(deleteTransaction);
                    clear_detail();
                    clear_transaction();
                }
                else return;
                de.SaveChanges();
                update_transaction();
                update_sum();
            }
        }

        private void btnTSubmit_Click(object sender, EventArgs e)
        {
            //=============================== if insert ====================================
            if (_tInsert)
            {
                input_transaction();

                if (isNotaNum && isStatus && isDiscount)
                {
                    if (detail_grid.RowCount == 0)
                    {
                        MessageBox.Show("Detail tidak bisa kosong");
                        return;
                    }
                    else MessageBox.Show("Success input transaksi baru");
                }
                else return;
            }
            //=============================== if update ====================================
            else if (_tUpdate)
            {
                int myId = int.Parse(lblTransId.Text.ToString());
                tblTransaction updateTransaction = (from x in de.tblTransactions
                                                    where x.TransactionId == myId
                                                    select x).FirstOrDefault();

                input_transaction();
                if (isNotaNum && isStatus && isDiscount)
                {
                    if (detail_grid.RowCount == 0)
                    {
                        MessageBox.Show("Detail tidak bisa kosong");
                        return;
                    }
                    else
                    {
                        //change data transaction in database
                        updateTransaction.NotaNumber = txtNotaNum.Text.ToUpper();
                        updateTransaction.Discount = discount;
                        updateTransaction.Date = date;
                        if (radLunas.Checked == true) updateTransaction.Status = "LUNAS";
                        else updateTransaction.Status = "BELUM LUNAS";
                        updateTransaction.Information = rtxtKeterangan.Text.ToUpper();

                        MessageBox.Show("Success update data");
                    }
                }
                else return;

            }

            de.SaveChanges();
            clear_detail();
            update_transaction();
            update_sum();
            _tInsert = _tUpdate = false;
            modeDetail(true);
            modeTransaction(true);
            btnDInsert.Enabled = false;
            btnDUpdate.Enabled = false;
            btnDDelete.Enabled = false;
        }

        private void btnTCancel_Click(object sender, EventArgs e)
        {
            clear_transaction();
            clear_detail();
            _tInsert = _tUpdate = false;
            modeDetail(true);
            modeTransaction(true);
            btnDInsert.Enabled = false;
            btnDUpdate.Enabled = false;
            btnDDelete.Enabled = false;
        }

        private void input_detail()
        {
            Int64 temp;
            //nama barang
            if (txtNamaBarang.Text == "")
            {
                MessageBox.Show("Nama barang harus di isi");
                isNamaBrg = false;
            }
            else isNamaBrg = true;

            //quantity
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity harus di isi");
                isQty = false;
            }
            else if (!(Int64.TryParse(txtQuantity.Text, out temp)))
            {
                MessageBox.Show("Quantity harus angka");
                isQty = false;
            }
            else isQty = true;

            //harga jual
            if (txtHrgaJual.Text == "")
            {
                MessageBox.Show("Harga jual harus di isi");
                isSprice = false;
            }
            else if (!(Int64.TryParse(txtHrgaJual.Text, out temp)))
            {
                MessageBox.Show("Harga jual harus angka");
                isSprice = false;
            }
            else isSprice = true;
        }

        private void btnDInsert_Click(object sender, EventArgs e)
        {
            //mode
            modeTransaction(true);
            btnTInsert.Enabled = false;
            btnTUpdate.Enabled = false;
            btnTDelete.Enabled = false;
            transaction_grid.Enabled = false;
            modeDetail(false);
            //======================================================================================
            _dInsert = true;
            clear_detail();
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            if (detailId.Text == "") MessageBox.Show("Anda harus memilih data dulu");
            else
            {
                //mode
                modeTransaction(true);
                btnTInsert.Enabled = false;
                btnTUpdate.Enabled = false;
                btnTDelete.Enabled = false;
                transaction_grid.Enabled = false;
                modeDetail(false);
                //======================================================================================
                _dUpdate = true;
            }
        }

        private void btnDDelete_Click(object sender, EventArgs e)
        {
            if (detailId.Text == "") MessageBox.Show("Anda harus memilih data dulu");
            else
            {
                int myId = int.Parse(detailId.Text.ToString());
                tblDetail deleteDetail = (from x in de.tblDetails
                                          where x.DetailId == myId
                                          select x).FirstOrDefault();
                DialogResult result = MessageBox.Show("Apa Anda yakin ingin delete data?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (detail_grid.RowCount == 1)
                    {
                        MessageBox.Show("Detail tidak bisa kosong");
                        return;
                    }
                    else
                    {
                        de.tblDetails.Remove(deleteDetail);
                        clear_detail();
                    }
                }
                else return;
                de.SaveChanges();
                update_detail();
            }
        }

        private void btnDSubmit_Click(object sender, EventArgs e)
        {
            //====================================== if insert detail ============================================
            if (_dInsert)
            {
                input_detail();

                if (isNamaBrg && isQty && isSprice && isBprice)
                {
                    //check klo transaction ud dbuat prtma kali
                    if (detail_grid.RowCount == 0)
                    {
                        if (radLunas.Checked == true)
                        {
                            tblTransaction newTransaction = new tblTransaction
                            {
                                ShopId = currentId,
                                NotaNumber = txtNotaNum.Text.ToUpper(),
                                Discount = discount,
                                Date = date,
                                Information = rtxtKeterangan.Text.ToUpper(),
                                Status = "LUNAS"
                            };
                            de.tblTransactions.Add(newTransaction);
                        }
                        else
                        {
                            tblTransaction newTransaction = new tblTransaction
                            {
                                ShopId = currentId,
                                NotaNumber = txtNotaNum.Text.ToUpper(),
                                Discount = discount,
                                Date = date,
                                Information = rtxtKeterangan.Text.ToUpper(),
                                Status = "BELUM LUNAS"
                            };
                            de.tblTransactions.Add(newTransaction);
                        }
                        de.SaveChanges();
                        
                    }
                    //get latest id
                    var query = (from x in de.tblTransactions
                                 orderby x.TransactionId descending
                                 select x).FirstOrDefault();
                    lblTransId.Text = query.TransactionId.ToString();
                    tblDetail newDetail = new tblDetail
                    {
                        TransactionId = int.Parse(query.TransactionId.ToString()),
                        ProductName = txtNamaBarang.Text.ToUpper(),
                        Quantity = int.Parse(txtQuantity.Text),
                        SellPrice = int.Parse(txtHrgaJual.Text)
                    };
                    de.tblDetails.Add(newDetail);
                    MessageBox.Show("Success input detail baru");
                   
                }
                else return;
            }
            //====================================== if update detail ============================================
            else if (_dUpdate)
            {
                int myId = int.Parse(detailId.Text.ToString());
                tblDetail updateDetail = (from x in de.tblDetails
                                          where x.DetailId == myId
                                          select x).FirstOrDefault();

                input_detail();

                if (isNamaBrg && isQty && isSprice && isBprice)
                {
                    updateDetail.ProductName = txtNamaBarang.Text.ToUpper();
                    updateDetail.Quantity = int.Parse(txtQuantity.Text);
                    updateDetail.SellPrice = int.Parse(txtHrgaJual.Text);
                    //updateDetail.BuyPrice = int.Parse(txtHrgaBeli.Text);

                    MessageBox.Show("Success update data");
                }
                else return;
            }

            de.SaveChanges();
            clear_detail();
            update_detail();
            update_transaction();
            _dInsert = _dUpdate = false;
            //mode
            modeTransaction(false);
            modeDetail(true);
            transaction_grid.Enabled = false;
            detail_grid.Enabled = true;
        }

        private void btnDCancel_Click(object sender, EventArgs e)
        {
            _dInsert = _dUpdate = false;
            clear_detail();
            //mode
            modeTransaction(false);
            modeDetail(true);
            btnTInsert.Enabled = false;
            btnTUpdate.Enabled = false;
            btnTDelete.Enabled = false;
            btnTSubmit.Enabled = true;
            btnTCancel.Enabled = true;
            transaction_grid.Enabled = false;
            detail_grid.Enabled = true;
        }
    }
}
