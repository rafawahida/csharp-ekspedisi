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
    public partial class MasterGudang : Form
    {
        public MasterGudang()
        {
            InitializeComponent();
        }
        
        private void MasterGudang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblGudang' table. You can move, or remove it, as needed.
            this.tblGudangTableAdapter.Fill(this.dsEkspedisi.tblGudang);
            // TODO: This line of code loads data into the 'dsEkspedisi.tblKecamatan' table. You can move, or remove it, as needed.
            this.tblKecamatanTableAdapter.Fill(this.dsEkspedisi.tblKecamatan);
            string newId = GenerateId();
            tbIDGudang.Text = newId;
            RefreshDataSet();
            cbIDKecamatanGudang.SelectedIndex = -1;
        }

        private void btnSaveGudang_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertGudang";
                cmd.CommandType = CommandType.StoredProcedure;

                // Validasi data tidak boleh kosong 'nama kecamatan'
                if (tbNamaGudang.Text == "" || tbLongitudeGudang.Text == "" || tbLatitudeGudang.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi apakah data nama_gudang sudah ada
                connection.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblGudang WHERE nama_gudang = @nama_gudang", connection);
                checkCmd.Parameters.AddWithValue("@nama_gudang", tbNamaGudang.Text);
                int gudangCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                connection.Close();
                if (gudangCount > 0)
                {
                    MessageBox.Show("This warehouse is already in place!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idKecamatan = cbIDKecamatanGudang.SelectedValue.ToString();
                string idGudang = tbIDGudang.Text;
                string namaGudang = tbNamaGudang.Text;
                string longitude = tbLongitudeGudang.Text;
                string latitude = tbLatitudeGudang.Text;

                cmd.Parameters.AddWithValue("@id_kecamatan", idKecamatan);
                cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                cmd.Parameters.AddWithValue("@nama_gudang", namaGudang);
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

        private void btnDeleteGudang_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_DeleteGudang";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_gudang", tbIDGudang.Text);

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
                string query = "SELECT dbo.generateIdGudang() AS newId";
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
            tbIDGudang.Text = newId;
            tbNamaGudang.Text = "";
            tbLongitudeGudang.Text = "";
            tbLatitudeGudang.Text = "";
            cbIDKecamatanGudang.Text = "";
        }

        private void btnCancelGudang_Click(object sender, EventArgs e)
        {
            clear();
        }

        //membuat prosedur
        private void RefreshDataSet()
        {
            this.getNamaKecamatanTableAdapter.FillBy(this.dsEkspedisi.getNamaKecamatan, string.Empty);
        }

        private void cariData(string data)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            string query = $"SELECT * FROM dbo.getGudang('{data}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvGudang.DataSource = table;
            }
        }

        private void btnCariGudang_Click(object sender, EventArgs e)
        {
            if (tbCariGudang.TextLength != 0)
            {
                string data = tbCariGudang.Text.ToString();
                cariData(data);
            }
            else
            {
                MessageBox.Show("Please enter by warehouse name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCariGudang.Focus(); // Fokuskan kembali ke TextBox agar pengguna dapat mengisi kembali
            }
        }

        private void dgvGudang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string namakecamatan;
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah valid
            {
                DataGridViewRow row = dgvGudang.Rows[e.RowIndex];

                // Mengisi nilai dari setiap kolom ke dalam TextBox sesuai dengan indeks kolomnya
                tbIDGudang.Text = row.Cells[0].Value.ToString();
                namakecamatan = row.Cells[1].Value.ToString();
                tbNamaGudang.Text = row.Cells[2].Value.ToString();
                tbLongitudeGudang.Text = row.Cells[3].Value.ToString();
                tbLatitudeGudang.Text = row.Cells[4].Value.ToString();

                //loop melalui setiap opsi combobox
                foreach (var item in cbIDKecamatanGudang.Items)
                {
                    //Mengambil nilai display dari setiap opsi
                    string displayValue = ((DataRowView)item)["Nama_Kecamatan"].ToString();

                    //Memeriksa jika nilai display cocok dengan yang diinginkan
                    if (displayValue == namakecamatan)
                    {
                        //Mengatur opsi terpilih berdasarkan nilai display
                        cbIDKecamatanGudang.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnUpdateGudang_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateGudang";
                cmd.CommandType = CommandType.StoredProcedure;

                // Validasi data tidak boleh kosong
                if (tbNamaGudang.Text == "" || tbLongitudeGudang.Text == "" || tbLatitudeGudang.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi apakah data nama_gudang sudah ada
                connection.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblGudang WHERE nama_gudang = @nama_gudang", connection);
                checkCmd.Parameters.AddWithValue("@nama_gudang", tbNamaGudang.Text);
                int gudangCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                connection.Close();
                if (gudangCount > 0)
                {
                    MessageBox.Show("This warehouse is already in place!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idKecamatan = cbIDKecamatanGudang.SelectedValue.ToString();
                string idGudang = tbIDGudang.Text;
                string namaGudang = tbNamaGudang.Text;
                string longitude = tbLongitudeGudang.Text;
                string latitude = tbLatitudeGudang.Text;

                cmd.Parameters.AddWithValue("@id_kecamatan", idKecamatan);
                cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                cmd.Parameters.AddWithValue("@nama_gudang", namaGudang);
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
