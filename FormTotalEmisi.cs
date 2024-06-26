using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormTotalEmisi : Form
    {
        public FormTotalEmisi()
        {
            InitializeComponent();
        }

        private void buttonHitungTotal_Click(object sender, EventArgs e)
        {
            try
            {
                double emisiTransportasi = Convert.ToDouble(textBoxTransportasi.Text);
                double emisiEnergi = Convert.ToDouble(textBoxEnergi.Text);
                double emisiMakanan = Convert.ToDouble(textBoxMakanan.Text);

                double totalEmisi = emisiTransportasi + emisiEnergi + emisiMakanan;
                labelHasilTotal.Text = "Total Emisi: " + totalEmisi + " kg CO2";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTotalEmisi_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxEnergi.Text = "";
            textBoxTransportasi.Text = "";
            textBoxMakanan.Text = "";
        }

        private void labelMakanan_Click(object sender, EventArgs e)
        {

        }
    }
}
