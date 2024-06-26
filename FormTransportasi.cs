using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormTransportasi : Form
    {
        public FormTransportasi()
        {
            InitializeComponent();
        }

        private void buttonHitungTransportasi_Click(object sender, EventArgs e)
        {
            double mobil = Convert.ToDouble(textBoxMobil.Text);
            double motor = Convert.ToDouble(textBoxMotor.Text);
            double pesawat = Convert.ToDouble(textBoxPesawat.Text);
            double keretaApi = Convert.ToDouble(textBoxKeretaApi.Text);
            double bus = Convert.ToDouble(textBoxBus.Text);

            double emisiTransportasi = (mobil * 0.21) + (motor * 0.1) + (pesawat * 0.24) + (keretaApi * 0.14) + (bus * 0.18);
            labelHasilTransportasi.Text = "Emisi Transportasi: " + emisiTransportasi + " kg CO2";
        }

        private void textBoxMobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxBus.Text = "";
            textBoxKeretaApi.Text = "";
            textBoxMobil.Text = "";
            textBoxPesawat.Text = "";
            textBoxMotor.Text = "";
            labelHasilTransportasi.Text = "";
        }

        private void FormTransportasi_Load(object sender, EventArgs e)
        {

        }

        private void labelHasilTransportasi_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }
    }
}
