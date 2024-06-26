using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonTransportasi_Click(object sender, EventArgs e)
        {
            FormTransportasi formTransportasi = new FormTransportasi();
            formTransportasi.Show();
        }

        private void buttonEnergi_Click(object sender, EventArgs e)
        {
            FormEnergi formEnergi = new FormEnergi();
            formEnergi.Show();
        }

        private void buttonMakanan_Click(object sender, EventArgs e)
        {
            FormMakanan formMakanan = new FormMakanan();
            formMakanan.Show();
        }

        private void buttonTotalEmisi_Click(object sender, EventArgs e)
        {
            FormTotalEmisi formTotalEmisi = new FormTotalEmisi();
            formTotalEmisi.Show();
        }

        private void FormMenu_Load(object sender, EventArgs eventArgs)
        {
            // Initialization logic if needed
        }

        private void buttonPolusiUdara_Click(object sender, EventArgs e)
        {
            FormPolusiUdara formPolusiUdara = new FormPolusiUdara();
            formPolusiUdara.Show();
        }

        private void buttonPolusiAir_Click(object sender, EventArgs e)
        {
            FormPolusiAir formPolusiAir = new FormPolusiAir();
            formPolusiAir.Show();
        }

        private void buttonPolusiTanah_Click(object sender, EventArgs e)
        {
            FormPolusiTanah formPolusiTanah = new FormPolusiTanah();
            formPolusiTanah.Show();
        }

        private void buttonPolusiSuara_Click(object sender, EventArgs e)
        {
            FormPolusiSuara formPolusiSuara = new FormPolusiSuara();
            formPolusiSuara.Show();
        }

        private void buttonRadiasiPengion_Click(object sender, EventArgs e)
        {
            FormRadiasiPengion formRadiasiPengion = new FormRadiasiPengion();
            formRadiasiPengion.Show();
        }

        private void buttonPolusiCahaya_Click(object sender, EventArgs e)
        {
            FormPolusiCahaya formPolusiCahaya = new FormPolusiCahaya();
            formPolusiCahaya.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

