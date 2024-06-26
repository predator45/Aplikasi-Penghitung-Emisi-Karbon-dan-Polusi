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
    public partial class FormHasilEmisi : System.Windows.Forms.Form
    {
        public double EmisiTransportasi { get; set; }
        public double EmisiMakanan { get; set; }
        public double EmisiEnergi { get; set; }

        public FormHasilEmisi()
        {
            InitializeComponent();
        }

        private void FormHasilEmisi_Load(object sender, EventArgs e)
        {
            lblEmisiTransportasi.Text = EmisiTransportasi.ToString();
            lblEmisiMakanan.Text = EmisiMakanan.ToString();
            lblEmisiEnergi.Text = EmisiEnergi.ToString();
            lblTotalEmisi.Text = (EmisiTransportasi + EmisiMakanan + EmisiEnergi).ToString();
        }
    }
}
