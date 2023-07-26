using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class MasterKabupaten : Form
    {
        public MasterKabupaten()
        {
            InitializeComponent();
        }

        private void btnSaveKabupaten_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertKabKot";
                cmd.CommandType = CommandType.StoredProcedure;

                // Validasi data tidak boleh kosong 'nama Kabupaten'
                if (tbNamaKabupaten.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLongitudeKabupaten.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLatitudeKabupaten.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idKabupaten = tbIDKabupaten.Text;
                string namaKabupaten = tbNamaKabupaten.Text;
                string longitude = tbLongitudeKabupaten.Text;
                string latitude = tbLatitudeKabupaten.Text;

                cmd.Parameters.AddWithValue("@id_kabkot", idKabupaten);
                cmd.Parameters.AddWithValue("@nama_kabkot", namaKabupaten);
                cmd.Parameters.AddWithValue("@longitude", longitude);
                cmd.Parameters.AddWithValue("@latitude", latitude);

                connection.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Data saved successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to save data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnDeleteKabupaten_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_DeleteKabKot";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_kabkot", tbIDKabupaten.Text);

                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to delete data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            Clear();
        }

        private void MasterKabupaten_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblKabupatenKota' table. You can move, or remove it, as needed.
            this.tblKabupatenKotaTableAdapter.Fill(this.dsEkspedisi.tblKabupatenKota);
            string newId = GenerateId();
            tbIDKabupaten.Text = newId;
        }

        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.generateIdKabKot() AS newId";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    newId = reader["newId"].ToString();
                }

                reader.Close();
                connection.Close();
            }
            catch (SqlException e)
            {
                // Handle any errors that occur during the execution
                MessageBox.Show(e.ToString());
            }

            return newId;
        }

        public void clear()
        {
            string newId = GenerateId();
            tbIDKabupaten.Text = newId;
            tbNamaKabupaten.Text = "";
            tbLongitudeKabupaten.Text = "";
            tbLatitudeKabupaten.Text = "";
        }

        private void Clear()
        {
            tbNamaKabupaten.Text = "";
            tbLatitudeKabupaten.Text = "";
            tbLongitudeKabupaten.Text = "";
        }

        private void btnCancelKabupaten_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void RefreshDataSet()
        {
            this.tblKabupatenKotaTableAdapter.Fill(this.dsEkspedisi.tblKabupatenKota);
        }


        private void cariData(string data)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            string query = $"SELECT * FROM dbo.getListKabupatenKota('{data}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvKabupaten.DataSource = table;
            }
        }

        private void btnCariKabupaten_Click(object sender, EventArgs e)
        {
            if (tbCariKabupaten.TextLength != 0)
            {
                string data = tbCariKabupaten.Text.ToString();
                cariData(data);
            }
            else
            {
                cariData("");
            }
        }

        private void dgvKabupaten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah valid
            {
                DataGridViewRow row = dgvKabupaten.Rows[e.RowIndex];

                // Mengisi nilai dari setiap kolom ke dalam TextBox sesuai dengan indeks kolomnya
                tbIDKabupaten.Text = row.Cells[0].Value.ToString();
                tbNamaKabupaten.Text = row.Cells[1].Value.ToString();
                tbLongitudeKabupaten.Text = row.Cells[2].Value.ToString();
                tbLatitudeKabupaten.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdateKabupaten_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateKabKot";
                cmd.CommandType = CommandType.StoredProcedure;

                // Validasi data tidak boleh kosong
                if (tbNamaKabupaten.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLongitudeKabupaten.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLatitudeKabupaten.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idKabupaten = tbIDKabupaten.Text;
                string namaKabupaten = tbNamaKabupaten.Text;
                string longitude = tbLongitudeKabupaten.Text;
                string latitude = tbLatitudeKabupaten.Text;

                cmd.Parameters.AddWithValue("@id_kabkot", idKabupaten);
                cmd.Parameters.AddWithValue("@nama_kabkot", namaKabupaten);
                cmd.Parameters.AddWithValue("@longitude", float.Parse(longitude));
                cmd.Parameters.AddWithValue("@latitude", float.Parse(latitude));

                connection.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Data update successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to update data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
