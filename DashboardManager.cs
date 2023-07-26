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
    public partial class DashboardManager : Form
    {
        public DashboardManager()
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

        private void btnLapPemasukan_Click(object sender, EventArgs e)
        {
            lblPemasukan.Visible = true;
            lblBestKurir.Visible = false;
            lblLogout.Visible = false;
        }

        private void btnBestKurir_Click(object sender, EventArgs e)
        {
            lblPemasukan.Visible = false;
            lblBestKurir.Visible = true;
            lblLogout.Visible = false;

            BestKurir kurir = new BestKurir();
            kurir.TopLevel = false;
            pnlDashboardManager.Controls.Add(kurir);
            kurir.BringToFront();
            kurir.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblPemasukan.Visible = false;
            lblBestKurir.Visible = false;
            lblLogout.Visible = true;
        }
    }
}