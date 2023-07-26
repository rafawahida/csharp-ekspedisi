namespace project_kel8
{
    partial class TransaksiPromo
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
            this.tbPromoName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPromoID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLabel = new System.Windows.Forms.Label();
            this.dtAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiskon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.btnSavePromo = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearPromo = new Guna.UI2.WinForms.Guna2Button();
            this.tblPromoTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblPromoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPromoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPromoName
            // 
            this.tbPromoName.BackColor = System.Drawing.Color.Transparent;
            this.tbPromoName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbPromoName.BorderRadius = 5;
            this.tbPromoName.BorderThickness = 2;
            this.tbPromoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPromoName.DefaultText = "";
            this.tbPromoName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPromoName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPromoName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPromoName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPromoName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbPromoName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPromoName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbPromoName.ForeColor = System.Drawing.Color.White;
            this.tbPromoName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPromoName.Location = new System.Drawing.Point(166, 233);
            this.tbPromoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPromoName.Name = "tbPromoName";
            this.tbPromoName.PasswordChar = '\0';
            this.tbPromoName.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbPromoName.PlaceholderText = "enter promo name";
            this.tbPromoName.SelectedText = "";
            this.tbPromoName.Size = new System.Drawing.Size(480, 49);
            this.tbPromoName.TabIndex = 134;
            this.tbPromoName.TextChanged += new System.EventHandler(this.tbNamaPromo_TextChanged);
            // 
            // tbPromoID
            // 
            this.tbPromoID.BackColor = System.Drawing.Color.Transparent;
            this.tbPromoID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbPromoID.BorderRadius = 5;
            this.tbPromoID.BorderThickness = 2;
            this.tbPromoID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPromoID.DefaultText = "";
            this.tbPromoID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPromoID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPromoID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPromoID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPromoID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbPromoID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPromoID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbPromoID.ForeColor = System.Drawing.Color.White;
            this.tbPromoID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPromoID.Location = new System.Drawing.Point(168, 142);
            this.tbPromoID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPromoID.Name = "tbPromoID";
            this.tbPromoID.PasswordChar = '\0';
            this.tbPromoID.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbPromoID.PlaceholderText = "enter promo ID";
            this.tbPromoID.SelectedText = "";
            this.tbPromoID.Size = new System.Drawing.Size(480, 49);
            this.tbPromoID.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(161, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 28);
            this.label12.TabIndex = 132;
            this.label12.Text = "Promo Name";
            // 
            // tbLabel
            // 
            this.tbLabel.AutoSize = true;
            this.tbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLabel.ForeColor = System.Drawing.Color.White;
            this.tbLabel.Location = new System.Drawing.Point(162, 109);
            this.tbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(101, 28);
            this.tbLabel.TabIndex = 131;
            this.tbLabel.Text = "Promo ID";
            // 
            // dtAwal
            // 
            this.dtAwal.BorderRadius = 5;
            this.dtAwal.Checked = true;
            this.dtAwal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.dtAwal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAwal.ForeColor = System.Drawing.Color.White;
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAwal.Location = new System.Drawing.Point(168, 322);
            this.dtAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.Size = new System.Drawing.Size(480, 49);
            this.dtAwal.TabIndex = 135;
            this.dtAwal.Value = new System.DateTime(2023, 7, 15, 11, 39, 26, 156);
            // 
            // dtAkhir
            // 
            this.dtAkhir.BorderRadius = 5;
            this.dtAkhir.Checked = true;
            this.dtAkhir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.dtAkhir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAkhir.ForeColor = System.Drawing.Color.White;
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAkhir.Location = new System.Drawing.Point(168, 410);
            this.dtAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.Size = new System.Drawing.Size(480, 49);
            this.dtAkhir.TabIndex = 136;
            this.dtAkhir.Value = new System.DateTime(2023, 7, 15, 11, 39, 26, 156);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 137;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 138;
            this.label2.Text = "End Date";
            // 
            // tbDiskon
            // 
            this.tbDiskon.BackColor = System.Drawing.Color.Transparent;
            this.tbDiskon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbDiskon.BorderRadius = 5;
            this.tbDiskon.BorderThickness = 2;
            this.tbDiskon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiskon.DefaultText = "";
            this.tbDiskon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiskon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiskon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiskon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiskon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbDiskon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiskon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbDiskon.ForeColor = System.Drawing.Color.White;
            this.tbDiskon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiskon.Location = new System.Drawing.Point(168, 499);
            this.tbDiskon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiskon.Name = "tbDiskon";
            this.tbDiskon.PasswordChar = '\0';
            this.tbDiskon.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbDiskon.PlaceholderText = "enter promo ID";
            this.tbDiskon.SelectedText = "";
            this.tbDiskon.Size = new System.Drawing.Size(480, 49);
            this.tbDiskon.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(162, 466);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 139;
            this.label3.Text = "Discount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPromoDataGridViewTextBoxColumn,
            this.namaPromoDataGridViewTextBoxColumn,
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn,
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn,
            this.potonganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPromoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(790, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 396);
            this.dataGridView1.TabIndex = 141;
            // 
            // iDPromoDataGridViewTextBoxColumn
            // 
            this.iDPromoDataGridViewTextBoxColumn.DataPropertyName = "ID_Promo";
            this.iDPromoDataGridViewTextBoxColumn.HeaderText = "ID_Promo";
            this.iDPromoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPromoDataGridViewTextBoxColumn.Name = "iDPromoDataGridViewTextBoxColumn";
            this.iDPromoDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPromoDataGridViewTextBoxColumn
            // 
            this.namaPromoDataGridViewTextBoxColumn.DataPropertyName = "Nama_Promo";
            this.namaPromoDataGridViewTextBoxColumn.HeaderText = "Nama_Promo";
            this.namaPromoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPromoDataGridViewTextBoxColumn.Name = "namaPromoDataGridViewTextBoxColumn";
            this.namaPromoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalBerlakuAwalDataGridViewTextBoxColumn
            // 
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_BerlakuAwal";
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn.HeaderText = "Tanggal_BerlakuAwal";
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn.Name = "tanggalBerlakuAwalDataGridViewTextBoxColumn";
            this.tanggalBerlakuAwalDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalBerlakuAkhirDataGridViewTextBoxColumn
            // 
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_BerlakuAkhir";
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn.HeaderText = "Tanggal_BerlakuAkhir";
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn.Name = "tanggalBerlakuAkhirDataGridViewTextBoxColumn";
            this.tanggalBerlakuAkhirDataGridViewTextBoxColumn.Width = 125;
            // 
            // potonganDataGridViewTextBoxColumn
            // 
            this.potonganDataGridViewTextBoxColumn.DataPropertyName = "Potongan";
            this.potonganDataGridViewTextBoxColumn.HeaderText = "Potongan";
            this.potonganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.potonganDataGridViewTextBoxColumn.Name = "potonganDataGridViewTextBoxColumn";
            this.potonganDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPromoBindingSource
            // 
            this.tblPromoBindingSource.DataMember = "tblPromo";
            this.tblPromoBindingSource.DataSource = this.dsEkspedisi;
            // 
            // dsEkspedisi
            // 
            this.dsEkspedisi.DataSetName = "dsEkspedisi";
            this.dsEkspedisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSavePromo
            // 
            this.btnSavePromo.BorderColor = System.Drawing.Color.Transparent;
            this.btnSavePromo.BorderRadius = 5;
            this.btnSavePromo.BorderThickness = 2;
            this.btnSavePromo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSavePromo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSavePromo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSavePromo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSavePromo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnSavePromo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSavePromo.ForeColor = System.Drawing.Color.White;
            this.btnSavePromo.Image = global::project_kel8.Properties.Resources.diskette;
            this.btnSavePromo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSavePromo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSavePromo.Location = new System.Drawing.Point(790, 142);
            this.btnSavePromo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePromo.Name = "btnSavePromo";
            this.btnSavePromo.PressedColor = System.Drawing.Color.Azure;
            this.btnSavePromo.Size = new System.Drawing.Size(139, 49);
            this.btnSavePromo.TabIndex = 158;
            this.btnSavePromo.Text = "     Save";
            this.btnSavePromo.Click += new System.EventHandler(this.btnSavePromo_Click);
            // 
            // btnClearPromo
            // 
            this.btnClearPromo.BorderRadius = 5;
            this.btnClearPromo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearPromo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearPromo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearPromo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearPromo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnClearPromo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPromo.ForeColor = System.Drawing.Color.White;
            this.btnClearPromo.Image = global::project_kel8.Properties.Resources.clear;
            this.btnClearPromo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearPromo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClearPromo.Location = new System.Drawing.Point(966, 139);
            this.btnClearPromo.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPromo.Name = "btnClearPromo";
            this.btnClearPromo.PressedColor = System.Drawing.Color.Azure;
            this.btnClearPromo.Size = new System.Drawing.Size(139, 52);
            this.btnClearPromo.TabIndex = 161;
            this.btnClearPromo.Text = "     Clear";
            this.btnClearPromo.Click += new System.EventHandler(this.btnClearPromo_Click);
            // 
            // tblPromoTableAdapter
            // 
            this.tblPromoTableAdapter.ClearBeforeFill = true;
            // 
            // TransaksiPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1601, 1029);
            this.Controls.Add(this.btnClearPromo);
            this.Controls.Add(this.btnSavePromo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbDiskon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtAkhir);
            this.Controls.Add(this.dtAwal);
            this.Controls.Add(this.tbPromoName);
            this.Controls.Add(this.tbPromoID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransaksiPromo";
            this.Text = "TransaksiPromo";
            this.Load += new System.EventHandler(this.TransaksiPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPromoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbPromoName;
        private Guna.UI2.WinForms.Guna2TextBox tbPromoID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tbLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAwal;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAkhir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbDiskon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnSavePromo;
        private Guna.UI2.WinForms.Guna2Button btnClearPromo;
        private dsEkspedisi dsEkspedisi;
        private System.Windows.Forms.BindingSource tblPromoBindingSource;
        private dsEkspedisiTableAdapters.tblPromoTableAdapter tblPromoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalBerlakuAwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalBerlakuAkhirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potonganDataGridViewTextBoxColumn;
    }
}