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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
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
        private void btnDataRole_Click(object sender, EventArgs e)
        {
            lblRole.Visible = true;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = false;
            lblGudang.Visible = false;
            lblLogout.Visible = false;

            MasterRole Role = new MasterRole();
            Role.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(Role);
            Role.BringToFront();
            Role.Show();
        }

        private void btnDataKaryawan_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = true;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = false;
            lblGudang.Visible = false;
            lblLogout.Visible = false;

            MasterKaryawan Karyawan = new MasterKaryawan();
            Karyawan.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(Karyawan);
            Karyawan.BringToFront();
            Karyawan.Show();
        }

        private void btnDataGudang_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = false;
            lblGudang.Visible = true;
            lblLogout.Visible = false;

            MasterGudang Gudang = new MasterGudang();
            Gudang.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(Gudang);
            Gudang.BringToFront();
            Gudang.Show();
        }

        private void btnDataKabupaten_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = true;
            lblKecamatan.Visible = false;
            lblGudang.Visible = false;
            lblLogout.Visible = false;

            MasterKabupaten Kabupaten = new MasterKabupaten();
            Kabupaten.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(Kabupaten);
            Kabupaten.BringToFront();
            Kabupaten.Show();
        }

        private void btnDataKecamatan_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = true;
            lblGudang.Visible = false;
            lblLogout.Visible = false;

            MasterKecamatan Kecamatan = new MasterKecamatan();
            Kecamatan.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(Kecamatan);
            Kecamatan.BringToFront();
            Kecamatan.Show();
        }

        private void btnJenisPengiriman_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = true;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = false;
            lblGudang.Visible = false;
            lblPromo.Visible = false;
            lblLogout.Visible = false;


            MasterJenisPengiriman JenisPengiriman = new MasterJenisPengiriman();
            JenisPengiriman.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(JenisPengiriman);
            JenisPengiriman.BringToFront();
            JenisPengiriman.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = false;
            lblGudang.Visible = false;
            lblLogout.Visible = true;

            //kembali ke halaman login
            Login login = new Login();
            login.Show();
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            label_nama.Text = Session.NamaPengguna;
            label_jabatan.Text = Session.Jabatan;
        }

        private void btnDataPromo_Click(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            lblKaryawan.Visible = false;
            lblJPengiriman.Visible = false;
            lblKabupaten.Visible = false;
            lblKecamatan.Visible = false;
            lblGudang.Visible = false;
            lblPromo.Visible = true;
            lblLogout.Visible = false;

            TransaksiPromo TransPromo = new TransaksiPromo();
            TransPromo.TopLevel = false;
            pnlDashboardAdmin.Controls.Add(TransPromo);
            TransPromo.BringToFront();
            TransPromo.Show();
        }
    }
}
