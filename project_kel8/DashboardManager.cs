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


        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblPemasukan.Visible = false;
            lblBestKurir.Visible = false;
            lblLogout.Visible = true;

            //kembali ke halaman login
            Login login = new Login();
            login.Show();  
        }

        private void DashboardManager_Load(object sender, EventArgs e)
        {
            label_nama.Text = Session.NamaPengguna;
            label_jabatan_mng.Text = Session.Jabatan;

        }

        private void btnBestShipment_Click(object sender, EventArgs e)
        {
            BestShipment bShipment = new BestShipment();
            bShipment.TopLevel = false;
            pnlDashboardManager.Controls.Add(bShipment);
            bShipment.BringToFront();
            bShipment.Show();
        }

        private void btnReportIncome_Click(object sender, EventArgs e)
        {
            PanggilPemasukan pemasukan = new PanggilPemasukan();
            pemasukan.TopLevel = false;
            pnlDashboardManager.Controls.Add(pemasukan);
            pemasukan.BringToFront();
            pemasukan.Show();
        }
    }
}