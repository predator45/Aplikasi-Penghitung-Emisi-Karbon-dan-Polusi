using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormMakanan : Form
    {
        public FormMakanan()
        {
            InitializeComponent();
        }

        private void buttonHitungMakanan_Click(object sender, EventArgs e)
        {
            double dagingSapi = Convert.ToDouble(textBoxDagingSapi.Text);
            double dagingBabi = Convert.ToDouble(textBoxDagingBabi.Text);
            double ayam = Convert.ToDouble(textBoxAyam.Text);
            double susu = Convert.ToDouble(textBoxSusu.Text);
            double telur = Convert.ToDouble(textBoxTelur.Text);
            double sayuran = Convert.ToDouble(textBoxSayuran.Text);
            double buah = Convert.ToDouble(textBoxBuah.Text);

            double emisiMakanan = (dagingSapi * 27.0) + (dagingBabi * 12.1) + (ayam * 6.9) + (susu * 3.2) + (telur * 4.8) + (sayuran * 2.0) + (buah * 1.1);
            labelHasilMakanan.Text = "Emisi Makanan: " + emisiMakanan + " kg CO2";
        }

        private void FormMakanan_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxAyam.Text = "";
            textBoxBuah.Text = "";
            textBoxDagingBabi.Text = "";
            textBoxDagingSapi.Text = "";
            textBoxSayuran.Text = "";
            textBoxSusu.Text = "";
            textBoxTelur.Text = "";
            labelHasilMakanan.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

     
    }
}
