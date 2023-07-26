namespace project_kel8
{
    partial class MasterRole
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
            this.btnCancelRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveRole = new Guna.UI2.WinForms.Guna2Button();
            this.tbJabatanRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbIDJabatanRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCariRole = new Guna.UI2.WinForms.Guna2Button();
            this.tbCariRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.iDRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.tblRoleTableAdapter = new project_kel8.dsEkspedisiTableAdapters.tblRoleTableAdapter();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1565, 128);
            this.guna2Panel1.TabIndex = 154;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnCancelRole);
            this.guna2Panel2.Controls.Add(this.btnUpdateRole);
            this.guna2Panel2.Controls.Add(this.btnDeleteRole);
            this.guna2Panel2.Controls.Add(this.btnSaveRole);
            this.guna2Panel2.Controls.Add(this.tbJabatanRole);
            this.guna2Panel2.Controls.Add(this.tbIDJabatanRole);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 128);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(772, 749);
            this.guna2Panel2.TabIndex = 158;
            // 
            // btnCancelRole
            // 
            this.btnCancelRole.BorderRadius = 5;
            this.btnCancelRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCancelRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRole.ForeColor = System.Drawing.Color.White;
            this.btnCancelRole.Image = global::project_kel8.Properties.Resources.clear;
            this.btnCancelRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelRole.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancelRole.Location = new System.Drawing.Point(496, 231);
            this.btnCancelRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelRole.Name = "btnCancelRole";
            this.btnCancelRole.PressedColor = System.Drawing.Color.Azure;
            this.btnCancelRole.Size = new System.Drawing.Size(139, 52);
            this.btnCancelRole.TabIndex = 158;
            this.btnCancelRole.Text = "     Cancel";
            this.btnCancelRole.Click += new System.EventHandler(this.btnCancelRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BorderRadius = 5;
            this.btnUpdateRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnUpdateRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRole.Image = global::project_kel8.Properties.Resources.update;
            this.btnUpdateRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateRole.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdateRole.Location = new System.Drawing.Point(496, 112);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.PressedColor = System.Drawing.Color.Azure;
            this.btnUpdateRole.Size = new System.Drawing.Size(139, 53);
            this.btnUpdateRole.TabIndex = 157;
            this.btnUpdateRole.Text = "     Update";
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BorderRadius = 5;
            this.btnDeleteRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnDeleteRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Image = global::project_kel8.Properties.Resources.delete;
            this.btnDeleteRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteRole.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteRole.Location = new System.Drawing.Point(496, 172);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.PressedColor = System.Drawing.Color.Azure;
            this.btnDeleteRole.Size = new System.Drawing.Size(139, 52);
            this.btnDeleteRole.TabIndex = 156;
            this.btnDeleteRole.Text = "     Delete";
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnSaveRole
            // 
            this.btnSaveRole.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveRole.BorderRadius = 5;
            this.btnSaveRole.BorderThickness = 2;
            this.btnSaveRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnSaveRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveRole.ForeColor = System.Drawing.Color.White;
            this.btnSaveRole.Image = global::project_kel8.Properties.Resources.diskette;
            this.btnSaveRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveRole.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveRole.Location = new System.Drawing.Point(496, 54);
            this.btnSaveRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveRole.Name = "btnSaveRole";
            this.btnSaveRole.PressedColor = System.Drawing.Color.Azure;
            this.btnSaveRole.Size = new System.Drawing.Size(139, 49);
            this.btnSaveRole.TabIndex = 155;
            this.btnSaveRole.Text = "     Save";
            this.btnSaveRole.Click += new System.EventHandler(this.btnSaveRole_Click);
            // 
            // tbJabatanRole
            // 
            this.tbJabatanRole.BackColor = System.Drawing.Color.Transparent;
            this.tbJabatanRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbJabatanRole.BorderRadius = 5;
            this.tbJabatanRole.BorderThickness = 2;
            this.tbJabatanRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJabatanRole.DefaultText = "";
            this.tbJabatanRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbJabatanRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbJabatanRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbJabatanRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbJabatanRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbJabatanRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbJabatanRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbJabatanRole.ForeColor = System.Drawing.Color.White;
            this.tbJabatanRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbJabatanRole.Location = new System.Drawing.Point(125, 154);
            this.tbJabatanRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbJabatanRole.Name = "tbJabatanRole";
            this.tbJabatanRole.PasswordChar = '\0';
            this.tbJabatanRole.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbJabatanRole.PlaceholderText = "input the role name";
            this.tbJabatanRole.SelectedText = "";
            this.tbJabatanRole.Size = new System.Drawing.Size(322, 49);
            this.tbJabatanRole.TabIndex = 154;
            this.tbJabatanRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJabatanRole_KeyPress);
            // 
            // tbIDJabatanRole
            // 
            this.tbIDJabatanRole.BackColor = System.Drawing.Color.Transparent;
            this.tbIDJabatanRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbIDJabatanRole.BorderRadius = 5;
            this.tbIDJabatanRole.BorderThickness = 2;
            this.tbIDJabatanRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDJabatanRole.DefaultText = "";
            this.tbIDJabatanRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDJabatanRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDJabatanRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDJabatanRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDJabatanRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbIDJabatanRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDJabatanRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbIDJabatanRole.ForeColor = System.Drawing.Color.White;
            this.tbIDJabatanRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDJabatanRole.Location = new System.Drawing.Point(125, 60);
            this.tbIDJabatanRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIDJabatanRole.Name = "tbIDJabatanRole";
            this.tbIDJabatanRole.PasswordChar = '\0';
            this.tbIDJabatanRole.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbIDJabatanRole.PlaceholderText = "enter role ID";
            this.tbIDJabatanRole.SelectedText = "";
            this.tbIDJabatanRole.Size = new System.Drawing.Size(322, 49);
            this.tbIDJabatanRole.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 152;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 151;
            this.label4.Text = "ID Role";
            // 
            // btnCariRole
            // 
            this.btnCariRole.BackColor = System.Drawing.Color.Transparent;
            this.btnCariRole.BorderRadius = 5;
            this.btnCariRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCariRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCariRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCariRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCariRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCariRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCariRole.ForeColor = System.Drawing.Color.White;
            this.btnCariRole.Image = global::project_kel8.Properties.Resources.loupe;
            this.btnCariRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCariRole.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCariRole.Location = new System.Drawing.Point(1372, 185);
            this.btnCariRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariRole.Name = "btnCariRole";
            this.btnCariRole.PressedColor = System.Drawing.Color.Transparent;
            this.btnCariRole.Size = new System.Drawing.Size(142, 52);
            this.btnCariRole.TabIndex = 164;
            this.btnCariRole.Text = "     Search";
            this.btnCariRole.Click += new System.EventHandler(this.btnCariRole_Click);
            // 
            // tbCariRole
            // 
            this.tbCariRole.BackColor = System.Drawing.Color.Transparent;
            this.tbCariRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbCariRole.BorderRadius = 5;
            this.tbCariRole.BorderThickness = 2;
            this.tbCariRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCariRole.DefaultText = "";
            this.tbCariRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCariRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCariRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCariRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCariRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbCariRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCariRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbCariRole.ForeColor = System.Drawing.Color.White;
            this.tbCariRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCariRole.IconLeft = global::project_kel8.Properties.Resources.loupe;
            this.tbCariRole.Location = new System.Drawing.Point(811, 188);
            this.tbCariRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariRole.Name = "tbCariRole";
            this.tbCariRole.PasswordChar = '\0';
            this.tbCariRole.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbCariRole.PlaceholderText = "   search by name";
            this.tbCariRole.SelectedText = "";
            this.tbCariRole.Size = new System.Drawing.Size(548, 49);
            this.tbCariRole.TabIndex = 163;
            // 
            // dgvRole
            // 
            this.dgvRole.AutoGenerateColumns = false;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRoleDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn});
            this.dgvRole.DataSource = this.tblRoleBindingSource;
            this.dgvRole.Location = new System.Drawing.Point(811, 249);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(703, 150);
            this.dgvRole.TabIndex = 165;
            this.dgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // 
            // iDRoleDataGridViewTextBoxColumn
            // 
            this.iDRoleDataGridViewTextBoxColumn.DataPropertyName = "ID_Role";
            this.iDRoleDataGridViewTextBoxColumn.HeaderText = "ID_Role";
            this.iDRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRoleDataGridViewTextBoxColumn.Name = "iDRoleDataGridViewTextBoxColumn";
            this.iDRoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            this.jabatanDataGridViewTextBoxColumn.Width = 125;
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
            // tblRoleTableAdapter
            // 
            this.tblRoleTableAdapter.ClearBeforeFill = true;
            // 
            // MasterRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1565, 877);
            this.Controls.Add(this.dgvRole);
            this.Controls.Add(this.btnCariRole);
            this.Controls.Add(this.tbCariRole);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterRole";
            this.Text = "MasterRole";
            this.Load += new System.EventHandler(this.MasterRole1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnCancelRole;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRole;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRole;
        private Guna.UI2.WinForms.Guna2Button btnSaveRole;
        private Guna.UI2.WinForms.Guna2TextBox tbJabatanRole;
        private Guna.UI2.WinForms.Guna2TextBox tbIDJabatanRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnCariRole;
        private Guna.UI2.WinForms.Guna2TextBox tbCariRole;
        private System.Windows.Forms.DataGridView dgvRole;
        private dsEkspedisi dsEkspedisi;
        private System.Windows.Forms.BindingSource tblRoleBindingSource;
        private dsEkspedisiTableAdapters.tblRoleTableAdapter tblRoleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
    }
}