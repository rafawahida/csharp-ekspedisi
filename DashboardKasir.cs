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
    public partial class DashboardKasir : Form
    {
        public DashboardKasir()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Perbesar form
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                // Kembalikan ke ukuran normal
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            // Perkecil form
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDataPengiriman_Click(object sender, EventArgs e)
        {
            lblPengiriman.Visible = true;
            lblPelacakan.Visible = false;
            lblLogout.Visible = false;

            TransaksiPengiriman TransPengiriman = new TransaksiPengiriman();
            TransPengiriman.TopLevel = false;
            pnlDashboardKasir.Controls.Add(TransPengiriman);
            TransPengiriman.BringToFront();
            TransPengiriman.Show();
        }

        private void btnDataPelacakan_Click(object sender, EventArgs e)
        {
            lblPengiriman.Visible = false;
            lblPelacakan.Visible = true;
            lblLogout.Visible = false;

            TransaksiPelacakan TransPelacakan = new TransaksiPelacakan();
            TransPelacakan.TopLevel = false;
            pnlDashboardKasir.Controls.Add(TransPelacakan);
            TransPelacakan.BringToFront();
            TransPelacakan.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblPengiriman.Visible = false;
            lblPelacakan.Visible = false;
            lblLogout.Visible = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
