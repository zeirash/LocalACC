namespace SmallProject
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shop_Grid = new System.Windows.Forms.DataGridView();
            this.expedition_Grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbExpedition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtboxShopAddress = new System.Windows.Forms.RichTextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtShopNumber = new System.Windows.Forms.TextBox();
            this.txtOwnerNumber = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.btnAddExpedition = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shop_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expedition_Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop_Grid
            // 
            this.shop_Grid.AllowUserToAddRows = false;
            this.shop_Grid.AllowUserToDeleteRows = false;
            this.shop_Grid.AllowUserToOrderColumns = true;
            this.shop_Grid.AllowUserToResizeColumns = false;
            this.shop_Grid.AllowUserToResizeRows = false;
            this.shop_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shop_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shop_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shop_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.shop_Grid.Location = new System.Drawing.Point(662, 121);
            this.shop_Grid.Name = "shop_Grid";
            this.shop_Grid.Size = new System.Drawing.Size(668, 233);
            this.shop_Grid.TabIndex = 0;
            this.shop_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shop_Grid_CellClick);
            // 
            // expedition_Grid
            // 
            this.expedition_Grid.AllowUserToAddRows = false;
            this.expedition_Grid.AllowUserToDeleteRows = false;
            this.expedition_Grid.AllowUserToOrderColumns = true;
            this.expedition_Grid.AllowUserToResizeColumns = false;
            this.expedition_Grid.AllowUserToResizeRows = false;
            this.expedition_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expedition_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.expedition_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expedition_Grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.expedition_Grid.Location = new System.Drawing.Point(662, 448);
            this.expedition_Grid.Name = "expedition_Grid";
            this.expedition_Grid.Size = new System.Drawing.Size(668, 193);
            this.expedition_Grid.TabIndex = 1;
            this.expedition_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expedition_Grid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.cmbExpedition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtxtboxShopAddress);
            this.groupBox1.Controls.Add(this.txtOwnerName);
            this.groupBox1.Controls.Add(this.txtShopNumber);
            this.groupBox1.Controls.Add(this.txtOwnerNumber);
            this.groupBox1.Controls.Add(this.txtShopName);
            this.groupBox1.Controls.Add(this.btnViewTransaction);
            this.groupBox1.Controls.Add(this.btnAddExpedition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 574);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop detail";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(223, 360);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(164, 37);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove Expedition";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "* Bila ada";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(483, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(483, 440);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 31);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbExpedition
            // 
            this.cmbExpedition.FormattingEnabled = true;
            this.cmbExpedition.Location = new System.Drawing.Point(268, 442);
            this.cmbExpedition.Name = "cmbExpedition";
            this.cmbExpedition.Size = new System.Drawing.Size(190, 28);
            this.cmbExpedition.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ekspedisi";
            // 
            // rtxtboxShopAddress
            // 
            this.rtxtboxShopAddress.Enabled = false;
            this.rtxtboxShopAddress.Location = new System.Drawing.Point(268, 91);
            this.rtxtboxShopAddress.Name = "rtxtboxShopAddress";
            this.rtxtboxShopAddress.Size = new System.Drawing.Size(257, 96);
            this.rtxtboxShopAddress.TabIndex = 11;
            this.rtxtboxShopAddress.Text = "";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Enabled = false;
            this.txtOwnerName.Location = new System.Drawing.Point(268, 254);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(257, 26);
            this.txtOwnerName.TabIndex = 10;
            // 
            // txtShopNumber
            // 
            this.txtShopNumber.Enabled = false;
            this.txtShopNumber.Location = new System.Drawing.Point(268, 210);
            this.txtShopNumber.Name = "txtShopNumber";
            this.txtShopNumber.Size = new System.Drawing.Size(257, 26);
            this.txtShopNumber.TabIndex = 9;
            // 
            // txtOwnerNumber
            // 
            this.txtOwnerNumber.Enabled = false;
            this.txtOwnerNumber.Location = new System.Drawing.Point(268, 298);
            this.txtOwnerNumber.Name = "txtOwnerNumber";
            this.txtOwnerNumber.Size = new System.Drawing.Size(257, 26);
            this.txtOwnerNumber.TabIndex = 8;
            // 
            // txtShopName
            // 
            this.txtShopName.Enabled = false;
            this.txtShopName.Location = new System.Drawing.Point(268, 47);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(257, 26);
            this.txtShopName.TabIndex = 7;
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Location = new System.Drawing.Point(418, 360);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(158, 37);
            this.btnViewTransaction.TabIndex = 6;
            this.btnViewTransaction.Text = "View Transaction";
            this.btnViewTransaction.UseVisualStyleBackColor = true;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // btnAddExpedition
            // 
            this.btnAddExpedition.Location = new System.Drawing.Point(38, 360);
            this.btnAddExpedition.Name = "btnAddExpedition";
            this.btnAddExpedition.Size = new System.Drawing.Size(150, 37);
            this.btnAddExpedition.TabIndex = 5;
            this.btnAddExpedition.Text = "Add Expedition";
            this.btnAddExpedition.UseVisualStyleBackColor = true;
            this.btnAddExpedition.Click += new System.EventHandler(this.btnAddExpedition_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telepon pemilik*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama pemilik*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telepon toko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama toko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1003, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search shop name";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1172, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 26);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(657, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Shop";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(657, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Expedition";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 667);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.expedition_Grid);
            this.Controls.Add(this.shop_Grid);
            this.Name = "DetailForm";
            this.Text = "Detail Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.shop_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expedition_Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shop_Grid;
        private System.Windows.Forms.DataGridView expedition_Grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewTransaction;
        private System.Windows.Forms.Button btnAddExpedition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbExpedition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtboxShopAddress;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtShopNumber;
        private System.Windows.Forms.TextBox txtOwnerNumber;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemove;
    }
}