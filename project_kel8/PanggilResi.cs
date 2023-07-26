using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{
    public partial class PanggilResi : Form
    {
        public PanggilResi()
        {
            InitializeComponent();
        }

        private void PanggilResi_Load(object sender, EventArgs e)
        {
        }

        private void btnResiTRSP_Click(object sender, EventArgs e)
        {
            this.getLaporanResiTableAdapter.FillBy2(this.dsEkspedisi.getLaporanResi, txtResi.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
