namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormHasilEmisi
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblEmisiTransportasi;
        private Label lblEmisiMakanan;
        private Label lblEmisiEnergi;
        private Label lblTotalEmisi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblEmisiTransportasi = new Label();
            lblEmisiMakanan = new Label();
            lblEmisiEnergi = new Label();
            lblTotalEmisi = new Label();
            SuspendLayout();
            // 
            // lblEmisiTransportasi
            // 
            lblEmisiTransportasi.AutoSize = true;
            lblEmisiTransportasi.Location = new Point(16, 20);
            lblEmisiTransportasi.Margin = new Padding(4, 0, 4, 0);
            lblEmisiTransportasi.Name = "lblEmisiTransportasi";
            lblEmisiTransportasi.Size = new Size(157, 25);
            lblEmisiTransportasi.TabIndex = 0;
            lblEmisiTransportasi.Text = "Emisi Transportasi:";
            // 
            // lblEmisiMakanan
            // 
            lblEmisiMakanan.AutoSize = true;
            lblEmisiMakanan.Location = new Point(16, 62);
            lblEmisiMakanan.Margin = new Padding(4, 0, 4, 0);
            lblEmisiMakanan.Name = "lblEmisiMakanan";
            lblEmisiMakanan.Size = new Size(134, 25);
            lblEmisiMakanan.TabIndex = 1;
            lblEmisiMakanan.Text = "Emisi Makanan:";
            // 
            // lblEmisiEnergi
            // 
            lblEmisiEnergi.AutoSize = true;
            lblEmisiEnergi.Location = new Point(16, 105);
            lblEmisiEnergi.Margin = new Padding(4, 0, 4, 0);
            lblEmisiEnergi.Name = "lblEmisiEnergi";
            lblEmisiEnergi.Size = new Size(111, 25);
            lblEmisiEnergi.TabIndex = 2;
            lblEmisiEnergi.Text = "Emisi Energi:";
            // 
            // lblTotalEmisi
            // 
            lblTotalEmisi.AutoSize = true;
            lblTotalEmisi.Location = new Point(16, 147);
            lblTotalEmisi.Margin = new Padding(4, 0, 4, 0);
            lblTotalEmisi.Name = "lblTotalEmisi";
            lblTotalEmisi.Size = new Size(99, 25);
            lblTotalEmisi.TabIndex = 3;
            lblTotalEmisi.Text = "Total Emisi:";
            // 
            // FormHasilEmisi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 189);
            Controls.Add(lblTotalEmisi);
            Controls.Add(lblEmisiEnergi);
            Controls.Add(lblEmisiMakanan);
            Controls.Add(lblEmisiTransportasi);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHasilEmisi";
            Text = "Hasil Emisi";
            Load += FormHasilEmisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
