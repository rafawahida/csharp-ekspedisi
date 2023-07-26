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
    public partial class MasterKaryawan : Form
    {
        public MasterKaryawan()
        {
            InitializeComponent();
        }
        string empty = "";
        private void MasterKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblRole' table. You can move, or remove it, as needed.
            this.tblRoleTableAdapter.Fill(this.dsEkspedisi.tblRole);
            // TODO: This line of code loads data into the 'dsEkspedisi.tblGudang' table. You can move, or remove it, as needed.
            this.tblGudangTableAdapter.Fill(this.dsEkspedisi.tblGudang);
            // TODO: This line of code loads data into the 'dsEkspedisi.tblKaryawan' table. You can move, or remove it, as needed.
            this.tblKaryawanTableAdapter.Fill(this.dsEkspedisi.tblKaryawan);
            string newId = GenerateId();
            tbIDKaryawan.Text = newId;
            RefreshDataSet();
            

        }

        private void btnSaveKaryawan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertKaryawan";
                cmd.CommandType = CommandType.StoredProcedure;

                string idKaryawan = tbIDKaryawan.Text;
                string idRole = cbRoleKaryawan.SelectedValue.ToString();
                string idGudang = cbGudangKaryawan.SelectedValue.ToString();
                string namaKaryawan = tbNamaKaryawan.Text;
                string username = tbUsernameKaryawan.Text;
                string password = tbPasswordKaryawan.Text;
                string noTelp = tbNoTelpKaryawan.Text;

                // Validasi data tidak boleh kosong 'nama karyawan'
                if (tbNamaKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbUsernameKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbPasswordKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbNoTelpKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else 
                {
                    if (noTelp.Length > 13 || !noTelp.All(char.IsDigit))
                    {
                        MessageBox.Show("No telepon harus diisi dengan maksimal 13 angka!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Validasi no telepon harus diisi dengan maksimal 13 angka
                

                // Validasi username tidak boleh sama
                string checkExistQuery = "SELECT COUNT(*) FROM tblKaryawan WHERE username = @username";
                SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, connection);
                checkExistCmd.Parameters.AddWithValue("@username", username);

                connection.Open();
                int existingCount = Convert.ToInt32(checkExistCmd.ExecuteScalar());
                connection.Close();

                if (existingCount > 0)
                {
                    MessageBox.Show("Username already exists. Please enter a different value for column Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);
                cmd.Parameters.AddWithValue("@id_role", idRole);
                cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                cmd.Parameters.AddWithValue("@nama", namaKaryawan);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);

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

        private void btnDeleteKaryawan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_DeleteKaryawan";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@id_karyawan", tbIDKaryawan.Text);

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
                string query = "SELECT dbo.generateIdKaryawan() AS newId";
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
            tbIDKaryawan.Text = newId;
            cbRoleKaryawan.SelectedIndex = -1;
            cbGudangKaryawan.SelectedIndex = -1;
            tbNamaKaryawan.Text = "";
            tbUsernameKaryawan.Text = "";
            tbPasswordKaryawan.Text = "";
            tbNoTelpKaryawan.Text = "";
        }
        private void Clear()
        {
            cbRoleKaryawan.SelectedIndex = -1;
            cbGudangKaryawan.SelectedIndex = -1;
            tbNamaKaryawan.Text = "";
            tbUsernameKaryawan.Text = "";
            tbPasswordKaryawan.Text = "";
            tbNoTelpKaryawan.Text = "";
        }
        private void btnCancelKaryawan_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //membuat prosedur
        private void RefreshDataSet()
        {
            this.getGudangtblKaryawanTableAdapter.FillBy(this.dsEkspedisi.getGudangtblKaryawan, empty);
        }

        private void cariData(string query)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

           // string query = $"SELECT * FROM dbo.getKaryawan('{data}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvKaryawan.DataSource = table;
            }
        }

        private void btnCariKaryawan_Click(object sender, EventArgs e)
        {
            if (cbfilter.SelectedItem.ToString() == "Position")
            {
                SearchJabatan();
            }
            else
            {
                CariKaryawanByNama(tbCariKaryawan.Text);
            }
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah valid
            {
                string jabatan, gudang;
                DataGridViewRow row = dgvKaryawan.Rows[e.RowIndex];

                // Mengisi nilai dari setiap kolom ke dalam TextBox sesuai dengan indeks kolomnya
                tbIDKaryawan.Text = row.Cells[0].Value.ToString();
                jabatan = row.Cells[1].Value.ToString();
                gudang = row.Cells[2].Value.ToString();
                tbNamaKaryawan.Text = row.Cells[3].Value.ToString();
                tbUsernameKaryawan.Text = row.Cells[4].Value.ToString();
                tbPasswordKaryawan.Text = row.Cells[5].Value.ToString();
                tbNoTelpKaryawan.Text = row.Cells[6].Value.ToString();

                //loop melalui setiap opsi combobox
                foreach (var item in cbRoleKaryawan.Items)
                {
                    //Mengambil nilai display dari setiap opsi
                    string displayValue = ((DataRowView)item)["Jabatan"].ToString();

                    //Memeriksa jika nilai display cocok dengan yang diinginkan
                    if (displayValue == jabatan)
                    {
                        //Mengatur opsi terpilih berdasarkan nilai display
                        cbRoleKaryawan.SelectedItem = item;
                        break;
                    }
                }


                //loop melalui setiap opsi combobox
                foreach (var item in cbGudangKaryawan.Items)
                {
                    //Mengambil nilai display dari setiap opsi
                    string displayValue = ((DataRowView)item)["Nama_Gudang"].ToString();

                    //Memeriksa jika nilai display cocok dengan yang diinginkan
                    if (displayValue == gudang)
                    {
                        //Mengatur opsi terpilih berdasarkan nilai display
                        cbGudangKaryawan.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnUpdateKaryawan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateKaryawan";
                cmd.CommandType = CommandType.StoredProcedure;

                string idKaryawan = tbIDKaryawan.Text;
                string idRole = cbRoleKaryawan.SelectedValue.ToString();
                string idGudang = cbGudangKaryawan.SelectedValue.ToString();
                string namaKaryawan = tbNamaKaryawan.Text;
                string username = tbUsernameKaryawan.Text;
                string password = tbPasswordKaryawan.Text;
                string noTelp = tbNoTelpKaryawan.Text;

                if (tbNamaKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbUsernameKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbPasswordKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbNoTelpKaryawan.Text == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi no telepon harus diisi dengan maksimal 13 angka
                if (noTelp.Length > 13 || !noTelp.All(char.IsDigit))
                {
                    MessageBox.Show("No telepon harus diisi dengan maksimal 13 angka!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validasi username tidak boleh sama
                string checkExistQuery = "SELECT COUNT(*) FROM tblKaryawan WHERE username = @username AND id_karyawan != @id_karyawan";
                SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, connection);
                checkExistCmd.Parameters.AddWithValue("@username", username);
                checkExistCmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);

                connection.Open();
                int existingCount = Convert.ToInt32(checkExistCmd.ExecuteScalar());
                connection.Close();

                if (existingCount > 0)
                {
                    MessageBox.Show("Username already exists. Please enter a different value for column Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);
                cmd.Parameters.AddWithValue("@id_role", idRole);
                cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                cmd.Parameters.AddWithValue("@nama", namaKaryawan);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);

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

        private void tbUsernameKaryawan_TextChanged(object sender, EventArgs e)
        {

        }

        private void CariKaryawanByNama(string nama)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            string query = $"SELECT kar.ID_Karyawan, r.Jabatan, gud.Nama_Gudang, kar.Nama, kar.Username, kar.Password, kar.No_telp " +
                           $"FROM tblKaryawan kar " +
                           $"JOIN tblRole r ON kar.ID_Role = r.ID_Role " +
                           $"JOIN tblGudang gud ON kar.ID_Gudang = gud.ID_Gudang " +
                           $"WHERE kar.Nama LIKE '%' + @searchText + '%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchText", nama);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvKaryawan.DataSource = table;
            }
        }

        public void SearchJabatan()
        {
            dgvKaryawan.Rows.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection("Your_Connection_String"))
                {
                    connection.Open();
                    string query = "SELECT kar.ID_Karyawan, r.Jabatan, gud.Nama_Gudang, kar.Nama, kar.Username, kar.Password, kar.No_telp " +
                                   "FROM tblKaryawan kar " +
                                   "JOIN tblRole r ON kar.ID_Role = r.ID_Role " +
                                   "JOIN tblGudang gud ON kar.ID_Gudang = gud.ID_Gudang " +
                                   "WHERE r.Jabatan LIKE '%' + @searchText + '%'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", tbCariKaryawan.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        object[] row = new object[7]; // Menyesuaikan jumlah kolom dengan tabel
                        row[0] = reader.GetString(0);
                        row[1] = reader.GetString(1);
                        row[2] = reader.GetString(2);
                        row[3] = reader.GetString(3);
                        row[4] = reader.GetString(4);
                        row[5] = reader.GetString(5);
                        row[6] = reader.GetString(6);

                        dgvKaryawan.Rows.Add(row);
                    }

                    if (dgvKaryawan.Rows.Count == 0)
                    {
                        MessageBox.Show("Data not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


