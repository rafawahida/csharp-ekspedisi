namespace project_kel8
{
    partial class MasterKaryawan
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
            this.cbRoleKaryawan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tblRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.cbGudangKaryawan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tblGudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.tbPasswordKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsernameKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNamaKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNoTelpKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbIDKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCariKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKaryawan = new System.Windows.Forms.DataGridView();
            this.iDKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Gudang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getGudangtblKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKaryawanTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblKaryawanTableAdapter();
            this.tblGudangTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblGudangTableAdapter();
            this.tblRoleTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblRoleTableAdapter();
            this.tbCariKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.getGudangtblKaryawanTableAdapter = new project_kel8.dsEkspedisiTableAdapters.getGudangtblKaryawanTableAdapter();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGudangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGudangtblKaryawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKaryawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1601, 128);
            this.guna2Panel1.TabIndex = 153;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.cbRoleKaryawan);
            this.guna2Panel2.Controls.Add(this.cbGudangKaryawan);
            this.guna2Panel2.Controls.Add(this.btnCancelKaryawan);
            this.guna2Panel2.Controls.Add(this.btnUpdateKaryawan);
            this.guna2Panel2.Controls.Add(this.btnDeleteKaryawan);
            this.guna2Panel2.Controls.Add(this.btnSaveKaryawan);
            this.guna2Panel2.Controls.Add(this.tbPasswordKaryawan);
            this.guna2Panel2.Controls.Add(this.tbUsernameKaryawan);
            this.guna2Panel2.Controls.Add(this.tbNamaKaryawan);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.tbNoTelpKaryawan);
            this.guna2Panel2.Controls.Add(this.tbIDKaryawan);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.label12);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 128);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(824, 843);
            this.guna2Panel2.TabIndex = 162;
            // 
            // cbRoleKaryawan
            // 
            this.cbRoleKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.cbRoleKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.cbRoleKaryawan.BorderRadius = 5;
            this.cbRoleKaryawan.BorderThickness = 2;
            this.cbRoleKaryawan.DataSource = this.tblRoleBindingSource;
            this.cbRoleKaryawan.DisplayMember = "Jabatan";
            this.cbRoleKaryawan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoleKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoleKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.cbRoleKaryawan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoleKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoleKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbRoleKaryawan.ForeColor = System.Drawing.Color.White;
            this.cbRoleKaryawan.ItemHeight = 40;
            this.cbRoleKaryawan.Location = new System.Drawing.Point(445, 61);
            this.cbRoleKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.cbRoleKaryawan.Name = "cbRoleKaryawan";
            this.cbRoleKaryawan.Size = new System.Drawing.Size(334, 46);
            this.cbRoleKaryawan.TabIndex = 155;
            this.cbRoleKaryawan.ValueMember = "ID_Role";
            // 
            // tblRoleBindingSource
            // 
            this.tblRoleBindingSource.DataMember = "tblRole";
            this.tblRoleBindingSource.DataSource = this.dsEkspedisi;
            // 
            // dsEkspedisi
            // 
            this.dsEkspedisi.DataSetName = "dsEkspedisi";
            this.dsEkspedisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGudangKaryawan
            // 
            this.cbGudangKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.cbGudangKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.cbGudangKaryawan.BorderRadius = 5;
            this.cbGudangKaryawan.BorderThickness = 2;
            this.cbGudangKaryawan.DataSource = this.tblGudangBindingSource;
            this.cbGudangKaryawan.DisplayMember = "Nama_Gudang";
            this.cbGudangKaryawan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGudangKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGudangKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.cbGudangKaryawan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGudangKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGudangKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbGudangKaryawan.ForeColor = System.Drawing.Color.White;
            this.cbGudangKaryawan.ItemHeight = 40;
            this.cbGudangKaryawan.Location = new System.Drawing.Point(81, 151);
            this.cbGudangKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.cbGudangKaryawan.Name = "cbGudangKaryawan";
            this.cbGudangKaryawan.Size = new System.Drawing.Size(334, 46);
            this.cbGudangKaryawan.TabIndex = 166;
            this.cbGudangKaryawan.ValueMember = "ID_Gudang";
            // 
            // tblGudangBindingSource
            // 
            this.tblGudangBindingSource.DataMember = "tblGudang";
            this.tblGudangBindingSource.DataSource = this.dsEkspedisi;
            // 
            // btnCancelKaryawan
            // 
            this.btnCancelKaryawan.BorderRadius = 5;
            this.btnCancelKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCancelKaryawan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnCancelKaryawan.Image = global::project_kel8.Properties.Resources.clear;
            this.btnCancelKaryawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelKaryawan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancelKaryawan.Location = new System.Drawing.Point(533, 442);
            this.btnCancelKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelKaryawan.Name = "btnCancelKaryawan";
            this.btnCancelKaryawan.PressedColor = System.Drawing.Color.Azure;
            this.btnCancelKaryawan.Size = new System.Drawing.Size(139, 52);
            this.btnCancelKaryawan.TabIndex = 154;
            this.btnCancelKaryawan.Text = "     Cancel";
            this.btnCancelKaryawan.Click += new System.EventHandler(this.btnCancelKaryawan_Click);
            // 
            // btnUpdateKaryawan
            // 
            this.btnUpdateKaryawan.BorderRadius = 5;
            this.btnUpdateKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnUpdateKaryawan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKaryawan.Image = global::project_kel8.Properties.Resources.update;
            this.btnUpdateKaryawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateKaryawan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdateKaryawan.Location = new System.Drawing.Point(533, 319);
            this.btnUpdateKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateKaryawan.Name = "btnUpdateKaryawan";
            this.btnUpdateKaryawan.PressedColor = System.Drawing.Color.Azure;
            this.btnUpdateKaryawan.Size = new System.Drawing.Size(139, 53);
            this.btnUpdateKaryawan.TabIndex = 153;
            this.btnUpdateKaryawan.Text = "     Update";
            this.btnUpdateKaryawan.Click += new System.EventHandler(this.btnUpdateKaryawan_Click);
            // 
            // btnDeleteKaryawan
            // 
            this.btnDeleteKaryawan.BorderRadius = 5;
            this.btnDeleteKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnDeleteKaryawan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnDeleteKaryawan.Image = global::project_kel8.Properties.Resources.delete;
            this.btnDeleteKaryawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteKaryawan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteKaryawan.Location = new System.Drawing.Point(533, 381);
            this.btnDeleteKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteKaryawan.Name = "btnDeleteKaryawan";
            this.btnDeleteKaryawan.PressedColor = System.Drawing.Color.Azure;
            this.btnDeleteKaryawan.Size = new System.Drawing.Size(139, 52);
            this.btnDeleteKaryawan.TabIndex = 152;
            this.btnDeleteKaryawan.Text = "     Delete";
            this.btnDeleteKaryawan.Click += new System.EventHandler(this.btnDeleteKaryawan_Click);
            // 
            // btnSaveKaryawan
            // 
            this.btnSaveKaryawan.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveKaryawan.BorderRadius = 5;
            this.btnSaveKaryawan.BorderThickness = 2;
            this.btnSaveKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnSaveKaryawan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnSaveKaryawan.Image = global::project_kel8.Properties.Resources.diskette;
            this.btnSaveKaryawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveKaryawan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveKaryawan.Location = new System.Drawing.Point(533, 261);
            this.btnSaveKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveKaryawan.Name = "btnSaveKaryawan";
            this.btnSaveKaryawan.PressedColor = System.Drawing.Color.Azure;
            this.btnSaveKaryawan.Size = new System.Drawing.Size(139, 49);
            this.btnSaveKaryawan.TabIndex = 151;
            this.btnSaveKaryawan.Text = "     Save";
            this.btnSaveKaryawan.Click += new System.EventHandler(this.btnSaveKaryawan_Click);
            // 
            // tbPasswordKaryawan
            // 
            this.tbPasswordKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.tbPasswordKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbPasswordKaryawan.BorderRadius = 5;
            this.tbPasswordKaryawan.BorderThickness = 2;
            this.tbPasswordKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordKaryawan.DefaultText = "";
            this.tbPasswordKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPasswordKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPasswordKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbPasswordKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbPasswordKaryawan.ForeColor = System.Drawing.Color.White;
            this.tbPasswordKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordKaryawan.Location = new System.Drawing.Point(79, 434);
            this.tbPasswordKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPasswordKaryawan.Name = "tbPasswordKaryawan";
            this.tbPasswordKaryawan.PasswordChar = '\0';
            this.tbPasswordKaryawan.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbPasswordKaryawan.PlaceholderText = "enter password";
            this.tbPasswordKaryawan.SelectedText = "";
            this.tbPasswordKaryawan.Size = new System.Drawing.Size(334, 49);
            this.tbPasswordKaryawan.TabIndex = 141;
            // 
            // tbUsernameKaryawan
            // 
            this.tbUsernameKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.tbUsernameKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbUsernameKaryawan.BorderRadius = 5;
            this.tbUsernameKaryawan.BorderThickness = 2;
            this.tbUsernameKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsernameKaryawan.DefaultText = "";
            this.tbUsernameKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsernameKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsernameKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsernameKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsernameKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbUsernameKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsernameKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbUsernameKaryawan.ForeColor = System.Drawing.Color.White;
            this.tbUsernameKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsernameKaryawan.Location = new System.Drawing.Point(78, 336);
            this.tbUsernameKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsernameKaryawan.Name = "tbUsernameKaryawan";
            this.tbUsernameKaryawan.PasswordChar = '\0';
            this.tbUsernameKaryawan.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbUsernameKaryawan.PlaceholderText = "enter username";
            this.tbUsernameKaryawan.SelectedText = "";
            this.tbUsernameKaryawan.Size = new System.Drawing.Size(334, 49);
            this.tbUsernameKaryawan.TabIndex = 140;
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.tbNamaKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbNamaKaryawan.BorderRadius = 5;
            this.tbNamaKaryawan.BorderThickness = 2;
            this.tbNamaKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNamaKaryawan.DefaultText = "";
            this.tbNamaKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNamaKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNamaKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamaKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamaKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbNamaKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamaKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbNamaKaryawan.ForeColor = System.Drawing.Color.White;
            this.tbNamaKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamaKaryawan.Location = new System.Drawing.Point(79, 247);
            this.tbNamaKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.PasswordChar = '\0';
            this.tbNamaKaryawan.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbNamaKaryawan.PlaceholderText = "enter employee name";
            this.tbNamaKaryawan.SelectedText = "";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(334, 49);
            this.tbNamaKaryawan.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 138;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 137;
            this.label1.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 136;
            this.label7.Text = "Employee Name";
            // 
            // tbNoTelpKaryawan
            // 
            this.tbNoTelpKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.tbNoTelpKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbNoTelpKaryawan.BorderRadius = 5;
            this.tbNoTelpKaryawan.BorderThickness = 2;
            this.tbNoTelpKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNoTelpKaryawan.DefaultText = "";
            this.tbNoTelpKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNoTelpKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNoTelpKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoTelpKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoTelpKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbNoTelpKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoTelpKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbNoTelpKaryawan.ForeColor = System.Drawing.Color.White;
            this.tbNoTelpKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoTelpKaryawan.Location = new System.Drawing.Point(445, 148);
            this.tbNoTelpKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNoTelpKaryawan.Name = "tbNoTelpKaryawan";
            this.tbNoTelpKaryawan.PasswordChar = '\0';
            this.tbNoTelpKaryawan.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbNoTelpKaryawan.PlaceholderText = "enter phone number";
            this.tbNoTelpKaryawan.SelectedText = "";
            this.tbNoTelpKaryawan.Size = new System.Drawing.Size(334, 49);
            this.tbNoTelpKaryawan.TabIndex = 133;
            // 
            // tbIDKaryawan
            // 
            this.tbIDKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.tbIDKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbIDKaryawan.BorderRadius = 5;
            this.tbIDKaryawan.BorderThickness = 2;
            this.tbIDKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDKaryawan.DefaultText = "";
            this.tbIDKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbIDKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbIDKaryawan.ForeColor = System.Drawing.Color.White;
            this.tbIDKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDKaryawan.Location = new System.Drawing.Point(80, 61);
            this.tbIDKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIDKaryawan.Name = "tbIDKaryawan";
            this.tbIDKaryawan.PasswordChar = '\0';
            this.tbIDKaryawan.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbIDKaryawan.PlaceholderText = "employee ID";
            this.tbIDKaryawan.SelectedText = "";
            this.tbIDKaryawan.Size = new System.Drawing.Size(333, 49);
            this.tbIDKaryawan.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(440, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 131;
            this.label6.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(76, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 28);
            this.label12.TabIndex = 130;
            this.label12.Text = "Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(438, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 129;
            this.label2.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 128;
            this.label4.Text = "Employee ID";
            // 
            // btnCariKaryawan
            // 
            this.btnCariKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.btnCariKaryawan.BorderRadius = 5;
            this.btnCariKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCariKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCariKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCariKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCariKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCariKaryawan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCariKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnCariKaryawan.Image = global::project_kel8.Properties.Resources.loupe;
            this.btnCariKaryawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCariKaryawan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCariKaryawan.Location = new System.Drawing.Point(1412, 200);
            this.btnCariKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariKaryawan.Name = "btnCariKaryawan";
            this.btnCariKaryawan.PressedColor = System.Drawing.Color.Transparent;
            this.btnCariKaryawan.Size = new System.Drawing.Size(154, 46);
            this.btnCariKaryawan.TabIndex = 164;
            this.btnCariKaryawan.Text = "     Search";
            this.btnCariKaryawan.Click += new System.EventHandler(this.btnCariKaryawan_Click);
            // 
            // dgvKaryawan
            // 
            this.dgvKaryawan.AutoGenerateColumns = false;
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKaryawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKaryawanDataGridViewTextBoxColumn,
            this.Jabatan,
            this.Nama_Gudang,
            this.Nama,
            this.Username,
            this.Password,
            this.No_telp});
            this.dgvKaryawan.DataSource = this.getGudangtblKaryawanBindingSource;
            this.dgvKaryawan.Location = new System.Drawing.Point(873, 268);
            this.dgvKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKaryawan.Name = "dgvKaryawan";
            this.dgvKaryawan.RowHeadersWidth = 51;
            this.dgvKaryawan.Size = new System.Drawing.Size(693, 357);
            this.dgvKaryawan.TabIndex = 163;
            this.dgvKaryawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaryawan_CellClick);
            this.dgvKaryawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaryawan_CellContentClick);
            // 
            // iDKaryawanDataGridViewTextBoxColumn
            // 
            this.iDKaryawanDataGridViewTextBoxColumn.DataPropertyName = "ID_Karyawan";
            this.iDKaryawanDataGridViewTextBoxColumn.HeaderText = "ID_Karyawan";
            this.iDKaryawanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDKaryawanDataGridViewTextBoxColumn.Name = "iDKaryawanDataGridViewTextBoxColumn";
            this.iDKaryawanDataGridViewTextBoxColumn.Width = 125;
            // 
            // Jabatan
            // 
            this.Jabatan.DataPropertyName = "Jabatan";
            this.Jabatan.HeaderText = "Jabatan";
            this.Jabatan.MinimumWidth = 6;
            this.Jabatan.Name = "Jabatan";
            this.Jabatan.Width = 125;
            // 
            // Nama_Gudang
            // 
            this.Nama_Gudang.DataPropertyName = "Nama_Gudang";
            this.Nama_Gudang.HeaderText = "Nama_Gudang";
            this.Nama_Gudang.MinimumWidth = 6;
            this.Nama_Gudang.Name = "Nama_Gudang";
            this.Nama_Gudang.Width = 125;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // No_telp
            // 
            this.No_telp.DataPropertyName = "No_telp";
            this.No_telp.HeaderText = "No_telp";
            this.No_telp.MinimumWidth = 6;
            this.No_telp.Name = "No_telp";
            this.No_telp.Width = 125;
            // 
            // getGudangtblKaryawanBindingSource
            // 
            this.getGudangtblKaryawanBindingSource.DataMember = "getGudangtblKaryawan";
            this.getGudangtblKaryawanBindingSource.DataSource = this.dsEkspedisi;
            // 
            // tblKaryawanBindingSource
            // 
            this.tblKaryawanBindingSource.DataMember = "tblKaryawan";
            this.tblKaryawanBindingSource.DataSource = this.dsEkspedisi;
            // 
            // tblKaryawanTableAdapter
            // 
            this.tblKaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // tblGudangTableAdapter
            // 
            this.tblGudangTableAdapter.ClearBeforeFill = true;
            // 
            // tblRoleTableAdapter
            // 
            this.tblRoleTableAdapter.ClearBeforeFill = true;
            // 
            // tbCariKaryawan
            // 
            this.tbCariKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.tbCariKaryawan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbCariKaryawan.BorderRadius = 5;
            this.tbCariKaryawan.BorderThickness = 2;
            this.tbCariKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCariKaryawan.DefaultText = "";
            this.tbCariKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCariKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCariKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCariKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCariKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbCariKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCariKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCariKaryawan.ForeColor = System.Drawing.Color.White;
            this.tbCariKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCariKaryawan.IconLeft = global::project_kel8.Properties.Resources.loupe;
            this.tbCariKaryawan.Location = new System.Drawing.Point(1063, 200);
            this.tbCariKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariKaryawan.Name = "tbCariKaryawan";
            this.tbCariKaryawan.PasswordChar = '\0';
            this.tbCariKaryawan.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbCariKaryawan.PlaceholderText = "   seacrh by name";
            this.tbCariKaryawan.SelectedText = "";
            this.tbCariKaryawan.Size = new System.Drawing.Size(341, 45);
            this.tbCariKaryawan.TabIndex = 165;
            // 
            // cbfilter
            // 
            this.cbfilter.BackColor = System.Drawing.Color.Transparent;
            this.cbfilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbfilter.ItemHeight = 30;
            this.cbfilter.Items.AddRange(new object[] {
            "Position",
            "Warehouse",
            "Name"});
            this.cbfilter.Location = new System.Drawing.Point(873, 202);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(183, 36);
            this.cbfilter.TabIndex = 166;
            // 
            // getGudangtblKaryawanTableAdapter
            // 
            this.getGudangtblKaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // MasterKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1601, 971);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.tbCariKaryawan);
            this.Controls.Add(this.btnCariKaryawan);
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterKaryawan";
            this.Text = "MasterKaryawan1";
            this.Load += new System.EventHandler(this.MasterKaryawan_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGudangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGudangtblKaryawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKaryawanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox tbNoTelpKaryawan;
        private Guna.UI2.WinForms.Guna2TextBox tbIDKaryawan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnCariKaryawan;
        private System.Windows.Forms.DataGridView dgvKaryawan;
        private Guna.UI2.WinForms.Guna2TextBox tbPasswordKaryawan;
        private Guna.UI2.WinForms.Guna2TextBox tbUsernameKaryawan;
        private Guna.UI2.WinForms.Guna2TextBox tbNamaKaryawan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnCancelKaryawan;
        private Guna.UI2.WinForms.Guna2Button btnUpdateKaryawan;
        private Guna.UI2.WinForms.Guna2Button btnDeleteKaryawan;
        private Guna.UI2.WinForms.Guna2Button btnSaveKaryawan;
        private Guna.UI2.WinForms.Guna2ComboBox cbGudangKaryawan;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoleKaryawan;
        private dsEkspedisi dsEkspedisi;
        private System.Windows.Forms.BindingSource tblKaryawanBindingSource;
        private dsEkspedisiTableAdapters.tblKaryawanTableAdapter tblKaryawanTableAdapter;
        private System.Windows.Forms.BindingSource tblGudangBindingSource;
        private dsEkspedisiTableAdapters.tblGudangTableAdapter tblGudangTableAdapter;
        private System.Windows.Forms.BindingSource tblRoleBindingSource;
        private dsEkspedisiTableAdapters.tblRoleTableAdapter tblRoleTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox tbCariKaryawan;
        private Guna.UI2.WinForms.Guna2ComboBox cbfilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Gudang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_telp;
        private System.Windows.Forms.BindingSource getGudangtblKaryawanBindingSource;
        private dsEkspedisiTableAdapters.getGudangtblKaryawanTableAdapter getGudangtblKaryawanTableAdapter;
    }
}