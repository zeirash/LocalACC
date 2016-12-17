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
        String myDate, status, month, datemonth, year, dateyear;
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
                new {Month="January", Value="Jan"},
                new {Month="February", Value="Feb"},
                new {Month="March", Value="Mar"},
                new {Month="April", Value="Apr"},
                new {Month="May", Value="May"},
                new {Month="June", Value="Jun"},
                new {Month="July", Value="Jul"},
                new {Month="August", Value="Aug"},
                new {Month="September", Value="Sep"},
                new {Month="October", Value="Oct"},
                new {Month="November", Value="Nov"},
                new {Month="December", Value="Dec"},
            };
            cmbMonth.DataSource = items;
            cmbMonth.SelectedIndex = -1;

            //set tahun combobox value and text
            cmbYear.DisplayMember = "Year";
            cmbYear.ValueMember = "ValueYear";
            string sdate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sdate.ToString()));
            year = datevalue.Year.ToString();

            var yearItems = new object();
            //if value already exist in combo box year
            if (cmbYear.Items.Count == 0)
            {
                yearItems = new[] { new { Year = year, ValueYear = year } };
            }
            else
            {
                for (int i = 0; i < cmbYear.Items.Count; i++)
                {
                    if (year == cmbYear.GetItemText(cmbYear.Items[i])) return;
                    else
                    {
                        yearItems = new[] { new { Year = year, ValueYear = year } };
                    }
                }
            }
            cmbYear.DataSource = yearItems;
            cmbYear.SelectedIndex = -1;
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
            cmbYear.SelectedIndex = -1;
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
                                    where z.ShopName.Contains(txtSearch.Text) && y.NotaNumber.Contains(txtNotaNum.Text) && datemonth == month && dateyear == year
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
                                    where z.ShopName.Contains(txtSearch.Text) && y.NotaNumber.Contains(txtNotaNum.Text) && y.Status == status && datemonth == month && dateyear == year
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

        private void cmbYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            year = cmbYear.SelectedValue.ToString();
            var query = (from x in de.tblDetails
                         group x by x.TransactionId into total
                         join y in de.tblTransactions on total.Key equals y.TransactionId
                         join z in de.tblShops on y.ShopId equals z.ShopId
                         select y.Date).FirstOrDefault();
            dateyear = query.ToString("yyyy");
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
            datemonth = query.ToString("MMM");
            update_data();
        }

        private void dtpTransactionSearch_ValueChanged(object sender, EventArgs e)
        {
            date = dtpTransactionSearch.Value;
            myDate = dtpTransactionSearch.Value.ToString("dd-MMM-yy");
            date = DateTime.ParseExact(myDate, "dd-MMM-yy", CultureInfo.InvariantCulture);
        }
    }
}
