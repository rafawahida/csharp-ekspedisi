using Microsoft.ReportingServices.Diagnostics.Internal;
using project_kel8.dsEkspedisiTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class TransaksiPengiriman : Form
    {
        string gudang = Session.NamaGudang;
        string idgudang;
        public void FindNearestPoints()
        {
            // Database connection string
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

            // SQL query to retrieve points from the database
            string query = "SELECT Nama_Gudang, Latitude, Longitude, ID_Gudang FROM tblGudang";

            // Create a list to store the points
            List<Point> points = new List<Point>();

            // Connect to the database and retrieve the points
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Nama_Gudang"].ToString();
                            double latitude = Convert.ToDouble(reader["Latitude"]);
                            double longitude = Convert.ToDouble(reader["Longitude"]);
                            string IDgudang = reader["ID_Gudang"].ToString();
                            Point point = new Point(name,latitude,longitude,IDgudang);
                            points.Add(point);
                        }
                    }
                }
            }

            // Fetch refLatitude and refLongitude based on the provided idGudang from the textbox
            string namaGudang = tbGudangTrsPengiriman.Text;
            string query2 = "SELECT Latitude, Longitude FROM tblGudang WHERE Nama_Gudang = @namaGudang";
            double refLatitude = 0.0;
            double refLongitude = 0.0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@namaGudang", namaGudang);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            refLatitude = reader.GetDouble(0);
                            refLongitude = reader.GetDouble(1);
                        }
                        else
                        {
                            // Handle the case when the idGudang is not found in the table
                            MessageBox.Show("Gudang not found in the database.");
                            return;
                        }
                    }
                }
            }

            // Calculate distances and sort points by distance
            points.Sort((p1, p2) => CalculateDistance(refLatitude, refLongitude, p1.Latitude, p1.Longitude)
                                    .CompareTo(CalculateDistance(refLatitude, refLongitude, p2.Latitude, p2.Longitude)));

            double jarak = double.Parse(tbJarakTrsPengiriman.Text);
            string InformasiPaket = "Dikirim";
            // Get the first 3 nearest points
            List<Point> nearestPoints;
            if (jarak > 100)
            {
                nearestPoints = points.GetRange(0, Math.Min(5, points.Count));
            }
            else
            {
                nearestPoints = points.GetRange(0, Math.Min(3, points.Count));
            }

            // Print the nearest points
            string Resi = tbResiTrsPengiriman.Text;

            // Print the nearest points
            foreach (Point point in nearestPoints)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand com = new SqlCommand("sp_InsertTrsPelacakan", connection))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@nomor_resi", Resi);
                        com.Parameters.AddWithValue("@idgudang", point.IDgudang);
                        com.Parameters.AddWithValue("@informasipaket", InformasiPaket);

                        // Execute the stored procedure
                        com.ExecuteNonQuery();
                    }
                }
            }
        }


        public static double CalculateDistance(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double earthRadius = 6371; // Earth's radius in kilometers

            double latDiff = DegreesToRadians(latitude2 - latitude1);
            double lonDiff = DegreesToRadians(longitude2 - longitude1);

            double a = Math.Sin(latDiff / 2) * Math.Sin(latDiff / 2) +
                       Math.Cos(DegreesToRadians(latitude1)) * Math.Cos(DegreesToRadians(latitude2)) *
                       Math.Sin(lonDiff / 2) * Math.Sin(lonDiff / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthRadius * c;
        }

        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public TransaksiPengiriman()
        {
            InitializeComponent();
        }

        private void TransaksiPengiriman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblKecamatan' table. You can move, or remove it, as needed.
            this.tblKecamatanTableAdapter.Fill(this.dsEkspedisi.tblKecamatan);
            // TODO: This line of code loads data into the 'dsEkspedisi.tblTrsPengiriman' table. You can move, or remove it, as needed.
            this.tblTrsPengirimanTableAdapter.Fill(this.dsEkspedisi.tblTrsPengiriman);
            // TODO: This line of code loads data into the 'dsEkspedisi.tblJenisPengiriman' table. You can move, or remove it, as needed.
            this.tblJenisPengirimanTableAdapter.Fill(this.dsEkspedisi.tblJenisPengiriman);
            string newId = GenerateId();
            tbResiTrsPengiriman.Text = newId;
            SetAutomaticDate();
            // Panggilan untuk menghubungkan event handler
            tbGudangTrsPengiriman.Text = Session.NamaGudang;

        }

        private void loadData()
        {
            this.getLaporanResiTableAdapter.FillBy3(this.dsEkspedisi.getLaporanResi, string.Empty);
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

                SqlCommand command = new SqlCommand("SELECT * FROM tblGudang WHERE Nama_Gudang = @id_gudang", connection);
                command.Parameters.AddWithValue("@id_gudang", tbGudangTrsPengiriman.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Memeriksa apakah data ditemukan atau tidak
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        idgudang = reader["ID_Gudang"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }

                // Menghapus bagian desimal dari nilai jarak
                string jarakText = tbJarakTrsPengiriman.Text.Replace(",00", "");

                // Konversi jarakText ke float dan format nilai jarak tanpa desimal
                if (float.TryParse(jarakText, out float jarak))
                {
                    //MessageBox.Show("Jarak = " + jarak.ToString("0"));
                }
                else
                {
                    // Tangani kasus jika jarakText tidak dapat diuraikan sebagai float
                }
                //MessageBox.Show("Jarak = " + tbJarakTrsPengiriman.Text.Replace(",00", ""));
                //ini td dikomen yang berat
                int berat = Convert.ToInt32(tbBeratTrsPengiriman.Text);

                double total = double.Parse(tbTotalTrsPengiriman.Text);
                string id_promo = tbIdPromoTrsPengiriman.Text;

                string namaPengirim = tbNamaPengirimTRSP.Text;
                string alamatPengirim = tbAlamatPengirimTRSP.Text;
                string noTelpPengirim = tbNoTelpPengirimTRSP.Text;

                string namaPenerima = tbNamaPenerimaTRSP.Text;
                string alamatPenerima = tbAlamatPenerimaTRSP.Text;
                string noTelpPenerima = tbNoTelpPenerimaTRSP.Text;
                string nama_kecamatan = cbIDKecamatan.SelectedValue.ToString();

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

                cmd.Parameters.AddWithValue("@Nomor_Resi", noResi);
                cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                cmd.Parameters.AddWithValue("@ID_Jenis", jenisPengiriman);
                cmd.Parameters.AddWithValue("@id_gudang", idgudang);
                cmd.Parameters.AddWithValue("@Nama_Pengirim", namaPengirim);
                cmd.Parameters.AddWithValue("@Alamat_Pengirim", alamatPengirim);
                cmd.Parameters.AddWithValue("@No_Telp_Pengirim", noTelpPengirim);
                cmd.Parameters.AddWithValue("@Nama_Penerima", namaPenerima);
                cmd.Parameters.AddWithValue("@ID_Kecamatan", nama_kecamatan);
                cmd.Parameters.AddWithValue("@Alamat_Penerima", alamatPenerima);
                cmd.Parameters.AddWithValue("@No_Telp_Penerima", noTelpPenerima);
                cmd.Parameters.AddWithValue("@Jarak", jarak);
                cmd.Parameters.AddWithValue("@Berat", berat);
                cmd.Parameters.AddWithValue("@Total_Harga", total);
                cmd.Parameters.AddWithValue("@ID_Promo", id_promo);
                loadData();
                
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Input data transaksi pengiriman berhasil!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FindNearestPoints();
                    clear();
                    string generateId = GenerateId();
                    tbResiTrsPengiriman.Text = generateId;
                    tbGudangTrsPengiriman.Text = Session.NamaGudang;
                }
                else
                {
                    MessageBox.Show("Input data pengiriman gagal!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //PanggilResi resi = new PanggilResi();
                //resi.ShowDialog();

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
                string query = "SELECT dbo.getNoResi(@nama) AS newId";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nama", tbNamaPengirimTRSP.Text);
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
            cbJnsPengirimanTrsPengiriman.SelectedIndex = -1;
            tbJarakTrsPengiriman.Text = "";
            tbBeratTrsPengiriman.Text = "";
            tbTotalTrsPengiriman.Text = "";
            tbIdPromoTrsPengiriman.Text = "";

            tbNamaPengirimTRSP.Text = "";
            tbAlamatPengirimTRSP.Text = "";
            tbNoTelpPengirimTRSP.Text = "";

            tbNamaPenerimaTRSP.Text = "";
            cbIDKecamatan.SelectedIndex = -1;
            tbAlamatPenerimaTRSP.Text = "";
            tbNoTelpPenerimaTRSP.Text = "";
            tbGudangTrsPengiriman.Text = "";
            tbBayarTrsPengiriman.Text = "";
            tbKembaliTrsPengiriman.Text = "";
        }



        private void SetAutomaticDate()
        {
            // Mengatur tanggal saat ini pada TextBox
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            tbTglPengiriman.Text = currentDate;
        }

        private void tbBeratTrsPengiriman_TextChanged(object sender, EventArgs e)
        {
            //HitungTotal();
            decimal jaraktotal = 0;
            decimal tarifdasarjarak = 1000;
            decimal total_harga = 0;

            try
            {
                if (!string.IsNullOrEmpty(tbGudangTrsPengiriman.Text) && !string.IsNullOrEmpty(cbIDKecamatan.Text))
                {
                    string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

                    // Ambil data harga jenis dari tblJenisPengiriman
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string queryJenis = "SELECT HargaJenis FROM tblJenisPengiriman WHERE Nama_Jenis = @namajenis";

                        using (SqlCommand command = new SqlCommand(queryJenis, connection))
                        {
                            command.Parameters.AddWithValue("@namajenis", cbJnsPengirimanTrsPengiriman.Text);

                            // Retrieve HargaJenis from the database
                            decimal hargajenis = Convert.ToDecimal(command.ExecuteScalar());

                            decimal jarak;
                            if (!decimal.TryParse(tbJarakTrsPengiriman.Text, out jarak))
                            {
                                MessageBox.Show("Invalid value for jarak. Please enter a valid numeric value.");
                                return;
                            }

                            decimal berat;
                            if (!decimal.TryParse(tbBeratTrsPengiriman.Text, out berat))
                            {
                                MessageBox.Show("Invalid value for berat. Please enter a valid numeric value.");
                                return;
                            }

                            if (jarak <= 50)
                            {
                                jaraktotal = tarifdasarjarak;
                            }
                            else
                            {
                                decimal jarak_lebih = jarak - 50;
                                jaraktotal = tarifdasarjarak + (Math.Ceiling(jarak_lebih / 10) * 500);
                            }

                            // Calculate the total_harga
                            total_harga = jaraktotal + hargajenis * berat;

                            // Kondisi jika tbIdPromoTrsPengiriman diisi
                            if (!string.IsNullOrEmpty(tbIdPromoTrsPengiriman.Text))
                            {
                                // Mengurangi total dengan harga promo jika promo masih berlaku
                                string promoQuery = "SELECT Potongan FROM tblPromo WHERE ID_Promo = @id_promo AND @tanggal BETWEEN Tanggal_BerlakuAwal AND Tanggal_BerlakuAkhir";

                                using (SqlCommand promoCommand = new SqlCommand(promoQuery, connection))
                                {
                                    promoCommand.Parameters.AddWithValue("@id_promo", tbIdPromoTrsPengiriman.Text);
                                    promoCommand.Parameters.AddWithValue("@tanggal", DateTime.Today);

                                    using (SqlDataReader reader2 = promoCommand.ExecuteReader())
                                    {
                                        if (reader2.Read())
                                        {
                                            decimal hargaPromo = Convert.ToDecimal(reader2["Potongan"]);
                                            total_harga -= hargaPromo;  //pengurangan total dengan harga promo
                                        }
                                    }
                                }
                            }

                            // Update the textbox with the total_harga value
                            CultureInfo culture = new CultureInfo("id-ID");
                            decimal formattedTotal = decimal.Parse(total_harga.ToString("#,##0.00", culture));
                            tbTotalTrsPengiriman.Text = formattedTotal.ToString();

                            // Update the textbox with the total_harga value
                            //tbTotalTrsPengiriman.Text = total_harga.ToString(); INI BARU DIKOMEN
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbBayarTrsPengiriman_TextChanged(object sender, EventArgs e)
        {
            decimal kembali;
            decimal uangtunai = decimal.Parse(tbBayarTrsPengiriman.Text);
            decimal total = decimal.Parse(tbTotalTrsPengiriman.Text);
            kembali = uangtunai - total;
            CultureInfo culture = new CultureInfo("id-ID");
            string formattedKembalian = kembali.ToString("#,##0.00", culture);

            tbKembaliTrsPengiriman.Text = formattedKembalian;
        }

        private void btnResiTRSP_Click(object sender, EventArgs e)
        {
            this.getLaporanResiTableAdapter.FillBy2(this.dsEkspedisi.getLaporanResi, tbResiTrsPengiriman.Text);

           // this.reportViewer1.RefreshReport();
        }

        private void cbJnsPengirimanTrsPengiriman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIDKecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HitungJarak();
            try
            {
                if (!string.IsNullOrEmpty(tbGudangTrsPengiriman.Text) && !string.IsNullOrEmpty(cbIDKecamatan.Text))
                {
                    double lat1 = 0, lon1 = 0, lat2 = 0, lon2 = 0;

                    string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";

                    // Ambil data latitude dan longitude dari tblGudang
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string queryGudang = "SELECT Latitude, Longitude FROM tblGudang WHERE Nama_Gudang = @gudangid";

                        using (SqlCommand command = new SqlCommand(queryGudang, connection))
                        {
                            command.Parameters.AddWithValue("@gudangid", tbGudangTrsPengiriman.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lat2 = Convert.ToDouble(reader["Latitude"]);
                                    lon2 = Convert.ToDouble(reader["Longitude"]);
                                }
                            }
                        }
                    }

                    // Ambil data latitude dan longitude dari tblKecamatan
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string queryKecamatan = "SELECT Latitude, Longitude FROM tblKecamatan WHERE Nama_Kecamatan = @kecamatanid";

                        using (SqlCommand command = new SqlCommand(queryKecamatan, connection))
                        {
                            command.Parameters.AddWithValue("@kecamatanid", cbIDKecamatan.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lat1 = Convert.ToDouble(reader["Latitude"]);
                                    lon1 = Convert.ToDouble(reader["Longitude"]);
                                }
                            }
                        }
                    }

                    // Hitung jarak menggunakan method CalculateDistance
                    double distance = CalculateDistancee.CalculateDistance(lat1, lon1, lat2, lon2);
                    if (distance >= 0)
                    {
                        tbJarakTrsPengiriman.Text = distance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("disni");
                    }
                    tbJarakTrsPengiriman.Text = distance.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}