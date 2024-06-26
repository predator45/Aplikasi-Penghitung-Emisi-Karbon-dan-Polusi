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
    public partial class FormPolusiCahaya : Form
    {
        public FormPolusiCahaya()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(luminanceTextBox.Text, out double luminance))
            {
                double lpi = CalculateLightPollutionIndex(luminance);
                resultLabel.Text = "Light Pollution Index: " + lpi.ToString("F2");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number for luminance.");
            }
        }

        private double CalculateLightPollutionIndex(double luminance)
        {
            return luminance / 1000.0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            luminanceTextBox.Text = "";
            resultLabel.Text = "";
        }

        private void FormPolusiCahaya_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var FormMenu = new FormMenu();  
            FormMenu.Show(this);
            this.Close();
        }
    }
}
