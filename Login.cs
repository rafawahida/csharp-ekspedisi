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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string functionCall = "SELECT * FROM dbo.VerifikasiLogin(@username, @password)";
                using (SqlCommand command = new SqlCommand(functionCall, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        string jabatan = reader["Jabatan"].ToString();
                        string gudang = reader["Nama_Gudang"].ToString();

                        MessageBox.Show("Welcome to UDA SAMPE", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (jabatan == "Manager")
                        {
                            this.Hide();
                            using (DashboardManager manager = new DashboardManager())
                            {
                                manager.ShowDialog();
                            }
                        }
                        else if (jabatan == "Admin")
                        {
                            this.Hide();
                            using (DashboardAdmin admin = new DashboardAdmin())
                            {
                                admin.ShowDialog();
                            }
                        }
                        else if (jabatan == "Kasir")
                        {
                            this.Hide();
                            using (DashboardKasir kasir = new DashboardKasir())
                            {
                                kasir.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}


             
        