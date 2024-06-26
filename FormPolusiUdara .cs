using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormPolusiUdara : Form
    {
        public FormPolusiUdara()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMassaPartikel.Text, out double massaPartikel) && double.TryParse(txtVolumeUdara.Text, out double volumeUdara))
            {
                double hasil = PolusiUdara.HitungKonsentrasiPartikulat(massaPartikel, volumeUdara);
                txtHasil.Text = $"Konsentrasi Partikulat: {hasil} µg/m³";
            }
            else
            {
                MessageBox.Show("Input tidak valid. Harap masukkan angka yang benar.");
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPolusiUdara());
        }
    }

    public static class PolusiUdara
    {
        public static double HitungKonsentrasiPartikulat(double massaPartikel, double volumeUdara)
        {
            return massaPartikel / volumeUdara;
        }

       public static void btnRefresh_Click(object sender, EventArgs e)
        {
   
        }
    }
}
