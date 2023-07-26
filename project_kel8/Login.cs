using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;

namespace project_kel8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
        SqlConnection connection = new SqlConnection("integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08");

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter the Username or Password");
                return;
            }

            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.VerifikasiLogin2(@username, @password)", connection);
            command.Parameters.AddWithValue("@Username", txtUsername.Text);
            command.Parameters.AddWithValue("@Password", txtPassword.Text);

            string query2 = "SELECT Nama, Nama_Gudang, Jabatan FROM tblKaryawan WHERE username = @username";
            using (SqlCommand command2 = new SqlCommand(query2, connection))
            {
                using (SqlDataReader reader2 = command.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        string nama = reader2["Nama"].ToString();
                        Session.NamaPengguna = nama;
                        string namagudang = reader2["Nama_Gudang"].ToString();
                        Session.NamaGudang = namagudang;
                        string jabatan = reader2["Jabatan"].ToString();
                        Session.Jabatan = jabatan;
                    }
                }
            }
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string idkaryawan = reader["Id_karyawan"].ToString();
                    string role = reader["Id_role"].ToString();
                    MessageBox.Show("Welcome to UDASAMPE!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (role == "ROL001")
                    {
                        this.Hide();
                        using (DashboardAdmin admin = new DashboardAdmin())
                        {
                            admin.ShowDialog();
                            this.Close();
                        }
                    }
                    else if (role == "ROL002")
                    {
                        this.Hide();
                        using (DashboardManager manager = new DashboardManager())
                        {
                            manager.ShowDialog();
                            this.Close();
                        }
                    }
                    else if (role == "ROL003")
                    {
                        this.Hide();
                        using (DashboardKasir kasir = new DashboardKasir())
                        {
                            kasir.ShowDialog();
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nama Pengguna atau Kata Sandi salah!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbShow.Checked == true)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }
    }
}




             
        