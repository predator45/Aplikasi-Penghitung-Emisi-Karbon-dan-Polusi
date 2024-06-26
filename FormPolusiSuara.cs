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
    public partial class FormPolusiSuara : Form
    {
        public FormPolusiSuara()
        {
            InitializeComponent();
        }

        private void FormPolusiSuara_Load(object sender, EventArgs e)
        {
            // Additional load logic can be placed here
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tingkatSuaraStr = txtTingkatSuara.Text.Split(',');
                double[] tingkatSuara = Array.ConvertAll(tingkatSuaraStr, double.Parse);
                double hasil = PolusiSuara.HitungTingkatKebisingan(tingkatSuara);
                txtHasil.Text = $"Tingkat Kebisingan: {hasil} dB";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input tidak valid. Harap masukkan angka yang benar dipisah dengan koma.");
            }
        }

        private void txtTingkatSuara_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.Show(this);
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            txtTingkatSuara.Text = "";
            txtHasil.Text = "";
        }
    }

    public static class PolusiSuara
    {
        public static double HitungTingkatKebisingan(double[] tingkatSuara)
        {
            double sum = 0;
            foreach (var tingkat in tingkatSuara)
            {
                sum += Math.Pow(10, tingkat / 10);
            }
            return 10 * Math.Log10(sum / tingkatSuara.Length);
        }
    }
}
