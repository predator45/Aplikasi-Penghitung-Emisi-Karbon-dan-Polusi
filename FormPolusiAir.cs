using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormPolusiAir : Form
    {
        public FormPolusiAir()
        {
            InitializeComponent();
        }

        private void FormPolusiAir_Load(object sender, EventArgs e)
        {

        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMassaBahanKimia.Text, out double massaBahanKimia) && double.TryParse(txtVolumeAir.Text, out double volumeAir))
            {
                double hasil = PolusiAir.HitungKonsentrasiBahanKimia(massaBahanKimia, volumeAir);
                txtHasil.Text = $"Konsentrasi Bahan Kimia: {hasil} mg/L";
            }
            else
            {
                MessageBox.Show("Input tidak valid. Harap masukkan angka yang benar.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.Show(this);
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMassaBahanKimia.Text = "";
            txtVolumeAir.Text = "";
            txtHasil.Text = "";
        }
    }

    public static class PolusiAir
    {
        public static double HitungKonsentrasiBahanKimia(double massaBahanKimia, double volumeAir)
        {
            return massaBahanKimia / volumeAir;
        }
    }
}
