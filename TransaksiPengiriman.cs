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
    public partial class TransaksiPengiriman : Form
    {
        public TransaksiPengiriman()
        {
            InitializeComponent();
        }

        private void TransaksiPengiriman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblJenisPengiriman' table. You can move, or remove it, as needed.
            this.tblJenisPengirimanTableAdapter.Fill(this.dsEkspedisi.tblJenisPengiriman);
            string newId = GenerateId();
            tbResiTrsPengiriman.Text = newId;

        }

        private void btnSaveTRSP_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertTrsPengiriman";
                cmd.CommandType = CommandType.StoredProcedure;

                string noResi = tbResiTrsPengiriman.Text;
                string jenisPengiriman = cbJnsPengirimanTrsPengiriman.SelectedValue.ToString();
                string jarak = tbJarakTrsPengiriman.Text;
                string berat = tbBeratTrsPengiriman.Text;
                string total = tbTotalTrsPengiriman.Text;
                string alasan = tbAlasanTrsPengiriman.Text;

                string namaPengirim = tbNamaPengirimTRSP.Text;
                string alamatPengirim = tbAlamatPengirimTRSP.Text;
                string noTelpPengirim = tbNoTelpPengirimTRSP.Text;

                string namaPenerima = tbNamaPenerimaTRSP.Text;
                string alamatPenerima = tbAlamatPenerimaTRSP.Text;
                string noTelpPenerima = tbNoTelpPenerimaTRSP.Text;

                string longitudePenerima = tbLongitudePenerimaTRSP.Text;
                string latitudePenerima = tbLatitudePenerimaTRSP.Text;


                // Validasi data tidak boleh kosong 'Transaksi Pengiriman'
                if (tbJarakTrsPengiriman.Text == "")
                {
                    MessageBox.Show("Kolom Jarak tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbBeratTrsPengiriman.Text == "")
                {
                    MessageBox.Show("Kolom Berat tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbAlasanTrsPengiriman.Text == "")
                {
                    MessageBox.Show("Kolom Alasan tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbNamaPengirimTRSP.Text == "")
                {
                    MessageBox.Show("Kolom Nama Pengirim tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbAlamatPengirimTRSP.Text == "")
                {
                    MessageBox.Show("Kolom Alamat Pengirim tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbNoTelpPengirimTRSP.Text == "")
                {
                    MessageBox.Show("Kolom No Telepon Pengirim tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbNamaPenerimaTRSP.Text == "")
                {
                    MessageBox.Show("Kolom Nama Penerima tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbAlamatPenerimaTRSP.Text == "")
                {
                    MessageBox.Show("Kolom Nama Penerima tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbNoTelpPenerimaTRSP.Text == "")
                {
                    MessageBox.Show("Kolom No telepon Penerimq tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbLongitudePenerimaTRSP.Text == "")
                {
                    MessageBox.Show("Kolom Longitude Penerima tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbLatitudePenerimaTRSP.Text == "")
                {
                    MessageBox.Show("Kolom Latitude Penerima tidak boleh kosong.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd.Parameters.AddWithValue("@Nomor_Resi", noResi);
                cmd.Parameters.AddWithValue("@ID_Jenis", jenisPengiriman);
                cmd.Parameters.AddWithValue("@Jarak", jarak);
                cmd.Parameters.AddWithValue("@Berat", berat);
                cmd.Parameters.AddWithValue("@Total_Harga", total);
                cmd.Parameters.AddWithValue("@Alasan", alasan);
                cmd.Parameters.AddWithValue("@Nama_Pengirim", namaPengirim);
                cmd.Parameters.AddWithValue("@Alamat_Pengirim", alamatPengirim);
                cmd.Parameters.AddWithValue("@No_Telp_Pengirim", noTelpPengirim);
                cmd.Parameters.AddWithValue("@Nama_Penerima", namaPenerima);
                cmd.Parameters.AddWithValue("@Alamat_Penerima", alamatPenerima);
                cmd.Parameters.AddWithValue("@No_Telp_Penerima", noTelpPenerima);
                cmd.Parameters.AddWithValue("@Longitude_Penerima", longitudePenerima);
                cmd.Parameters.AddWithValue("@Latitude_Penerima", latitudePenerima);


                connection.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Input data Kecamatan berhasil!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //RefreshDataSet();
                    clear();
                }
                else
                {
                    MessageBox.Show("Input data Kecamatan gagal!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.getNoResi() AS newId";
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
            tbResiTrsPengiriman.Text = newId;
            cbJnsPengirimanTrsPengiriman.SelectedIndex = -1;
            tbJarakTrsPengiriman.Text = "";
            tbBeratTrsPengiriman.Text = "";
            tbTotalTrsPengiriman.Text = "";
            tbAlasanTrsPengiriman.Text = "";

            tbNamaPengirimTRSP.Text = "";
            tbAlamatPengirimTRSP.Text = "";
            tbNoTelpPengirimTRSP.Text = "";

            tbNamaPenerimaTRSP.Text = "";
            tbAlamatPenerimaTRSP.Text = "";
            tbNoTelpPenerimaTRSP.Text = "";

            tbLongitudePenerimaTRSP.Text = "";
            tbLatitudePenerimaTRSP.Text = "";



        }
        private void Clear()
        {
            cbJnsPengirimanTrsPengiriman.SelectedIndex = -1;
            tbJarakTrsPengiriman.Text = "";
            tbBeratTrsPengiriman.Text = "";
            tbTotalTrsPengiriman.Text = "";
            tbAlasanTrsPengiriman.Text = "";

            tbNamaPengirimTRSP.Text = "";
            tbAlamatPengirimTRSP.Text = "";
            tbNoTelpPengirimTRSP.Text = "";

            tbNamaPenerimaTRSP.Text = "";
            tbAlamatPenerimaTRSP.Text = "";
            tbNoTelpPenerimaTRSP.Text = "";

            tbLongitudePenerimaTRSP.Text = "";
            tbLatitudePenerimaTRSP.Text = "";
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public float HitungJarak(String idKaryawan, double latPenerima, double longPenerima)
        {
            float distance = 0;
            
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                string query = "SELECT dbo.getDistance(@karyawanid, @lat1, @lon1) AS Distance";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@karyawanid", idKaryawan);
                        command.Parameters.AddWithValue("@lat1", latPenerima);
                        command.Parameters.AddWithValue("@lon1", longPenerima);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                distance = Convert.ToSingle(reader["Distance"]);
                            }    
                        }
                    }

                }
            return distance;
          
        }

        private void tbJarakTrsPengiriman_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                string idKaryawan = tbKaryawanTrsPengiriman.Text;
                double longPenerima = Double.Parse(tbLongitudePenerimaTRSP.Text);
                double latPenerima = Double.Parse(tbLatitudePenerimaTRSP.Text);

                double jarak = HitungJarak(idKaryawan, latPenerima, longPenerima);
                tbJarakTrsPengiriman.Text = jarak.ToString("F2");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghitung jarak!");
                Console.WriteLine(ex.ToString());
            }

        }

        private float hitungTotal(float berat, float jarak, string jenis)
        {
            MessageBox.Show("berat = " + berat + " jarak = " + jarak + " jenis = " + jenis);
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
            float jaraktotal = 0;
            float tarifdasarjarak = 1000;
            float total = 0;

            if (jarak <= 50)
            {
                jaraktotal = tarifdasarjarak;
            }
            else
            {
                float jaraklebih = jarak - 50;
                jaraktotal = (float)(tarifdasarjarak + (Math.Ceiling(jaraklebih / 10) * 500));
                MessageBox.Show("jarak total = " + jaraktotal);
            }
            // Mendapatkan harga jenis pengiriman
            string query = "SELECT HargaPerKg FROM tblJenisPengiriman WHERE ID_Jenis = '" + cbJnsPengirimanTrsPengiriman.SelectedValue+"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nama_jenis", jenis);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double hargaJenis = reader.GetDouble(0);
                            MessageBox.Show("harga jenis " + hargaJenis);
                            total = (jaraktotal + (float)hargaJenis) * berat;
                            MessageBox.Show("total " + total);
                        }
                    }
                }
            }

            return total;
        }

        private void tbTotalTrsPengiriman_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                float berat = float.Parse(tbBeratTrsPengiriman.Text);
                float jarak = float.Parse(tbJarakTrsPengiriman.Text);
                string jenis = cbJnsPengirimanTrsPengiriman.SelectedValue.ToString();

                float total = hitungTotal(berat, jarak, jenis);
                tbTotalTrsPengiriman.Text = total.ToString();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghitung total!");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
