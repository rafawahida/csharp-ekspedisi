﻿namespace project_kel8
{
    partial class PanggilBestShipment
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getLaporanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getLaporanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ekspedisi_Kel08DataSet = new project_kel8.Ekspedisi_Kel08DataSet();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dsEkspedisi = new project_kel8.dsEkspedisi();
            this.getGudangtblKaryawanTableAdapter1 = new project_kel8.dsEkspedisiTableAdapters.getGudangtblKaryawanTableAdapter();
            this.getLaporanTableAdapter = new project_kel8.dsEkspedisiTableAdapters.getLaporanTableAdapter();
            this.reportViewer12 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getLaporanTableAdapter1 = new project_kel8.Ekspedisi_Kel08DataSetTableAdapters.getLaporanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekspedisi_Kel08DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).BeginInit();
            this.SuspendLayout();
            // 
            // getLaporanBindingSource
            // 
            this.getLaporanBindingSource.DataMember = "getLaporan";
            // 
            // getLaporanBindingSource1
            // 
            this.getLaporanBindingSource1.DataMember = "getLaporan";
            this.getLaporanBindingSource1.DataSource = this.ekspedisi_Kel08DataSet;
            // 
            // ekspedisi_Kel08DataSet
            // 
            this.ekspedisi_Kel08DataSet.DataSetName = "Ekspedisi_Kel08DataSet";
            this.ekspedisi_Kel08DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCari
            // 
            this.btnCari.BorderRadius = 5;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCari.Location = new System.Drawing.Point(714, 87);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedColor = System.Drawing.Color.Azure;
            this.btnCari.Size = new System.Drawing.Size(116, 36);
            this.btnCari.TabIndex = 176;
            this.btnCari.Text = "Show!";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 175;
            this.label2.Text = "Tanggal Akhir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 174;
            this.label1.Text = "Tanggal Awal";
            // 
            // dtAkhir
            // 
            this.dtAkhir.BorderRadius = 5;
            this.dtAkhir.Checked = true;
            this.dtAkhir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.dtAkhir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAkhir.ForeColor = System.Drawing.Color.White;
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAkhir.Location = new System.Drawing.Point(392, 87);
            this.dtAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.Size = new System.Drawing.Size(287, 36);
            this.dtAkhir.TabIndex = 173;
            this.dtAkhir.Value = new System.DateTime(2023, 7, 20, 20, 41, 18, 181);
            // 
            // dtAwal
            // 
            this.dtAwal.BorderRadius = 5;
            this.dtAwal.Checked = true;
            this.dtAwal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(27)))));
            this.dtAwal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAwal.ForeColor = System.Drawing.Color.White;
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAwal.Location = new System.Drawing.Point(71, 87);
            this.dtAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.Size = new System.Drawing.Size(287, 36);
            this.dtAwal.TabIndex = 172;
            this.dtAwal.Value = new System.DateTime(2023, 7, 20, 20, 41, 15, 826);
            // 
            // dsEkspedisi
            // 
            this.dsEkspedisi.DataSetName = "dsEkspedisi";
            this.dsEkspedisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getGudangtblKaryawanTableAdapter1
            // 
            this.getGudangtblKaryawanTableAdapter1.ClearBeforeFill = true;
            // 
            // getLaporanTableAdapter
            // 
            this.getLaporanTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer12
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.getLaporanBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.getLaporanBindingSource1;
            this.reportViewer12.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer12.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer12.LocalReport.ReportEmbeddedResource = "project_kel8.ReportBestShipment.rdlc";
            this.reportViewer12.Location = new System.Drawing.Point(22, 166);
            this.reportViewer12.Name = "reportViewer12";
            this.reportViewer12.ServerReport.BearerToken = null;
            this.reportViewer12.Size = new System.Drawing.Size(1518, 732);
            this.reportViewer12.TabIndex = 178;
            // 
            // getLaporanTableAdapter1
            // 
            this.getLaporanTableAdapter1.ClearBeforeFill = true;
            // 
            // PanggilBestShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(167)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1601, 971);
            this.Controls.Add(this.reportViewer12);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtAkhir);
            this.Controls.Add(this.dtAwal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanggilBestShipment";
            this.Text = "PanggilBestShipment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PanggilBestShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLaporanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekspedisi_Kel08DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEkspedisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAkhir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAwal;
        private System.Windows.Forms.BindingSource getLaporanBindingSource;
        private dsEkspedisi dsEkspedisi;
        private dsEkspedisiTableAdapters.getGudangtblKaryawanTableAdapter getGudangtblKaryawanTableAdapter1;
        private dsEkspedisiTableAdapters.getLaporanTableAdapter getLaporanTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer12;
        private System.Windows.Forms.BindingSource getLaporanBindingSource1;
        private Ekspedisi_Kel08DataSet ekspedisi_Kel08DataSet;
        private Ekspedisi_Kel08DataSetTableAdapters.getLaporanTableAdapter getLaporanTableAdapter1;
    }
}