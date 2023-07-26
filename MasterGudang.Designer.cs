namespace project_kel8
{
    partial class MasterGudang
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancelGudang = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateGudang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteGudang = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveGudang = new Guna.UI2.WinForms.Guna2Button();
            this.cbIDKecamatanGudang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tblKecamatanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.tbLatitudeGudang = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLongitudeGudang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaGudang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDGudang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCariGudang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCariGudang = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGudang = new System.Windows.Forms.DataGridView();
            this.iDGudangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Kecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Gudang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getNamaKecamatan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi1 = new project_kel8.dsEkspedisi();
            this.getNamaKecamatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKecamatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKecamatanTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblKecamatanTableAdapter();
            this.tblGudangTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblGudangTableAdapter();
            this.getNamaKecamatanTableAdapter = new project_kel8.dsEkspedisiTableAdapters.getNamaKecamatanTableAdapter();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKecamatanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGudang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNamaKecamatan1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNamaKecamatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGudangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKecamatanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1583, 128);
            this.guna2Panel1.TabIndex = 154;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnCancelGudang);
            this.guna2Panel2.Controls.Add(this.btnUpdateGudang);
            this.guna2Panel2.Controls.Add(this.btnDeleteGudang);
            this.guna2Panel2.Controls.Add(this.btnSaveGudang);
            this.guna2Panel2.Controls.Add(this.cbIDKecamatanGudang);
            this.guna2Panel2.Controls.Add(this.tbLatitudeGudang);
            this.guna2Panel2.Controls.Add(this.tbLongitudeGudang);
            this.guna2Panel2.Controls.Add(this.label12);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.tbNamaGudang);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.tbIDGudang);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 128);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(808, 796);
            this.guna2Panel2.TabIndex = 164;
            // 
            // btnCancelGudang
            // 
            this.btnCancelGudang.BorderRadius = 5;
            this.btnCancelGudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelGudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCancelGudang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGudang.ForeColor = System.Drawing.Color.White;
            this.btnCancelGudang.Image = global::project_kel8.Properties.Resources.clear;
            this.btnCancelGudang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelGudang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancelGudang.Location = new System.Drawing.Point(625, 232);
            this.btnCancelGudang.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelGudang.Name = "btnCancelGudang";
            this.btnCancelGudang.PressedColor = System.Drawing.Color.Azure;
            this.btnCancelGudang.Size = new System.Drawing.Size(139, 52);
            this.btnCancelGudang.TabIndex = 160;
            this.btnCancelGudang.Text = "     Cancel";
            this.btnCancelGudang.Click += new System.EventHandler(this.btnCancelGudang_Click);
            // 
            // btnUpdateGudang
            // 
            this.btnUpdateGudang.BorderRadius = 5;
            this.btnUpdateGudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateGudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnUpdateGudang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGudang.ForeColor = System.Drawing.Color.White;
            this.btnUpdateGudang.Image = global::project_kel8.Properties.Resources.update;
            this.btnUpdateGudang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateGudang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdateGudang.Location = new System.Drawing.Point(625, 111);
            this.btnUpdateGudang.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGudang.Name = "btnUpdateGudang";
            this.btnUpdateGudang.PressedColor = System.Drawing.Color.Azure;
            this.btnUpdateGudang.Size = new System.Drawing.Size(139, 53);
            this.btnUpdateGudang.TabIndex = 159;
            this.btnUpdateGudang.Text = "     Update";
            this.btnUpdateGudang.Click += new System.EventHandler(this.btnUpdateGudang_Click);
            // 
            // btnDeleteGudang
            // 
            this.btnDeleteGudang.BorderRadius = 5;
            this.btnDeleteGudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteGudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnDeleteGudang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGudang.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGudang.Image = global::project_kel8.Properties.Resources.delete;
            this.btnDeleteGudang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteGudang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteGudang.Location = new System.Drawing.Point(625, 172);
            this.btnDeleteGudang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGudang.Name = "btnDeleteGudang";
            this.btnDeleteGudang.PressedColor = System.Drawing.Color.Azure;
            this.btnDeleteGudang.Size = new System.Drawing.Size(139, 52);
            this.btnDeleteGudang.TabIndex = 158;
            this.btnDeleteGudang.Text = "     Delete";
            this.btnDeleteGudang.Click += new System.EventHandler(this.btnDeleteGudang_Click);
            // 
            // btnSaveGudang
            // 
            this.btnSaveGudang.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveGudang.BorderRadius = 5;
            this.btnSaveGudang.BorderThickness = 2;
            this.btnSaveGudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveGudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnSaveGudang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveGudang.ForeColor = System.Drawing.Color.White;
            this.btnSaveGudang.Image = global::project_kel8.Properties.Resources.diskette;
            this.btnSaveGudang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveGudang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveGudang.Location = new System.Drawing.Point(625, 54);
            this.btnSaveGudang.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveGudang.Name = "btnSaveGudang";
            this.btnSaveGudang.PressedColor = System.Drawing.Color.Azure;
            this.btnSaveGudang.Size = new System.Drawing.Size(139, 49);
            this.btnSaveGudang.TabIndex = 157;
            this.btnSaveGudang.Text = "     Save";
            this.btnSaveGudang.Click += new System.EventHandler(this.btnSaveGudang_Click);
            // 
            // cbIDKecamatanGudang
            // 
            this.cbIDKecamatanGudang.BackColor = System.Drawing.Color.Transparent;
            this.cbIDKecamatanGudang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.cbIDKecamatanGudang.BorderRadius = 5;
            this.cbIDKecamatanGudang.BorderThickness = 2;
            this.cbIDKecamatanGudang.DataSource = this.tblKecamatanBindingSource1;
            this.cbIDKecamatanGudang.DisplayMember = "Nama_Kecamatan";
            this.cbIDKecamatanGudang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIDKecamatanGudang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDKecamatanGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.cbIDKecamatanGudang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIDKecamatanGudang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIDKecamatanGudang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbIDKecamatanGudang.ForeColor = System.Drawing.Color.White;
            this.cbIDKecamatanGudang.ItemHeight = 40;
            this.cbIDKecamatanGudang.Location = new System.Drawing.Point(93, 148);
            this.cbIDKecamatanGudang.Margin = new System.Windows.Forms.Padding(4);
            this.cbIDKecamatanGudang.Name = "cbIDKecamatanGudang";
            this.cbIDKecamatanGudang.Size = new System.Drawing.Size(479, 46);
            this.cbIDKecamatanGudang.TabIndex = 156;
            this.cbIDKecamatanGudang.ValueMember = "ID_Kecamatan";
            // 
            // tblKecamatanBindingSource1
            // 
            this.tblKecamatanBindingSource1.DataMember = "tblKecamatan";
            this.tblKecamatanBindingSource1.DataSource = this.dsEkspedisi;
            // 
            // dsEkspedisi
            // 
            this.dsEkspedisi.DataSetName = "dsEkspedisi";
            this.dsEkspedisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbLatitudeGudang
            // 
            this.tbLatitudeGudang.BackColor = System.Drawing.Color.Transparent;
            this.tbLatitudeGudang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbLatitudeGudang.BorderRadius = 5;
            this.tbLatitudeGudang.BorderThickness = 2;
            this.tbLatitudeGudang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLatitudeGudang.DefaultText = "";
            this.tbLatitudeGudang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLatitudeGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLatitudeGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLatitudeGudang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLatitudeGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbLatitudeGudang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLatitudeGudang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbLatitudeGudang.ForeColor = System.Drawing.Color.White;
            this.tbLatitudeGudang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLatitudeGudang.Location = new System.Drawing.Point(92, 440);
            this.tbLatitudeGudang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLatitudeGudang.Name = "tbLatitudeGudang";
            this.tbLatitudeGudang.PasswordChar = '\0';
            this.tbLatitudeGudang.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbLatitudeGudang.PlaceholderText = "enter latitude";
            this.tbLatitudeGudang.SelectedText = "";
            this.tbLatitudeGudang.Size = new System.Drawing.Size(480, 49);
            this.tbLatitudeGudang.TabIndex = 130;
            // 
            // tbLongitudeGudang
            // 
            this.tbLongitudeGudang.BackColor = System.Drawing.Color.Transparent;
            this.tbLongitudeGudang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbLongitudeGudang.BorderRadius = 5;
            this.tbLongitudeGudang.BorderThickness = 2;
            this.tbLongitudeGudang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLongitudeGudang.DefaultText = "";
            this.tbLongitudeGudang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLongitudeGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLongitudeGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLongitudeGudang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLongitudeGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbLongitudeGudang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLongitudeGudang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbLongitudeGudang.ForeColor = System.Drawing.Color.White;
            this.tbLongitudeGudang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLongitudeGudang.Location = new System.Drawing.Point(94, 339);
            this.tbLongitudeGudang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLongitudeGudang.Name = "tbLongitudeGudang";
            this.tbLongitudeGudang.PasswordChar = '\0';
            this.tbLongitudeGudang.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbLongitudeGudang.PlaceholderText = "enter longitude";
            this.tbLongitudeGudang.SelectedText = "";
            this.tbLongitudeGudang.Size = new System.Drawing.Size(480, 49);
            this.tbLongitudeGudang.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(87, 407);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 28);
            this.label12.TabIndex = 128;
            this.label12.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 127;
            this.label2.Text = "Longitude";
            // 
            // tbNamaGudang
            // 
            this.tbNamaGudang.BackColor = System.Drawing.Color.Transparent;
            this.tbNamaGudang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbNamaGudang.BorderRadius = 5;
            this.tbNamaGudang.BorderThickness = 2;
            this.tbNamaGudang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNamaGudang.DefaultText = "";
            this.tbNamaGudang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNamaGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNamaGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamaGudang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamaGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbNamaGudang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamaGudang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbNamaGudang.ForeColor = System.Drawing.Color.White;
            this.tbNamaGudang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamaGudang.Location = new System.Drawing.Point(94, 242);
            this.tbNamaGudang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamaGudang.Name = "tbNamaGudang";
            this.tbNamaGudang.PasswordChar = '\0';
            this.tbNamaGudang.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbNamaGudang.PlaceholderText = "enter district name";
            this.tbNamaGudang.SelectedText = "";
            this.tbNamaGudang.Size = new System.Drawing.Size(480, 49);
            this.tbNamaGudang.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 125;
            this.label1.Text = "Warehouse Name";
            // 
            // tbIDGudang
            // 
            this.tbIDGudang.BackColor = System.Drawing.Color.Transparent;
            this.tbIDGudang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbIDGudang.BorderRadius = 5;
            this.tbIDGudang.BorderThickness = 2;
            this.tbIDGudang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDGudang.DefaultText = "";
            this.tbIDGudang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDGudang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbIDGudang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDGudang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbIDGudang.ForeColor = System.Drawing.Color.White;
            this.tbIDGudang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDGudang.Location = new System.Drawing.Point(92, 55);
            this.tbIDGudang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIDGudang.Name = "tbIDGudang";
            this.tbIDGudang.PasswordChar = '\0';
            this.tbIDGudang.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbIDGudang.PlaceholderText = "enter warehouse ID";
            this.tbIDGudang.SelectedText = "";
            this.tbIDGudang.Size = new System.Drawing.Size(480, 49);
            this.tbIDGudang.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 122;
            this.label4.Text = "Warehouse ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(87, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 120;
            this.label7.Text = "District ID";
            // 
            // tbCariGudang
            // 
            this.tbCariGudang.BackColor = System.Drawing.Color.Transparent;
            this.tbCariGudang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbCariGudang.BorderRadius = 5;
            this.tbCariGudang.BorderThickness = 2;
            this.tbCariGudang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCariGudang.DefaultText = "";
            this.tbCariGudang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCariGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCariGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCariGudang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCariGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbCariGudang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCariGudang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCariGudang.ForeColor = System.Drawing.Color.White;
            this.tbCariGudang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCariGudang.IconLeft = global::project_kel8.Properties.Resources.loupe;
            this.tbCariGudang.Location = new System.Drawing.Point(859, 183);
            this.tbCariGudang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariGudang.Name = "tbCariGudang";
            this.tbCariGudang.PasswordChar = '\0';
            this.tbCariGudang.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbCariGudang.PlaceholderText = "    search by name";
            this.tbCariGudang.SelectedText = "";
            this.tbCariGudang.Size = new System.Drawing.Size(512, 49);
            this.tbCariGudang.TabIndex = 169;
            // 
            // btnCariGudang
            // 
            this.btnCariGudang.BackColor = System.Drawing.Color.Transparent;
            this.btnCariGudang.BorderRadius = 5;
            this.btnCariGudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCariGudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCariGudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCariGudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCariGudang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCariGudang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCariGudang.ForeColor = System.Drawing.Color.White;
            this.btnCariGudang.Image = global::project_kel8.Properties.Resources.loupe;
            this.btnCariGudang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCariGudang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCariGudang.Location = new System.Drawing.Point(1399, 180);
            this.btnCariGudang.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariGudang.Name = "btnCariGudang";
            this.btnCariGudang.PressedColor = System.Drawing.Color.Transparent;
            this.btnCariGudang.Size = new System.Drawing.Size(142, 52);
            this.btnCariGudang.TabIndex = 168;
            this.btnCariGudang.Text = "     Search";
            this.btnCariGudang.Click += new System.EventHandler(this.btnCariGudang_Click);
            // 
            // dgvGudang
            // 
            this.dgvGudang.AllowUserToAddRows = false;
            this.dgvGudang.AllowUserToDeleteRows = false;
            this.dgvGudang.AutoGenerateColumns = false;
            this.dgvGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGudang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGudangDataGridViewTextBoxColumn,
            this.Nama_Kecamatan,
            this.Nama_Gudang,
            this.Longitude,
            this.Latitude});
            this.dgvGudang.DataSource = this.getNamaKecamatanBindingSource;
            this.dgvGudang.Location = new System.Drawing.Point(859, 251);
            this.dgvGudang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGudang.Name = "dgvGudang";
            this.dgvGudang.ReadOnly = true;
            this.dgvGudang.RowHeadersWidth = 51;
            this.dgvGudang.Size = new System.Drawing.Size(671, 396);
            this.dgvGudang.TabIndex = 167;
            this.dgvGudang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGudang_CellClick);
            // 
            // iDGudangDataGridViewTextBoxColumn
            // 
            this.iDGudangDataGridViewTextBoxColumn.DataPropertyName = "ID_Gudang";
            this.iDGudangDataGridViewTextBoxColumn.HeaderText = "ID_Gudang";
            this.iDGudangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDGudangDataGridViewTextBoxColumn.Name = "iDGudangDataGridViewTextBoxColumn";
            this.iDGudangDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDGudangDataGridViewTextBoxColumn.Width = 125;
            // 
            // Nama_Kecamatan
            // 
            this.Nama_Kecamatan.DataPropertyName = "Nama_Kecamatan";
            this.Nama_Kecamatan.HeaderText = "Nama_Kecamatan";
            this.Nama_Kecamatan.MinimumWidth = 6;
            this.Nama_Kecamatan.Name = "Nama_Kecamatan";
            this.Nama_Kecamatan.ReadOnly = true;
            this.Nama_Kecamatan.Width = 125;
            // 
            // Nama_Gudang
            // 
            this.Nama_Gudang.DataPropertyName = "Nama_Gudang";
            this.Nama_Gudang.HeaderText = "Nama_Gudang";
            this.Nama_Gudang.MinimumWidth = 6;
            this.Nama_Gudang.Name = "Nama_Gudang";
            this.Nama_Gudang.ReadOnly = true;
            this.Nama_Gudang.Width = 125;
            // 
            // Longitude
            // 
            this.Longitude.DataPropertyName = "Longitude";
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.MinimumWidth = 6;
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Width = 125;
            // 
            // Latitude
            // 
            this.Latitude.DataPropertyName = "Latitude";
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.MinimumWidth = 6;
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Width = 125;
            // 
            // getNamaKecamatan1BindingSource
            // 
            this.getNamaKecamatan1BindingSource.DataMember = "getNamaKecamatan1";
            this.getNamaKecamatan1BindingSource.DataSource = this.dsEkspedisi1;
            // 
            // dsEkspedisi1
            // 
            this.dsEkspedisi1.DataSetName = "dsEkspedisi";
            this.dsEkspedisi1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getNamaKecamatanBindingSource
            // 
            this.getNamaKecamatanBindingSource.DataMember = "getNamaKecamatan";
            this.getNamaKecamatanBindingSource.DataSource = this.dsEkspedisi;
            // 
            // tblGudangBindingSource
            // 
            this.tblGudangBindingSource.DataMember = "tblGudang";
            this.tblGudangBindingSource.DataSource = this.dsEkspedisi;
            // 
            // tblKecamatanBindingSource
            // 
            this.tblKecamatanBindingSource.DataMember = "tblKecamatan";
            this.tblKecamatanBindingSource.DataSource = this.dsEkspedisi;
            // 
            // tblKecamatanTableAdapter
            // 
            this.tblKecamatanTableAdapter.ClearBeforeFill = true;
            // 
            // tblGudangTableAdapter
            // 
            this.tblGudangTableAdapter.ClearBeforeFill = true;
            // 
            // getNamaKecamatanTableAdapter
            // 
            this.getNamaKecamatanTableAdapter.ClearBeforeFill = true;
            // 
            // MasterGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1583, 924);
            this.Controls.Add(this.tbCariGudang);
            this.Controls.Add(this.btnCariGudang);
            this.Controls.Add(this.dgvGudang);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterGudang";
            this.Text = "MasterGudang1";
            this.Load += new System.EventHandler(this.MasterGudang_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKecamatanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGudang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNamaKecamatan1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNamaKecamatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGudangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKecamatanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbIDKecamatanGudang;
        private Guna.UI2.WinForms.Guna2TextBox tbLatitudeGudang;
        private Guna.UI2.WinForms.Guna2TextBox tbLongitudeGudang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbNamaGudang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbIDGudang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbCariGudang;
        private Guna.UI2.WinForms.Guna2Button btnCariGudang;
        private System.Windows.Forms.DataGridView dgvGudang;
        private Guna.UI2.WinForms.Guna2Button btnCancelGudang;
        private Guna.UI2.WinForms.Guna2Button btnUpdateGudang;
        private Guna.UI2.WinForms.Guna2Button btnDeleteGudang;
        private Guna.UI2.WinForms.Guna2Button btnSaveGudang;
        private dsEkspedisi dsEkspedisi;
        private System.Windows.Forms.BindingSource tblKecamatanBindingSource;
        private dsEkspedisiTableAdapters.tblKecamatanTableAdapter tblKecamatanTableAdapter;
        private System.Windows.Forms.BindingSource tblGudangBindingSource;
        private dsEkspedisiTableAdapters.tblGudangTableAdapter tblGudangTableAdapter;
        private System.Windows.Forms.BindingSource tblKecamatanBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGudangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Kecamatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Gudang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.BindingSource getNamaKecamatanBindingSource;
        private dsEkspedisiTableAdapters.getNamaKecamatanTableAdapter getNamaKecamatanTableAdapter;
        private System.Windows.Forms.BindingSource getNamaKecamatan1BindingSource;
        private dsEkspedisi dsEkspedisi1;
    }
}