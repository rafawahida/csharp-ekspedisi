namespace project_kel8
{
    partial class BestShipment
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
            this.components = new System.ComponentModel.Container();
            this.dgvShipment = new System.Windows.Forms.DataGridView();
            this.nomorResiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTrsPengirimanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tblTrsPengirimanTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblTrsPengirimanTableAdapter();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrsPengirimanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShipment
            // 
            this.dgvShipment.AutoGenerateColumns = false;
            this.dgvShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorResiDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.iDJenisDataGridViewTextBoxColumn});
            this.dgvShipment.DataSource = this.tblTrsPengirimanBindingSource;
            this.dgvShipment.Location = new System.Drawing.Point(43, 207);
            this.dgvShipment.Name = "dgvShipment";
            this.dgvShipment.RowHeadersWidth = 51;
            this.dgvShipment.RowTemplate.Height = 24;
            this.dgvShipment.Size = new System.Drawing.Size(1518, 732);
            this.dgvShipment.TabIndex = 177;
            // 
            // nomorResiDataGridViewTextBoxColumn
            // 
            this.nomorResiDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Resi";
            this.nomorResiDataGridViewTextBoxColumn.HeaderText = "Nomor_Resi";
            this.nomorResiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorResiDataGridViewTextBoxColumn.Name = "nomorResiDataGridViewTextBoxColumn";
            this.nomorResiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDJenisDataGridViewTextBoxColumn
            // 
            this.iDJenisDataGridViewTextBoxColumn.DataPropertyName = "ID_Jenis";
            this.iDJenisDataGridViewTextBoxColumn.HeaderText = "ID_Jenis";
            this.iDJenisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDJenisDataGridViewTextBoxColumn.Name = "iDJenisDataGridViewTextBoxColumn";
            this.iDJenisDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblTrsPengirimanBindingSource
            // 
            this.tblTrsPengirimanBindingSource.DataMember = "tblTrsPengiriman";
            this.tblTrsPengirimanBindingSource.DataSource = this.dsEkspedisi;
            // 
            // dsEkspedisi
            // 
            this.dsEkspedisi.DataSetName = "dsEkspedisi";
            this.dsEkspedisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 176;
            this.label2.Text = "Tanggal Akhir";
            // 
            // dtAkhir
            // 
            this.dtAkhir.BorderRadius = 5;
            this.dtAkhir.Checked = true;
            this.dtAkhir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.dtAkhir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAkhir.ForeColor = System.Drawing.Color.White;
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAkhir.Location = new System.Drawing.Point(43, 134);
            this.dtAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.Size = new System.Drawing.Size(1312, 36);
            this.dtAkhir.TabIndex = 175;
            this.dtAkhir.Value = new System.DateTime(2023, 7, 20, 20, 41, 18, 181);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 174;
            this.label1.Text = "Tanggal Awal";
            // 
            // dtAwal
            // 
            this.dtAwal.BorderRadius = 5;
            this.dtAwal.Checked = true;
            this.dtAwal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.dtAwal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAwal.ForeColor = System.Drawing.Color.White;
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAwal.Location = new System.Drawing.Point(43, 58);
            this.dtAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.Size = new System.Drawing.Size(1312, 36);
            this.dtAwal.TabIndex = 173;
            this.dtAwal.Value = new System.DateTime(2023, 7, 20, 20, 41, 15, 826);
            // 
            // tblTrsPengirimanTableAdapter
            // 
            this.tblTrsPengirimanTableAdapter.ClearBeforeFill = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BorderRadius = 5;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilter.Location = new System.Drawing.Point(1390, 58);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.PressedColor = System.Drawing.Color.Azure;
            this.btnFilter.Size = new System.Drawing.Size(116, 42);
            this.btnFilter.TabIndex = 178;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrint.Location = new System.Drawing.Point(1390, 134);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PressedColor = System.Drawing.Color.Azure;
            this.btnPrint.Size = new System.Drawing.Size(116, 42);
            this.btnPrint.TabIndex = 179;
            this.btnPrint.Text = "Show";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // BestShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1619, 1018);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvShipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtAkhir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtAwal);
            this.Controls.Add(this.btnFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestShipment";
            this.Text = "BestShipment";
            this.Load += new System.EventHandler(this.BestShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrsPengirimanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorResiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblTrsPengirimanBindingSource;
        private dsEkspedisi dsEkspedisi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAkhir;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAwal;
        private dsEkspedisiTableAdapters.tblTrsPengirimanTableAdapter tblTrsPengirimanTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}