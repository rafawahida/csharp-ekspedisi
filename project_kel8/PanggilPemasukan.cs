using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class PanggilPemasukan : Form
    {
        public PanggilPemasukan()
        {
            InitializeComponent();
        }

        private void PanggilPemasukan_Load(object sender, EventArgs e)
        {
            
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtAwal.Value;
            DateTime endDate = dtAkhir.Value;
            String startDateString = startDate.ToString("yyyy-MM-dd");
            String endDateString = endDate.ToString("yyyy-MM-dd");

            //Input tanggal awal ke dalam report wizard
            string reportName = "Income.rdlc";
            // Ganti 'reportViewer1' dengan nama objek ReportViewer Anda
            reportViewer1.LocalReport.ReportPath = reportName;

            // Ganti 'parameterNama' dengan nama parameter yang telah Anda buat di laporan
            ReportParameter parameter = new ReportParameter("tanggalAwal", startDate.ToString("yyyy-MM-dd"));
            ReportParameter parameter1 = new ReportParameter("tanggalAkhir", endDate.ToString("yyyy-MM-dd"));
            reportViewer1.LocalReport.SetParameters(parameter);
            reportViewer1.LocalReport.SetParameters(parameter1);

            this.getLaporanTableAdapter1.Fill(this.ekspedisi_Kel08DataSet.getLaporan, startDateString, endDateString);

            this.reportViewer1.RefreshReport();
        }

        /* private void btnResiTRSP_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtAwal.Value;
            DateTime endDate = dtAkhir.Value;
            String startDateString = startDate.ToString("yyyy-MM-dd");
            String endDateString = endDate.ToString("yyyy-MM-dd");

            //Input tanggal awal ke dalam report wizard
            string reportName = "Income.rdlc";
            // Ganti 'reportViewer1' dengan nama objek ReportViewer Anda
            reportViewer1.LocalReport.ReportPath = reportName;

            // Ganti 'parameterNama' dengan nama parameter yang telah Anda buat di laporan
            ReportParameter parameter = new ReportParameter("tanggalAwal", startDate.ToString("yyyy-MM-dd"));
            ReportParameter parameter1 = new ReportParameter("tanggalAkhir", endDate.ToString("yyyy-MM-dd"));
            reportViewer1.LocalReport.SetParameters(parameter);
            reportViewer1.LocalReport.SetParameters(parameter1);

            this.getLaporanTableAdapter1.Fill(this.ekspedisi_Kel08DataSet.getLaporan, startDateString, endDateString);

            this.reportViewer1.RefreshReport();

        } */
    }
}
