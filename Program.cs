

using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            Application.Run(new LoginForm());
            Application.Run(new FormMenu());
            Application.Run(new FormRegister());
            Application.Run(new FormTransportasi());
            Application.Run(new FormMakanan());
            Application.Run(new FormEnergi());
            Application.Run(new FormPolusiUdara());
            Application.Run(new FormPolusiTanah());
            Application.Run(new FormPolusiAir());
            Application.Run(new FormPolusiSuara());
            Application.Run(new FormRadiasiPengion());
            Application.Run(new FormPolusiCahaya());
           
            Application.Run(new Form());
            Application.Run(new FormHasilEmisi());
            Application.Run(new FormTotalEmisi());

            // Set the emission values
            double emisiTransportasi = 100.0; // Example value, replace with actual calculation
            double emisiMakanan = 50.0; // Example value, replace with actual calculation
            double emisiEnergi = 150.0; // Example value, replace with actual calculation

            var formHasilEmisi = new FormHasilEmisi
            {
                EmisiTransportasi = emisiTransportasi,
                EmisiMakanan = emisiMakanan,
                EmisiEnergi = emisiEnergi
            };
            Application.Run(formHasilEmisi);

            Application.Run(new FormTotalEmisi());
        }
    }

   
    
        
}
