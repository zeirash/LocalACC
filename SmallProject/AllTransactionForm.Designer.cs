namespace SmallProject
{
    partial class AllTransactionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allTtrans_grid = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dtpTransactionSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotaNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radBlmLunas = new System.Windows.Forms.RadioButton();
            this.radLunas = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            this.lblPiutang = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.allTtrans_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allTtrans_grid
            // 
            this.allTtrans_grid.AllowUserToAddRows = false;
            this.allTtrans_grid.AllowUserToDeleteRows = false;
            this.allTtrans_grid.AllowUserToOrderColumns = true;
            this.allTtrans_grid.AllowUserToResizeColumns = false;
            this.allTtrans_grid.AllowUserToResizeRows = false;
            this.allTtrans_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allTtrans_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.allTtrans_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allTtrans_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.allTtrans_grid.Location = new System.Drawing.Point(54, 128);
            this.allTtrans_grid.Name = "allTtrans_grid";
            this.allTtrans_grid.Size = new System.Drawing.Size(892, 345);
            this.allTtrans_grid.TabIndex = 21;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(554, 88);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(89, 34);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dtpTransactionSearch
            // 
            this.dtpTransactionSearch.CustomFormat = "dd-MMM-yy";
            this.dtpTransactionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransactionSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionSearch.Location = new System.Drawing.Point(664, 90);
            this.dtpTransactionSearch.Name = "dtpTransactionSearch";
            this.dtpTransactionSearch.Size = new System.Drawing.Size(151, 26);
            this.dtpTransactionSearch.TabIndex = 25;
            this.dtpTransactionSearch.ValueChanged += new System.EventHandler(this.dtpTransactionSearch_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nama toko";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNotaNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radBlmLunas);
            this.groupBox1.Controls.Add(this.radLunas);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(982, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 296);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Bulan";
            // 
            // txtNotaNum
            // 
            this.txtNotaNum.Location = new System.Drawing.Point(121, 103);
            this.txtNotaNum.Name = "txtNotaNum";
            this.txtNotaNum.Size = new System.Drawing.Size(195, 26);
            this.txtNotaNum.TabIndex = 35;
            this.txtNotaNum.TextChanged += new System.EventHandler(this.txtNotaNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "No. nota";
            // 
            // radBlmLunas
            // 
            this.radBlmLunas.AutoSize = true;
            this.radBlmLunas.Location = new System.Drawing.Point(202, 201);
            this.radBlmLunas.Name = "radBlmLunas";
            this.radBlmLunas.Size = new System.Drawing.Size(114, 24);
            this.radBlmLunas.TabIndex = 33;
            this.radBlmLunas.TabStop = true;
            this.radBlmLunas.Text = "Belum lunas";
            this.radBlmLunas.UseVisualStyleBackColor = true;
            // 
            // radLunas
            // 
            this.radLunas.AutoSize = true;
            this.radLunas.Location = new System.Drawing.Point(125, 201);
            this.radLunas.Name = "radLunas";
            this.radLunas.Size = new System.Drawing.Size(71, 24);
            this.radLunas.TabIndex = 32;
            this.radLunas.TabStop = true;
            this.radLunas.Text = "Lunas";
            this.radLunas.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(121, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 26);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(21, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(295, 34);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "All Transaction";
            // 
            // btnDate
            // 
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.Location = new System.Drawing.Point(821, 88);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(125, 34);
            this.btnDate.TabIndex = 36;
            this.btnDate.Text = "Show by date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.Location = new System.Drawing.Point(982, 439);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(125, 34);
            this.btnSortName.TabIndex = 37;
            this.btnSortName.Text = "Sort by name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortDate
            // 
            this.btnSortDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDate.Location = new System.Drawing.Point(1201, 439);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(125, 34);
            this.btnSortDate.TabIndex = 38;
            this.btnSortDate.Text = "Sort by date";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // lblPiutang
            // 
            this.lblPiutang.AutoSize = true;
            this.lblPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiutang.Location = new System.Drawing.Point(50, 498);
            this.lblPiutang.Name = "lblPiutang";
            this.lblPiutang.Size = new System.Drawing.Size(147, 20);
            this.lblPiutang.TabIndex = 39;
            this.lblPiutang.Text = "Total piutang: Rp. 0";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(121, 154);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(195, 28);
            this.cmbMonth.TabIndex = 37;
            this.cmbMonth.SelectionChangeCommitted += new System.EventHandler(this.cmbMonth_SelectionChangeCommitted);
            // 
            // AllTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 541);
            this.Controls.Add(this.lblPiutang);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.allTtrans_grid);
            this.Controls.Add(this.dtpTransactionSearch);
            this.Name = "AllTransactionForm";
            this.Text = "AllTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.allTtrans_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allTtrans_grid;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DateTimePicker dtpTransactionSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radBlmLunas;
        private System.Windows.Forms.RadioButton radLunas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortDate;
        private System.Windows.Forms.TextBox txtNotaNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPiutang;
        private System.Windows.Forms.ComboBox cmbMonth;
    }
}