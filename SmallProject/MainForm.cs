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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //if ()
            //{
            //    TransactionForm transactionForm = new TransactionForm();
            //    transactionForm.MdiParent = this;
            //    transactionForm.Show();
            //    transactionForm.WindowState = FormWindowState.Minimized;
            //    transactionForm.WindowState = FormWindowState.Maximized;
            //}
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Dispose();
            DetailForm detailForm = new DetailForm(this);
            detailForm.MdiParent = this;
            detailForm.Show();
            detailForm.WindowState = FormWindowState.Minimized;
            detailForm.WindowState = FormWindowState.Maximized;
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Dispose();
            ShopForm shopForm = new ShopForm();
            shopForm.MdiParent = this;
            shopForm.Show();
            shopForm.WindowState = FormWindowState.Minimized;
            shopForm.WindowState = FormWindowState.Maximized;
        }

        private void expeditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Dispose();
            ExpeditionForm expeditionForm = new ExpeditionForm();
            expeditionForm.MdiParent = this;
            expeditionForm.Show();
            expeditionForm.WindowState = FormWindowState.Minimized;
            expeditionForm.WindowState = FormWindowState.Maximized;
        }

        private void allTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Dispose();
            AllTransactionForm allTransactionForm = new AllTransactionForm();
            allTransactionForm.MdiParent = this;
            allTransactionForm.Show();
            allTransactionForm.WindowState = FormWindowState.Minimized;
            allTransactionForm.WindowState = FormWindowState.Maximized;
        }
    }
}
