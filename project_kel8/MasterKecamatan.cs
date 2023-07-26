using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class MasterKecamatan : Form
    {
        public MasterKecamatan()
        {
            InitializeComponent();
        }
        private void MasterKecamatan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblKecamatan' table. You can move, or remove it, as needed.
            this.tblKabupatenKotaTableAdapter.Fill(this.dsEkspedisi.tblKabupatenKota);
            // TODO: This line of code loads data into the 'dsEkspedisi.tblKecamatan' table. You can move, or remove it, as needed.
            this.tblKecamatanTableAdapter.Fill(this.dsEkspedisi.tblKecamatan);
            string newId = GenerateId();
            tbIDKecamatan.Text = newId;
            RefreshDataSet();
            cbIDKabupatenKecamatan.SelectedIndex = -1;

        }

        private void btnSaveKecamatan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertKecamatan";
                cmd.CommandType = CommandType.StoredProcedure;

                string idKecamatan = tbIDKecamatan.Text;
                string idKabkot = cbIDKabupatenKecamatan.SelectedValue.ToString();
                string namaKecamatan = tbNamaKecamatan.Text;
                string longitude = tbLongitudeKecamatan.Text;
                string latitude = tbLatitudeKecamatan.Text;

                // Validasi data tidak boleh kosong 'nama kecamatan'
                if (tbNamaKecamatan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLongitudeKecamatan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLatitudeKecamatan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pengecekan keberadaan data kecamatan
                string checkExistQuery = "SELECT COUNT(*) FROM tblKecamatan WHERE nama_kecamatan = @nama_kecamatan";
                SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, connection);
                checkExistCmd.Parameters.AddWithValue("@nama_kecamatan", namaKecamatan);

                connection.Open();
                int existingCount = Convert.ToInt32(checkExistCmd.ExecuteScalar());
                connection.Close();

                if (existingCount > 0)
                {
                    MessageBox.Show("Data already exists. Please enter different data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd.Parameters.AddWithValue("@id_kecamatan", idKecamatan);
                cmd.Parameters.AddWithValue("@id_kabkot", idKabkot);
                cmd.Parameters.AddWithValue("@nama_kecamatan", namaKecamatan);
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

        private void btnDeleteKecamatan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_DeleteKecamatan";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_kecamatan", tbIDKecamatan.Text);

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
            clear();
        }
        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.generateIdKecamatan() AS newId";
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
            tbIDKecamatan.Text = newId;
            tbNamaKecamatan.Text = "";
            tbLongitudeKecamatan.Text = "";
            tbLatitudeKecamatan.Text = "";
            cbIDKabupatenKecamatan.Text = "";
        }

        private void btnCancelKecamatan_Click(object sender, EventArgs e)
        {
            clear();
        }

        //membuat prosedur
        private void RefreshDataSet()
        {
            this.getNamaKabupatenTableAdapter.FillBy1(this.dsEkspedisi.getNamaKabupaten, string.Empty);
        }

        private void cariData(string data)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            string query = $"SELECT * FROM dbo.getListKecamatan('{data}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvKecamatan.DataSource = table;
            }
        }

        private void btnCariKecamatan_Click(object sender, EventArgs e)
        {
            if (tbCariKecamatan.TextLength != 0)
            {
                string data = tbCariKecamatan.Text.ToString();
                cariData(data);
            }
            else
            {
                cariData("");
            }
        }

        private void dgvKecamatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah valid
            {
                DataGridViewRow row = dgvKecamatan.Rows[e.RowIndex];

                // Mengisi nilai dari setiap kolom ke dalam TextBox sesuai dengan indeks kolomnya
                tbIDKecamatan.Text = row.Cells[0].Value.ToString();
                cbIDKabupatenKecamatan.SelectedValue = row.Cells[1].Value.ToString();
                tbNamaKecamatan.Text = row.Cells[2].Value.ToString();
                tbLongitudeKecamatan.Text = row.Cells[3].Value.ToString();
                tbLatitudeKecamatan.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnUpdateKecamatan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateKecamatan";
                cmd.CommandType = CommandType.StoredProcedure;

                // Validasi data tidak boleh kosong 'nama kecamatan'
                if (tbNamaKecamatan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLongitudeKecamatan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbLatitudeKecamatan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idKecamatan = tbIDKecamatan.Text;
                string idKabkot = cbIDKabupatenKecamatan.SelectedValue.ToString();
                string namaKecamatan = tbNamaKecamatan.Text;
                float longitude = float.Parse(tbLongitudeKecamatan.Text);
                float latitude = float.Parse(tbLatitudeKecamatan.Text);

                string checkExistQuery = "SELECT COUNT(*) FROM tblKecamatan WHERE nama_kecamatan = @nama_kecamatan";
                SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, connection);
                checkExistCmd.Parameters.AddWithValue("@nama_kecamatan", namaKecamatan);

                connection.Open();
                int existingCount = Convert.ToInt32(checkExistCmd.ExecuteScalar());
                connection.Close();

                if (existingCount > 0)
                {
                    MessageBox.Show("Data already exists. Please enter different data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd.Parameters.AddWithValue("@id_kecamatan", idKecamatan);
                cmd.Parameters.AddWithValue("@id_kabkot", idKabkot);
                cmd.Parameters.AddWithValue("@nama_kecamatan", namaKecamatan);
                cmd.Parameters.AddWithValue("@longitude", longitude);
                cmd.Parameters.AddWithValue("@latitude", latitude);

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

        private void tbNamaKecamatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbIDKabupatenKecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
