using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class MasterJenisPengiriman : Form
    {
        public MasterJenisPengiriman()
        {
            InitializeComponent();
        }

        private void MasterJenisPengiriman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblJenisPengiriman' table. You can move, or remove it, as needed.
            this.tblJenisPengirimanTableAdapter.Fill(this.dsEkspedisi.tblJenisPengiriman);
            string newId = GenerateId();
            tbIDJenisPengiriman.Text = newId;

        }

        private void btnSaveJP_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertJenisPengiriman";
                cmd.CommandType = CommandType.StoredProcedure;

                string idJenisPengiriman = tbIDJenisPengiriman.Text;
                string namaJenisPengiriman = tbJenisPengiriman.Text;
                string estimasiPengiriman = tbEstimasiJP.Text;
                string hargaPengirimanKg = tbHargaKgJP.Text;
                string hargaPengirimanKm = tbHargaKmJP.Text;

                // Validasi jenis pengiriman tidak boleh kosong & diisi varchar
                if (string.IsNullOrEmpty(namaJenisPengiriman))
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi estimasi pengiriman tidak boleh kosong & diisi varchar
                if (string.IsNullOrEmpty(estimasiPengiriman))
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi harga per Kg tidak boleh kosong
                if (string.IsNullOrEmpty(hargaPengirimanKg))
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi harga per Km tidak boleh kosong
                if (string.IsNullOrEmpty(hargaPengirimanKm))
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             

                cmd.Parameters.AddWithValue("@id_jenis", idJenisPengiriman);
                cmd.Parameters.AddWithValue("@nama_jenis", namaJenisPengiriman);
                cmd.Parameters.AddWithValue("@estimasi", estimasiPengiriman);
                cmd.Parameters.AddWithValue("@HargaPerKg", hargaPengirimanKg);
                cmd.Parameters.AddWithValue("@HargaPerKm", hargaPengirimanKm);

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

        private void btnDeleteJP_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_DeleteJenisPengiriman";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_jenis", tbIDJenisPengiriman.Text);

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
        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.GenerateIdJPengiriman() AS newId";
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
            tbIDJenisPengiriman.Text = newId;
            tbIDJenisPengiriman.Text = "";
            tbEstimasiJP.Text = "";
            tbHargaKgJP.Text = "";
        }
        private void Clear()
        {
            tbIDJenisPengiriman.Text = "";
            tbEstimasiJP.Text = "";
            tbHargaKgJP.Text = "";
        }

        private void btnCancelJP_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //membuat prosedur
        private void RefreshDataSet()
        {
            this.tblJenisPengirimanTableAdapter.Fill(this.dsEkspedisi.tblJenisPengiriman);
        }

        private void cariData(string data)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            string query = $"SELECT * FROM dbo.getJenisPengiriman('{data}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvJenisPengiriman.DataSource = table;
            }
        }

        private void btnCariJP_Click(object sender, EventArgs e)
        {
            if (tbCariJP.TextLength != 0)
            {
                string data = tbCariJP.Text.ToString();
                cariData(data);
            }
            else
            {
                cariData("");
            }
        }

        private void dgvJenisPengiriman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah valid
            {
                DataGridViewRow row = dgvJenisPengiriman.Rows[e.RowIndex];

                // Mengisi nilai dari setiap kolom ke dalam TextBox sesuai dengan indeks kolomnya
                tbIDJenisPengiriman.Text = row.Cells[0].Value.ToString();
                tbJenisPengiriman.Text = row.Cells[1].Value.ToString();
                tbEstimasiJP.Text = row.Cells[2].Value.ToString();
                tbHargaKgJP.Text = row.Cells[3].Value.ToString();
                tbHargaKmJP.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnUpdateJP_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateJenisPengiriman";
                cmd.CommandType = CommandType.StoredProcedure;

                string idJenisPengiriman = tbIDJenisPengiriman.Text;
                string namaJenisPengiriman = tbJenisPengiriman.Text;
                string estimasiPengiriman = tbEstimasiJP.Text;
                string hargaPengirimanKg = tbHargaKgJP.Text;
                string hargaPengirimanKm = tbHargaKmJP.Text;

                // Validasi jenis pengiriman tidak boleh kosong & diiisi dengan varchar
                if (string.IsNullOrEmpty(namaJenisPengiriman))
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi estimasi pengiriman tidak boleh kosong & diiisi dengan varchar
                if (string.IsNullOrEmpty(estimasiPengiriman))
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi harga pengiriman per Kg tidak boleh kosong & diisi dengan angka
                float hargaKg;
                if (string.IsNullOrEmpty(hargaPengirimanKg) || !float.TryParse(hargaPengirimanKg, out hargaKg))
                {
                    MessageBox.Show("Price per Kg must be entered as a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validasi harga pengiriman per Km tidak boleh kosong & diisi dengan angka
                float hargaKm;
                if (string.IsNullOrEmpty(hargaPengirimanKm) || !float.TryParse(hargaPengirimanKm, out hargaKm))
                {
                    MessageBox.Show("Price per Km must be entered as a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd.Parameters.AddWithValue("@id_jenis", idJenisPengiriman);
                cmd.Parameters.AddWithValue("@nama_jenis", namaJenisPengiriman);
                cmd.Parameters.AddWithValue("@estimasi", estimasiPengiriman);
                cmd.Parameters.AddWithValue("@hargaperkg", hargaPengirimanKg);
                cmd.Parameters.AddWithValue("@hargaperkm", hargaPengirimanKm);

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

        private void dgvJenisPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
