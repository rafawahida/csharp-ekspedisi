namespace project_kel8
{
    partial class PanggilResi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnResiTRSP = new Guna.UI2.WinForms.Guna2Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtResi = new System.Windows.Forms.TextBox();
            this.getLaporanResiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.getLaporanResiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getLaporanResiTableAdapter = new project_kel8.dsEkspedisiTableAdapters.getLaporanResiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanResiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanResiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResiTRSP
            // 
            this.btnResiTRSP.BorderRadius = 5;
            this.btnResiTRSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResiTRSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResiTRSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResiTRSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResiTRSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnResiTRSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResiTRSP.ForeColor = System.Drawing.Color.White;
            this.btnResiTRSP.Image = global::project_kel8.Properties.Resources.printer;
            this.btnResiTRSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnResiTRSP.Location = new System.Drawing.Point(1295, 52);
            this.btnResiTRSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnResiTRSP.Name = "btnResiTRSP";
            this.btnResiTRSP.PressedColor = System.Drawing.Color.Azure;
            this.btnResiTRSP.Size = new System.Drawing.Size(156, 53);
            this.btnResiTRSP.TabIndex = 168;
            this.btnResiTRSP.Text = "  Print Resi";
            this.btnResiTRSP.Click += new System.EventHandler(this.btnResiTRSP_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getLaporanResiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project_kel8.ReportResiPengiriman.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 192);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1420, 463);
            this.reportViewer1.TabIndex = 169;
            // 
            // txtResi
            // 
            this.txtResi.Location = new System.Drawing.Point(780, 82);
            this.txtResi.Name = "txtResi";
            this.txtResi.Size = new System.Drawing.Size(100, 22);
            this.txtResi.TabIndex = 170;
            // 
            // getLaporanResiBindingSource1
            // 
            this.getLaporanResiBindingSource1.DataMember = "getLaporanResi";
            this.getLaporanResiBindingSource1.DataSource = this.dsEkspedisi;
            // 
            // dsEkspedisi
            // 
            this.dsEkspedisi.DataSetName = "dsEkspedisi";
            this.dsEkspedisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getLaporanResiBindingSource
            // 
            this.getLaporanResiBindingSource.DataMember = "getLaporanResi";
            this.getLaporanResiBindingSource.DataSource = this.dsEkspedisi;
            // 
            // getLaporanResiTableAdapter
            // 
            this.getLaporanResiTableAdapter.ClearBeforeFill = true;
            // 
            // PanggilResi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 683);
            this.Controls.Add(this.txtResi);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnResiTRSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanggilResi";
            this.Text = "PanggilResi";
            this.Load += new System.EventHandler(this.PanggilResi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanResiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanResiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnResiTRSP;
        private System.Windows.Forms.BindingSource getLaporanResiBindingSource;
        private dsEkspedisi dsEkspedisi;
        private dsEkspedisiTableAdapters.getLaporanResiTableAdapter getLaporanResiTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtResi;
        private System.Windows.Forms.BindingSource getLaporanResiBindingSource1;
    }
}