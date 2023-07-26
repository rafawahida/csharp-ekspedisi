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
    public partial class MasterRole : Form
    {
        public MasterRole()
        {
            InitializeComponent();
        }

        private void MasterRole1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblRole' table. You can move, or remove it, as needed.
            this.tblRoleTableAdapter.Fill(this.dsEkspedisi.tblRole);
            RefreshDataSet();
            string newId = GenerateId();
            tbIDJabatanRole.Text = newId;
        }

        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertRole";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_role", tbIDJabatanRole.Text);

                //cmd.Parameters.AddWithValue("@jabatan", tbJabatanRole.Text);

                // Validasi input pada teks "jabatan"
                string jabatan = tbJabatanRole.Text;
                // Validasi data tidak boleh kosong
                if (jabatan == "")
                {
                    MessageBox.Show("Please enter all requred information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Validasi apabila data jabatan sudah ada
                connection.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblRole WHERE jabatan = @jabatan", connection);
                checkCmd.Parameters.AddWithValue("@jabatan", jabatan);
                int jabatanCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                connection.Close();
                if (jabatanCount > 0)
                {
                    MessageBox.Show("Data already exists. Please enter a different value for column Jabatan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                cmd.Parameters.AddWithValue("@jabatan", jabatan);

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
                    MessageBox.Show("An error occurred while saving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand del = new SqlCommand();
                del.Connection = connection;
                del.CommandText = "sp_DeleteRole";
                del.CommandType = CommandType.StoredProcedure;

                del.Parameters.AddWithValue("@id_role", tbIDJabatanRole.Text);

                connection.Open();
                int result = Convert.ToInt32(del.ExecuteNonQuery());
                connection.Close();
                if (result != 0)
                {
                    MessageBox.Show("Data deleted successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the data.", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            Clear();
        }
        // UNTUK ID OTOMATIS
        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.GenerateIdRole() AS newId";
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
            tbIDJabatanRole.Text = newId;
            tbJabatanRole.Text = "";
        }
        private void Clear()
        {
            tbJabatanRole.Text = "";
        }

        private void btnCancelRole_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //membuat prosedur
        private void RefreshDataSet()
        {
            this.tblRoleTableAdapter.Fill(this.dsEkspedisi.tblRole);
        }

        private void cariData(string data)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            string query = $"SELECT * FROM dbo.getRole('{data}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);


                dgvRole.DataSource = table;
            }
        }

        private void btnCariRole_Click(object sender, EventArgs e)
        {
            if (tbCariRole.TextLength != 0)
            {
                string data = tbCariRole.Text.ToString();
                cariData(data);
            }
            else
            {
                MessageBox.Show("please enter by position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCariRole.Focus(); // Fokuskan kembali ke TextBox agar pengguna dapat mengisi kembali
                //cariData("");
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateRole";
                cmd.CommandType = CommandType.StoredProcedure;

                string idRole = tbIDJabatanRole.Text;
                string jabatan = tbJabatanRole.Text;

                // Validasi data tidak boleh kosong
                if (jabatan == "")
                {
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Validasi apakah data jabatan sudah ada
                connection.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblRole WHERE id_role = @id_role", connection);
                checkCmd.Parameters.AddWithValue("@id_role", tbIDJabatanRole.Text);
                int jabatanCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                connection.Close();
                if (jabatanCount == 0)
                {
                    MessageBox.Show("Data not found, Please enter valid data ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd.Parameters.AddWithValue("@id_role", idRole);
                cmd.Parameters.AddWithValue("@jabatan", tbJabatanRole.Text);

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
                    MessageBox.Show("An error occurred while saving the data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah valid
            {
                DataGridViewRow row = dgvRole.Rows[e.RowIndex];

                // Mengisi nilai dari setiap kolom ke dalam TextBox sesuai dengan indeks kolomnya
                tbIDJabatanRole.Text = row.Cells[0].Value.ToString();
                tbJabatanRole.Text = row.Cells[1].Value.ToString();
            }
        }

        private void tbJabatanRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCariRole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
