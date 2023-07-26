using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kel8
{ 
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Login());
            Application.Run(new Login());
            //Application.Run(new DashboardAdmin());
            //Application.Run(new DashboardManager()); 
            //Application.Run(new DashboardKasir());
            //Application.Run(new DashboardAdmin());
            //Application.Run(new ReportResi());
            //Application.Run(new TransaksiPengiriman());

            //Application.Run(new TransaksiPelacakan());
        }
    }
}
