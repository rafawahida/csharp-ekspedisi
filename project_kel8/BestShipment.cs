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
    public partial class BestShipment : Form
    {
        public BestShipment()
        {
            InitializeComponent();
        }

        private void BestShipment_Load(object sender, EventArgs e)
        {
            this.tblTrsPengirimanTableAdapter.Fill(this.dsEkspedisi.tblTrsPengiriman);
        }
        private DataTable GetData()
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
            string query = "SELECT * FROM tblTrsPengiriman"; // Ganti dengan query Anda

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Tangani exception atau kesalahan di sini
                // Misalnya, tampilkan pesan error, catat log, atau lakukan tindakan lain sesuai kebutuhan
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Jika terjadi kesalahan, kembalikan null atau DataTable kosong
                return null;
            }

            return dataTable;
        }

        private void FilterDataByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = GetData(); // Metode untuk mendapatkan data, gantilah sesuai dengan data Anda

            // Periksa apakah dataTable memiliki value sebelum melanjutkan
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                // Jika dataTable kosong, maka tidak ada data untuk difilter, clear DataGridView dan berhenti di sini
                dgvShipment.DataSource = null;
                return;
            }

            try
            {
                // Lakukan filter menggunakan LINQ
                var filteredData = from row in dataTable.AsEnumerable()
                                   where row.Field<DateTime>("Tanggal") >= startDate && row.Field<DateTime>("Tanggal") <= endDate
                                   select row;

                // Konversi hasil filter menjadi objek DataTable
                DataTable filteredDataTable = filteredData.CopyToDataTable();


                // Isi DataGridView dengan data yang sudah difilter
                dgvShipment.DataSource = filteredDataTable;
            }
            catch (Exception ex)
            {

                // Jika hasil filter kosong, clear DataGridView dan berhenti di sini
                dgvShipment.DataSource = null;
                return;
                // Tangani exception atau kesalahan di sini
                // Misalnya, tampilkan pesan error, catat log, atau lakukan tindakan lain sesuai kebutuhan
                // Jika Anda ingin mengabaikan pesan kesalahan dan tidak melakukan tindakan apa pun, biarkan blok catch kosong
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime tanggalAwal = dtAwal.Value;
            DateTime tanggalAkhir = dtAkhir.Value;

            // Panggil metode FilterDataByDateRange dengan rentang tanggal yang dipilih
            FilterDataByDateRange(tanggalAwal, tanggalAkhir);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PanggilBestShipment bestShipment = new PanggilBestShipment();
            bestShipment.ShowDialog();
        }
    }
}
