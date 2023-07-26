using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class TransaksiPromo : Form
    {
        public TransaksiPromo()
        {
            InitializeComponent();
        }

        private void tbNamaPromo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransaksiPromo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEkspedisi.tblPromo' table. You can move, or remove it, as needed.
            this.tblPromoTableAdapter.Fill(this.dsEkspedisi.tblPromo);
            string newId = GenerateId();
            tbPromoID.Text = newId;

            // Mengatur tanggal saat ini pada DateTimePicker
            dtAwal.Value = DateTime.Now;
            dtAkhir.Value = DateTime.Now;

        }

        private void btnSavePromo_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_InsertTrsPromo";
                cmd.CommandType = CommandType.StoredProcedure;

                string promoID = tbPromoID.Text;
                string promoName = tbPromoName.Text;
                DateTime tanggalAwal = dtAwal.Value;
                DateTime tanggalAkhir = dtAwal.Value;
                string diskon = tbDiskon.Text;
     

                cmd.Parameters.AddWithValue("@id_promo", promoID);
                cmd.Parameters.AddWithValue("@nama", promoName);
                cmd.Parameters.AddWithValue("@tanggal_awal", tanggalAwal);
                cmd.Parameters.AddWithValue("@tanggal_akhir", tanggalAkhir);
                cmd.Parameters.AddWithValue("@potongan", diskon);

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
        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=Ekspedisi_Kel08";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.GenerateIdPromo() AS newId";
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
            tbPromoID.Text = newId;
            tbPromoName.Text = "";
            dtAwal.Text = "";
            dtAwal.Text = "";
            tbDiskon.Text = "";
        }

        private void btnClearPromo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void RefreshDataSet()
        {
            this.tblPromoTableAdapter.Fill(this.dsEkspedisi.tblPromo);
        }

    }
}
