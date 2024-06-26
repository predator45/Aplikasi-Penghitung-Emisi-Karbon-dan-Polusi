    using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormEnergi : Form
    {
        public FormEnergi()
        {
            InitializeComponent();
        }

        private void buttonHitungEnergi_Click(object sender, EventArgs e)
        {
            double listrik = Convert.ToDouble(textBoxListrik.Text);
            double gas = Convert.ToDouble(textBoxGas.Text);

            double emisiEnergi = (listrik * 0.92) + (gas * 2.1);
            labelHasilEnergi.Text = "Emisi Energi: " + emisiEnergi + " kg CO2";
        }

        private void FormEnergi_Load(object sender, EventArgs e)
        {

        }

        private void labelHasilEnergi_Click(object sender, EventArgs e)
        {
            textBoxGas.Text = "";
            textBoxListrik.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxListrik.Text = "";
            textBoxGas.Text = "";
            labelHasilEnergi.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            this.SuspendLayout();
            formMenu.ShowDialog();
            this.Close();
        }
    }
}
