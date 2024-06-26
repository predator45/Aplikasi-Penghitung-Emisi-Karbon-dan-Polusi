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
    public partial class FormRadiasiPengion : Form
    {
        public FormRadiasiPengion()
        {
            InitializeComponent();
        }

        private void FormRadiasiPengion_Load(object sender, EventArgs e)
        {
            // Additional load logic can be placed here
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKonsentrasiRadiasi.Text, out double konsentrasiRadiasi) && double.TryParse(txtFaktorKualitasRadiasi.Text, out double faktorKualitasRadiasi))
            {
                double hasil = RadiasiPengion.HitungDosisRadiasi(konsentrasiRadiasi, faktorKualitasRadiasi);
                txtHasil.Text = $"Dosis Radiasi Pengion: {hasil} Sv";
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
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFaktorKualitasRadiasi.Text = "";
            txtKonsentrasiRadiasi.Text = "";
            txtHasil.Text = "";
        }
    }

    public static class RadiasiPengion
    {
        public static double HitungDosisRadiasi(double konsentrasiRadiasi, double faktorKualitasRadiasi)
        {
            return konsentrasiRadiasi * faktorKualitasRadiasi;
        }
    }
}