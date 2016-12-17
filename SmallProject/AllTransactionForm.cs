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
using System.Data.Objects.SqlClient;

namespace SmallProject
{
    public partial class AllTransactionForm : Form
    {
        Database1Entities6 de = new Database1Entities6();
        DateTime date;
        String myDate, status, month, datemonth;
        BindingSource bdall;
        int piutang = 0;
        public AllTransactionForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            date = DateTime.Now;
            myDate = dtpTransactionSearch.Value.ToString("dd-MMM-yy");
            date = DateTime.ParseExact(myDate, "dd-MMM-yy", CultureInfo.InvariantCulture);
            //set bulan combobox value and text
            cmbMonth.DisplayMember = "Month";
            cmbMonth.ValueMember = "Value";
            var items = new[]
            {
                new {Month="January", Value="1"},
                new {Month="February", Value="2"},
                new {Month="March", Value="3"},
                new {Month="April", Value="4"},
                new {Month="Mei", Value="5"},
                new {Month="June", Value="6"},
                new {Month="July", Value="7"},
                new {Month="August", Value="8"},
                new {Month="September", Value="9"},
                new {Month="October", Value="10"},
                new {Month="November", Value="11"},
                new {Month="December", Value="12"},
            };
            cmbMonth.DataSource = items;
            cmbMonth.SelectedIndex = -1;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            piutang = 0;
            bdall = new BindingSource();
            bdall.DataSource = (from x in de.tblDetails
                                group x by x.TransactionId into total
                                join y in de.tblTransactions on total.Key equals y.TransactionId
                                join z in de.tblShops on y.ShopId equals z.ShopId
                                orderby z.ShopName ascending
                                select new
                                {
                                    Toko = z.ShopName,
                                    NomorNota = y.NotaNumber,
                                    Alamat = z.Address,
                                    Tanggal = y.Date,
                                    Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                    Status = y.Status,
                                    Informasi = y.Information
                                }).ToList();
            allTtrans_grid.DataSource = bdall;
            foreach (DataGridViewRow rows in allTtrans_grid.Rows)
            {
                piutang += int.Parse(rows.Cells[4].Value.ToString());
            }
            lblPiutang.Text = "Total piutang: Rp. " + piutang.ToString("##,#");
            if (allTtrans_grid.RowCount > 0)
            {
                this.allTtrans_grid.Columns["Tagihan"].DefaultCellStyle.Format = "##,#";
                this.allTtrans_grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }

            radBlmLunas.Checked = false;
            radLunas.Checked = false;
            txtSearch.Text = "";
            cmbMonth.SelectedIndex = -1;
        }

        private void update_data()
        {
            piutang = 0;
            bdall = new BindingSource();
            if (radLunas.Checked == false && radBlmLunas.Checked == false)
            {
                bdall.DataSource = (from x in de.tblDetails
                                    group x by x.TransactionId into total
                                    join y in de.tblTransactions on total.Key equals y.TransactionId
                                    join z in de.tblShops on y.ShopId equals z.ShopId
                                    where z.ShopName.Contains(txtSearch.Text) && y.NotaNumber.Contains(txtNotaNum.Text) && datemonth == month
                                    orderby z.ShopName ascending
                                    select new
                                    {
                                        Toko = z.ShopName,
                                        NomorNota = y.NotaNumber,
                                        Alamat = z.Address,
                                        Tanggal = y.Date,
                                        Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                        Status = y.Status,
                                        Informasi = y.Information
                                    }).ToList();
            }
            else
            {
                if (radLunas.Checked == true) status = "LUNAS";
                else if (radBlmLunas.Checked == true) status = "BELUM LUNAS";

                bdall.DataSource = (from x in de.tblDetails
                                    group x by x.TransactionId into total
                                    join y in de.tblTransactions on total.Key equals y.TransactionId
                                    join z in de.tblShops on y.ShopId equals z.ShopId
                                    where z.ShopName.Contains(txtSearch.Text) && y.NotaNumber.Contains(txtNotaNum.Text) && y.Status == status && datemonth == month
                                    orderby z.ShopName ascending
                                    select new
                                    {
                                        Toko = z.ShopName,
                                        NomorNota = y.NotaNumber,
                                        Alamat = z.Address,
                                        Tanggal = y.Date,
                                        Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                        Status = y.Status,
                                        Informasi = y.Information
                                    }).ToList();
            }
            allTtrans_grid.DataSource = bdall;
            foreach (DataGridViewRow rows in allTtrans_grid.Rows)
            {
                piutang += int.Parse(rows.Cells[4].Value.ToString());
            }
            lblPiutang.Text = "Total piutang: Rp. " + piutang.ToString("##,#");
            if (allTtrans_grid.RowCount > 0)
            {
                this.allTtrans_grid.Columns["Tagihan"].DefaultCellStyle.Format = "##,#";
                this.allTtrans_grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            piutang = 0;
            bdall = new BindingSource();
            bdall.DataSource = (from x in de.tblDetails
                                group x by x.TransactionId into total
                                join y in de.tblTransactions on total.Key equals y.TransactionId
                                join z in de.tblShops on y.ShopId equals z.ShopId
                                where y.Date == date
                                orderby z.ShopName ascending
                                select new
                                {
                                    Toko = z.ShopName,
                                    NomorNota = y.NotaNumber,
                                    Alamat = z.Address,
                                    Tanggal = y.Date,
                                    Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                    Status = y.Status,
                                    Informasi = y.Information
                                }).ToList();
            allTtrans_grid.DataSource = bdall;
            foreach (DataGridViewRow rows in allTtrans_grid.Rows)
            {
                piutang += int.Parse(rows.Cells[4].Value.ToString());
            }
            lblPiutang.Text = "Total piutang: Rp. " + piutang.ToString("##,#");
            if (allTtrans_grid.RowCount > 0)
            {
                this.allTtrans_grid.Columns["Tagihan"].DefaultCellStyle.Format = "##,#";
                this.allTtrans_grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            update_data();
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            piutang = 0;
            bdall = new BindingSource();
            bdall.DataSource = (from x in de.tblDetails
                                group x by x.TransactionId into total
                                join y in de.tblTransactions on total.Key equals y.TransactionId
                                join z in de.tblShops on y.ShopId equals z.ShopId
                                orderby z.ShopName ascending
                                select new
                                {
                                    Toko = z.ShopName,
                                    NomorNota = y.NotaNumber,
                                    Alamat = z.Address,
                                    Tanggal = y.Date,
                                    Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                    Status = y.Status,
                                    Informasi = y.Information
                                }).ToList();
            allTtrans_grid.DataSource = bdall;
            foreach (DataGridViewRow rows in allTtrans_grid.Rows)
            {
                piutang += int.Parse(rows.Cells[4].Value.ToString());
            }
            lblPiutang.Text = "Total piutang: Rp. " + piutang.ToString("##,#");
            if (allTtrans_grid.RowCount > 0)
            {
                this.allTtrans_grid.Columns["Tagihan"].DefaultCellStyle.Format = "##,#";
                this.allTtrans_grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            bdall = new BindingSource();
            bdall.DataSource = (from x in de.tblDetails
                                group x by x.TransactionId into total
                                join y in de.tblTransactions on total.Key equals y.TransactionId
                                join z in de.tblShops on y.ShopId equals z.ShopId
                                orderby y.Date ascending
                                select new
                                {
                                    Toko = z.ShopName,
                                    NomorNota = y.NotaNumber,
                                    Alamat = z.Address,
                                    Tanggal = y.Date,
                                    Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                    Status = y.Status,
                                    Informasi = y.Information
                                }).ToList();
            allTtrans_grid.DataSource = bdall;
            foreach (DataGridViewRow rows in allTtrans_grid.Rows)
            {
                piutang += int.Parse(rows.Cells[4].Value.ToString());
            }
            lblPiutang.Text = "Total piutang: Rp. " + piutang.ToString("##,#");
            if (allTtrans_grid.RowCount > 0)
            {
                this.allTtrans_grid.Columns["Tagihan"].DefaultCellStyle.Format = "##,#";
                this.allTtrans_grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }

        }

        private void txtNotaNum_TextChanged(object sender, EventArgs e)
        {
            update_data();
        }

        private void cmbMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            month = cmbMonth.SelectedValue.ToString();
            var query = (from x in de.tblDetails
                         group x by x.TransactionId into total
                         join y in de.tblTransactions on total.Key equals y.TransactionId
                         join z in de.tblShops on y.ShopId equals z.ShopId
                         select y.Date).FirstOrDefault();
            datemonth = query.ToString("MM");
            update_data();
            /*
            bdall = new BindingSource();
            bdall.DataSource = (from x in de.tblDetails
                                group x by x.TransactionId into total
                                join y in de.tblTransactions on total.Key equals y.TransactionId
                                join z in de.tblShops on y.ShopId equals z.ShopId
                                where datemonth == month
                                select new
                                {
                                    Toko = z.ShopName,
                                    NomorNota = y.NotaNumber,
                                    Alamat = z.Address,
                                    Tanggal = y.Date,
                                    Tagihan = total.Sum(t => t.SellPrice * t.Quantity),
                                    Status = y.Status,
                                    Informasi = y.Information
                                }).ToList();
            allTtrans_grid.DataSource = bdall;
            foreach (DataGridViewRow rows in allTtrans_grid.Rows)
            {
                piutang += int.Parse(rows.Cells[4].Value.ToString());
            }
            lblPiutang.Text = "Total piutang: Rp. " + piutang.ToString("##,#");
            if (allTtrans_grid.RowCount > 0)
            {
                this.allTtrans_grid.Columns["Tagihan"].DefaultCellStyle.Format = "##,#";
                this.allTtrans_grid.Columns["Tanggal"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
            */
        }

        private void dtpTransactionSearch_ValueChanged(object sender, EventArgs e)
        {
            date = dtpTransactionSearch.Value;
            myDate = dtpTransactionSearch.Value.ToString("dd-MMM-yy");
            date = DateTime.ParseExact(myDate, "dd-MMM-yy", CultureInfo.InvariantCulture);
        }
    }
}
