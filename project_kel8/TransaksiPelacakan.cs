using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class TransaksiPelacakan : Form
    {
        private DataTable table;
        public TransaksiPelacakan()
        {
            InitializeComponent();
            table = new DataTable();
        }

        private void LoadTransaksiPelacakan()
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Ambil ID_Gudang dari tabel tblGudang berdasarkan Nama_Gudang dari sesi
                    string queryGudang = "SELECT ID_Gudang FROM tblGudang WHERE Nama_Gudang = @NamaGudang";
                    string idGudang = "";
                    using (SqlCommand commandGudang = new SqlCommand(queryGudang, connection))
                    {
                        commandGudang.Parameters.AddWithValue("@NamaGudang", Session.NamaGudang);
                        idGudang = commandGudang.ExecuteScalar()?.ToString();
                    }

                    if (string.IsNullOrEmpty(idGudang))
                    {
                        MessageBox.Show("Gudang ID not found for the current user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Menggunakan function dbo.GetResiByGudang untuk mendapatkan data
                    string queryData = "SELECT * FROM dbo.GetResiByGudang(@current_gudang)";
                    using (SqlCommand commandData = new SqlCommand(queryData, connection))
                    {
                        commandData.Parameters.AddWithValue("@current_gudang", idGudang);

                        using (SqlDataReader reader = commandData.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Ambil data dari SqlDataReader
                                string noResi = reader["Nomor_Resi"].ToString();
                                string tanggal = reader["Tanggal"].ToString();
                                string idJenis = reader["ID_Jenis"].ToString();
                                string idgudang = reader["ID_Gudang"].ToString();
                                string idPromo = reader["ID_Promo"].ToString();
                                string namaPengirim = reader["Nama_Pengirim"].ToString();
                                string alamatPengirim = reader["Alamat_Pengirim"].ToString();
                                string telpPengirim = reader["No_Telp_Pengirim"].ToString();
                                string namaPenerima = reader["Nama_Penerima"].ToString();
                                string idKecamatan = reader["ID_Kecamatan"].ToString();
                                string alamatPenerima = reader["Alamat_Penerima"].ToString();
                                string telpPenerima = reader["No_Telp_Penerima"].ToString();
                                string jarak = reader["Jarak"].ToString();
                                string berat = reader["Berat"].ToString();
                                string totalHarga = reader["Total_Harga"].ToString();

                                dgvPelacakan.Rows.Add(noResi, tanggal, idJenis, idgudang,
                                    idPromo,namaPengirim, alamatPengirim, telpPengirim, namaPenerima, idKecamatan, alamatPenerima, telpPenerima,
                                    jarak, berat, totalHarga);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tangani kesalahan
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadDataPelacakan()
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
            try
            {
                // Buat kueri SQL untuk mendapatkan data pelacakan berdasarkan nomor resi
                string query = "SELECT * FROM tblTrsPelacakan WHERE Nomor_Resi = '" + tbResiTrsPelacakan.Text + "'";

                // Jalankan kueri dan isi data ke dgvPelacakan
                SqlConnection conn = new SqlConnection(connectionString); // Ganti Your_Connection_String dengan string koneksi Anda
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dgvViewPelacakan.Rows.Clear();
                    while (reader.Read())
                    {
                        // Ambil data dari SqlDataReader
                        string idpelacakan = reader["ID_Pelacakan"].ToString();
                        string noResi = reader["Nomor_Resi"].ToString();
                        string tanggal = reader["Tanggal"].ToString();
                        string idgudang = reader["ID_Gudang"].ToString();
                        string informasipaket = reader["Informasi_Paket"].ToString();

                        dgvViewPelacakan.Rows.Add(idpelacakan, noResi, tanggal, idgudang, informasipaket);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnKonfimasi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string idgudang = "";
                    string resi = ""; // Assign the appropriate value for 'resi' variable
                    string infoPaket = null;
                    int idPelacakan = 0;
                    string informasiPaket = null;
                    string namagud = Session.NamaGudang;
                    string query = "SELECT ID_Gudang FROM tblGudang WHERE Nama_Gudang = @NamaGudang";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NamaGudang", namagud);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idgudang = reader.GetString(0);
                            }
                        }
                    }

                    // Get 'idPelacakan' and 'informasiPaket' from the dgvViewPelacakan DataGridView
                    if (dgvViewPelacakan.CurrentRow != null)
                    {
                        DataGridViewRow row = dgvViewPelacakan.CurrentRow;
                        idPelacakan = Convert.ToInt32(row.Cells["ID_Pelacakan"].Value);
                        informasiPaket = row.Cells["Informasi_Paket"].Value.ToString();
                    }

                    bool isPreviousStatusDiterima = false;
                    string query3 = "SELECT Informasi_Paket FROM tblTrsPelacakan WHERE ID_Pelacakan = (SELECT MAX(ID_Pelacakan) FROM tblTrsPelacakan WHERE ID_Pelacakan < @currentIdPelacakan AND Nomor_Resi = @resi) AND Nomor_Resi = @resi";
                    using (SqlCommand command3 = new SqlCommand(query3, connection))
                    {gi
                        command3.Parameters.AddWithValue("@currentIdPelacakan", idPelacakan);
                        command3.Parameters.AddWithValue("@resi", resi); // Use the value of the 'resi' variable
                        using (SqlDataReader reader = command3.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string prevInformasiPaket = reader["Informasi_Paket"].ToString();
                                if (prevInformasiPaket == "Diterima")
                                {
                                    // The previous warehouse has updated the status to "Diterima"
                                    isPreviousStatusDiterima = true;
                                }
                            }
                        }
                    }

                    if (!isPreviousStatusDiterima)
                    {
                        MessageBox.Show("Failed to confirm! The previous warehouse has not updated the status to 'Diterima'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (informasiPaket == null)
                    {
                        // Lanjutkan dengan menjalankan stored procedure
                        string storeProcedure2 = "sp_UpdateTrsPelacakan";
                        using (SqlCommand command2 = new SqlCommand(storeProcedure2, connection)) // Rename the variable to command2
                        {
                            command2.CommandType = System.Data.CommandType.StoredProcedure;
                            command2.Parameters.AddWithValue("@resi", tbResiTrsPelacakan.Text);
                            command2.Parameters.AddWithValue("@idgudang", idgudang);
                            command2.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data confirmation successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Check the 'Informasi_Paket' for the current record
                    string queryCheck = "SELECT Informasi_Paket FROM tblTrsPelacakan WHERE Nomor_Resi = @resi AND ID_Gudang = @idgudang";
                    using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection)) // Rename the variable to commandCheck
                    {
                        commandCheck.Parameters.AddWithValue("@resi", tbResiTrsPelacakan.Text); // Use the text value of the TextBox
                        commandCheck.Parameters.AddWithValue("@idgudang", idgudang);
                        informasiPaket = Convert.ToString(commandCheck.ExecuteScalar());
                    }

                    if (informasiPaket.Equals("Diterima"))
                    {
                        // Tampilkan pesan jika informasi paket sudah 'Diterima'
                        MessageBox.Show("You have already confirmed this package!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (informasiPaket.Equals("Dikirim"))
                    {
                        MessageBox.Show("Failed to confirm!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand com = new SqlCommand("sp_UpdateTrsPelacakan", connection))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@nomor_resi", tbResiTrsPelacakan.Text);
                        com.Parameters.AddWithValue("@idgudang", idgudang);

                        // Execute the stored procedure
                        int result = Convert.ToInt32(com.ExecuteNonQuery());
                        if (result != 0)
                        {
                            MessageBox.Show("Data confirmation successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDataPelacakan();
                        }
                        else
                        {
                            MessageBox.Show("Failed to confirmation data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void tbResiTrsPelacakan_KeyUp(object sender, KeyEventArgs e)
        {
            string searchValue = tbResiTrsPelacakan.Text;

            foreach (DataGridViewRow row in dgvPelacakan.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell cell = row.Cells["Nomor_Resi"];
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void TransaksiPelacakan_Load(object sender, EventArgs e)
        {
            LoadTransaksiPelacakan();
        }

        private void dgvPelacakan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik bukan baris header
            {
                // Dapatkan nilai Nomor_Resi dari kolom yang sesuai di dgvPengiriman
                DataGridViewRow baris = dgvPelacakan.Rows[e.RowIndex];
                string nomorResi = baris.Cells["Nomor_Resi"].Value.ToString();

                // Tampilkan data pelacakan yang sesuai di dgvPelacakan
                loadDataPelacakan();
            }
        }
    }
}


 