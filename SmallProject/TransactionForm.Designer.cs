namespace SmallProject
{
    partial class TransactionForm
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
            this.txtNotaNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBlmLunas = new System.Windows.Forms.RadioButton();
            this.radLunas = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rtxtKeterangan = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTDelete = new System.Windows.Forms.Button();
            this.btnTInsert = new System.Windows.Forms.Button();
            this.btnTUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTCancel = new System.Windows.Forms.Button();
            this.btnTSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDSubmit = new System.Windows.Forms.Button();
            this.txtHrgaJual = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDDelete = new System.Windows.Forms.Button();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.btnDUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTransactionSearch = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.transaction_grid = new System.Windows.Forms.DataGridView();
            this.detail_grid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalJual = new System.Windows.Forms.Label();
            this.detailId = new System.Windows.Forms.Label();
            this.lblTransId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotaNum
            // 
            this.txtNotaNum.Location = new System.Drawing.Point(169, 31);
            this.txtNotaNum.Name = "txtNotaNum";
            this.txtNotaNum.Size = new System.Drawing.Size(211, 26);
            this.txtNotaNum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. nota";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBlmLunas);
            this.groupBox1.Controls.Add(this.radLunas);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rtxtKeterangan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnTDelete);
            this.groupBox1.Controls.Add(this.btnTInsert);
            this.groupBox1.Controls.Add(this.btnTUpdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpTransactionDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNotaNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(766, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 283);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction data";
            // 
            // radBlmLunas
            // 
            this.radBlmLunas.AutoSize = true;
            this.radBlmLunas.Location = new System.Drawing.Point(265, 168);
            this.radBlmLunas.Name = "radBlmLunas";
            this.radBlmLunas.Size = new System.Drawing.Size(114, 24);
            this.radBlmLunas.TabIndex = 9;
            this.radBlmLunas.TabStop = true;
            this.radBlmLunas.Text = "Belum lunas";
            this.radBlmLunas.UseVisualStyleBackColor = true;
            // 
            // radLunas
            // 
            this.radLunas.AutoSize = true;
            this.radLunas.Location = new System.Drawing.Point(168, 168);
            this.radLunas.Name = "radLunas";
            this.radLunas.Size = new System.Drawing.Size(71, 24);
            this.radLunas.TabIndex = 8;
            this.radLunas.TabStop = true;
            this.radLunas.Text = "Lunas";
            this.radLunas.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Status";
            // 
            // rtxtKeterangan
            // 
            this.rtxtKeterangan.Location = new System.Drawing.Point(169, 206);
            this.rtxtKeterangan.Name = "rtxtKeterangan";
            this.rtxtKeterangan.Size = new System.Drawing.Size(211, 61);
            this.rtxtKeterangan.TabIndex = 10;
            this.rtxtKeterangan.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "%";
            // 
            // btnTDelete
            // 
            this.btnTDelete.Location = new System.Drawing.Point(411, 206);
            this.btnTDelete.Name = "btnTDelete";
            this.btnTDelete.Size = new System.Drawing.Size(111, 55);
            this.btnTDelete.TabIndex = 13;
            this.btnTDelete.Text = "Delete transaction";
            this.btnTDelete.UseVisualStyleBackColor = true;
            this.btnTDelete.Click += new System.EventHandler(this.btnTDelete_Click);
            // 
            // btnTInsert
            // 
            this.btnTInsert.Location = new System.Drawing.Point(411, 41);
            this.btnTInsert.Name = "btnTInsert";
            this.btnTInsert.Size = new System.Drawing.Size(111, 55);
            this.btnTInsert.TabIndex = 11;
            this.btnTInsert.Text = "Insert transaction";
            this.btnTInsert.UseVisualStyleBackColor = true;
            this.btnTInsert.Click += new System.EventHandler(this.btnTInsert_Click);
            // 
            // btnTUpdate
            // 
            this.btnTUpdate.Location = new System.Drawing.Point(411, 123);
            this.btnTUpdate.Name = "btnTUpdate";
            this.btnTUpdate.Size = new System.Drawing.Size(111, 56);
            this.btnTUpdate.TabIndex = 12;
            this.btnTUpdate.Text = "Update transaction";
            this.btnTUpdate.UseVisualStyleBackColor = true;
            this.btnTUpdate.Click += new System.EventHandler(this.btnTUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.CustomFormat = "dd-MMM-yy";
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(169, 117);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(210, 26);
            this.dtpTransactionDate.TabIndex = 7;
            this.dtpTransactionDate.ValueChanged += new System.EventHandler(this.dtpTransactionDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diskon*";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(169, 74);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(182, 26);
            this.txtDiscount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Keterangan*";
            // 
            // btnTCancel
            // 
            this.btnTCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCancel.Location = new System.Drawing.Point(1093, 613);
            this.btnTCancel.Name = "btnTCancel";
            this.btnTCancel.Size = new System.Drawing.Size(89, 33);
            this.btnTCancel.TabIndex = 24;
            this.btnTCancel.Text = "Cancel";
            this.btnTCancel.UseVisualStyleBackColor = true;
            this.btnTCancel.Click += new System.EventHandler(this.btnTCancel_Click);
            // 
            // btnTSubmit
            // 
            this.btnTSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSubmit.Location = new System.Drawing.Point(935, 613);
            this.btnTSubmit.Name = "btnTSubmit";
            this.btnTSubmit.Size = new System.Drawing.Size(89, 34);
            this.btnTSubmit.TabIndex = 23;
            this.btnTSubmit.Text = "Submit";
            this.btnTSubmit.UseVisualStyleBackColor = true;
            this.btnTSubmit.Click += new System.EventHandler(this.btnTSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDCancel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDSubmit);
            this.groupBox2.Controls.Add(this.txtHrgaJual);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnDDelete);
            this.groupBox2.Controls.Add(this.txtNamaBarang);
            this.groupBox2.Controls.Add(this.btnDUpdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnDInsert);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(766, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 267);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail data";
            // 
            // btnDCancel
            // 
            this.btnDCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDCancel.Location = new System.Drawing.Point(327, 206);
            this.btnDCancel.Name = "btnDCancel";
            this.btnDCancel.Size = new System.Drawing.Size(110, 36);
            this.btnDCancel.TabIndex = 22;
            this.btnDCancel.Text = "Cancel";
            this.btnDCancel.UseVisualStyleBackColor = true;
            this.btnDCancel.Click += new System.EventHandler(this.btnDCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga jual";
            // 
            // btnDSubmit
            // 
            this.btnDSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSubmit.Location = new System.Drawing.Point(129, 206);
            this.btnDSubmit.Name = "btnDSubmit";
            this.btnDSubmit.Size = new System.Drawing.Size(110, 36);
            this.btnDSubmit.TabIndex = 21;
            this.btnDSubmit.Text = "Submit";
            this.btnDSubmit.UseVisualStyleBackColor = true;
            this.btnDSubmit.Click += new System.EventHandler(this.btnDSubmit_Click);
            // 
            // txtHrgaJual
            // 
            this.txtHrgaJual.Location = new System.Drawing.Point(152, 146);
            this.txtHrgaJual.Name = "txtHrgaJual";
            this.txtHrgaJual.Size = new System.Drawing.Size(184, 26);
            this.txtHrgaJual.TabIndex = 19;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(152, 100);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(184, 26);
            this.txtQuantity.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nama barang";
            // 
            // btnDDelete
            // 
            this.btnDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDelete.Location = new System.Drawing.Point(389, 149);
            this.btnDDelete.Name = "btnDDelete";
            this.btnDDelete.Size = new System.Drawing.Size(133, 32);
            this.btnDDelete.TabIndex = 16;
            this.btnDDelete.Text = "Delete detail";
            this.btnDDelete.UseVisualStyleBackColor = true;
            this.btnDDelete.Click += new System.EventHandler(this.btnDDelete_Click);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(152, 54);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(184, 26);
            this.txtNamaBarang.TabIndex = 17;
            // 
            // btnDUpdate
            // 
            this.btnDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDUpdate.Location = new System.Drawing.Point(389, 97);
            this.btnDUpdate.Name = "btnDUpdate";
            this.btnDUpdate.Size = new System.Drawing.Size(133, 32);
            this.btnDUpdate.TabIndex = 15;
            this.btnDUpdate.Text = "Update detail";
            this.btnDUpdate.UseVisualStyleBackColor = true;
            this.btnDUpdate.Click += new System.EventHandler(this.btnDUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Quantity";
            // 
            // btnDInsert
            // 
            this.btnDInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDInsert.Location = new System.Drawing.Point(389, 45);
            this.btnDInsert.Name = "btnDInsert";
            this.btnDInsert.Size = new System.Drawing.Size(133, 32);
            this.btnDInsert.TabIndex = 14;
            this.btnDInsert.Text = "Insert detail";
            this.btnDInsert.UseVisualStyleBackColor = true;
            this.btnDInsert.Click += new System.EventHandler(this.btnDInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transaction";
            // 
            // dtpTransactionSearch
            // 
            this.dtpTransactionSearch.CustomFormat = "dd-MMM-yy";
            this.dtpTransactionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransactionSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionSearch.Location = new System.Drawing.Point(457, 47);
            this.dtpTransactionSearch.Name = "dtpTransactionSearch";
            this.dtpTransactionSearch.Size = new System.Drawing.Size(133, 26);
            this.dtpTransactionSearch.TabIndex = 9;
            this.dtpTransactionSearch.ValueChanged += new System.EventHandler(this.dtpTransactionSearch_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 582);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 20);
            this.label18.TabIndex = 18;
            this.label18.Text = "Total jual          : Rp.";
            // 
            // transaction_grid
            // 
            this.transaction_grid.AllowUserToAddRows = false;
            this.transaction_grid.AllowUserToDeleteRows = false;
            this.transaction_grid.AllowUserToOrderColumns = true;
            this.transaction_grid.AllowUserToResizeColumns = false;
            this.transaction_grid.AllowUserToResizeRows = false;
            this.transaction_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transaction_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transaction_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.transaction_grid.Location = new System.Drawing.Point(24, 82);
            this.transaction_grid.Name = "transaction_grid";
            this.transaction_grid.Size = new System.Drawing.Size(694, 207);
            this.transaction_grid.TabIndex = 20;
            this.transaction_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transaction_grid_CellClick);
            // 
            // detail_grid
            // 
            this.detail_grid.AllowUserToAddRows = false;
            this.detail_grid.AllowUserToDeleteRows = false;
            this.detail_grid.AllowUserToOrderColumns = true;
            this.detail_grid.AllowUserToResizeColumns = false;
            this.detail_grid.AllowUserToResizeRows = false;
            this.detail_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detail_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detail_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.detail_grid.Location = new System.Drawing.Point(24, 369);
            this.detail_grid.Name = "detail_grid";
            this.detail_grid.Size = new System.Drawing.Size(694, 207);
            this.detail_grid.TabIndex = 21;
            this.detail_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detail_grid_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Detail";
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShop.Location = new System.Drawing.Point(20, 9);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(60, 20);
            this.lblShop.TabIndex = 23;
            this.lblShop.Text = "label14";
            // 
            // btnShowDate
            // 
            this.btnShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDate.Location = new System.Drawing.Point(596, 45);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(122, 34);
            this.btnShowDate.TabIndex = 19;
            this.btnShowDate.Text = "Show by date";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(319, 45);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(89, 34);
            this.btnShowAll.TabIndex = 24;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(762, 613);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "* Bila ada";
            // 
            // lblTotalJual
            // 
            this.lblTotalJual.AutoSize = true;
            this.lblTotalJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJual.Location = new System.Drawing.Point(167, 582);
            this.lblTotalJual.Name = "lblTotalJual";
            this.lblTotalJual.Size = new System.Drawing.Size(18, 20);
            this.lblTotalJual.TabIndex = 25;
            this.lblTotalJual.Text = "0";
            // 
            // detailId
            // 
            this.detailId.AutoSize = true;
            this.detailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailId.Location = new System.Drawing.Point(658, 346);
            this.detailId.Name = "detailId";
            this.detailId.Size = new System.Drawing.Size(63, 20);
            this.detailId.TabIndex = 27;
            this.detailId.Text = "detail id";
            // 
            // lblTransId
            // 
            this.lblTransId.AutoSize = true;
            this.lblTransId.Location = new System.Drawing.Point(610, 293);
            this.lblTransId.Name = "lblTransId";
            this.lblTransId.Size = new System.Drawing.Size(74, 13);
            this.lblTransId.TabIndex = 24;
            this.lblTransId.Text = "Transaction id";
            this.lblTransId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "detail id";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTransId);
            this.Controls.Add(this.detailId);
            this.Controls.Add(this.lblTotalJual);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.btnTCancel);
            this.Controls.Add(this.btnTSubmit);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.detail_grid);
            this.Controls.Add(this.transaction_grid);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtpTransactionSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotaNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTCancel;
        private System.Windows.Forms.Button btnTSubmit;
        private System.Windows.Forms.Button btnTDelete;
        private System.Windows.Forms.Button btnTInsert;
        private System.Windows.Forms.Button btnTUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHrgaJual;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTransactionSearch;
        private System.Windows.Forms.Button btnDInsert;
        private System.Windows.Forms.Button btnDDelete;
        private System.Windows.Forms.Button btnDUpdate;
        private System.Windows.Forms.Button btnDCancel;
        private System.Windows.Forms.Button btnDSubmit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView transaction_grid;
        private System.Windows.Forms.DataGridView detail_grid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxtKeterangan;
        private System.Windows.Forms.RadioButton radBlmLunas;
        private System.Windows.Forms.RadioButton radLunas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalJual;
        private System.Windows.Forms.Label detailId;
        private System.Windows.Forms.Label lblTransId;
        private System.Windows.Forms.Label label1;
    }
}