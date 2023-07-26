namespace project_kel8
{
    partial class BestKurir
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbTahunBestKurir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBulanBestKurir = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1601, 128);
            this.guna2Panel1.TabIndex = 154;
            // 
            // tbTahunBestKurir
            // 
            this.tbTahunBestKurir.BackColor = System.Drawing.Color.Transparent;
            this.tbTahunBestKurir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.tbTahunBestKurir.BorderRadius = 5;
            this.tbTahunBestKurir.BorderThickness = 2;
            this.tbTahunBestKurir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTahunBestKurir.DefaultText = "";
            this.tbTahunBestKurir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTahunBestKurir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTahunBestKurir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTahunBestKurir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTahunBestKurir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.tbTahunBestKurir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTahunBestKurir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbTahunBestKurir.ForeColor = System.Drawing.Color.White;
            this.tbTahunBestKurir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTahunBestKurir.Location = new System.Drawing.Point(164, 261);
            this.tbTahunBestKurir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTahunBestKurir.Name = "tbTahunBestKurir";
            this.tbTahunBestKurir.PasswordChar = '\0';
            this.tbTahunBestKurir.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.tbTahunBestKurir.PlaceholderText = "Masukan tahun yang ingin dicari";
            this.tbTahunBestKurir.SelectedText = "";
            this.tbTahunBestKurir.Size = new System.Drawing.Size(480, 49);
            this.tbTahunBestKurir.TabIndex = 163;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(159, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 28);
            this.label7.TabIndex = 162;
            this.label7.Text = "Masukan Tahun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 164;
            this.label1.Text = "Masukan Bulan";
            // 
            // cbBulanBestKurir
            // 
            this.cbBulanBestKurir.BackColor = System.Drawing.Color.Transparent;
            this.cbBulanBestKurir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.cbBulanBestKurir.BorderRadius = 5;
            this.cbBulanBestKurir.BorderThickness = 2;
            this.cbBulanBestKurir.DisplayMember = "Nama_KabKot";
            this.cbBulanBestKurir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBulanBestKurir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBulanBestKurir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.cbBulanBestKurir.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBulanBestKurir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBulanBestKurir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbBulanBestKurir.ForeColor = System.Drawing.Color.White;
            this.cbBulanBestKurir.ItemHeight = 40;
            this.cbBulanBestKurir.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cbBulanBestKurir.Location = new System.Drawing.Point(165, 357);
            this.cbBulanBestKurir.Margin = new System.Windows.Forms.Padding(4);
            this.cbBulanBestKurir.Name = "cbBulanBestKurir";
            this.cbBulanBestKurir.Size = new System.Drawing.Size(479, 46);
            this.cbBulanBestKurir.TabIndex = 165;
            this.cbBulanBestKurir.ValueMember = "ID_KabKot";
            // 
            // BestKurir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1601, 971);
            this.Controls.Add(this.cbBulanBestKurir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTahunBestKurir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestKurir";
            this.Text = "BestKurir";
            this.Load += new System.EventHandler(this.BestKurir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbTahunBestKurir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbBulanBestKurir;
    }
}