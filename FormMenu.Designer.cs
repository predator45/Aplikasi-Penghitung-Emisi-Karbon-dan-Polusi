using System.Drawing.Text;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonTransportasi = new Button();
            buttonEnergi = new Button();
            buttonMakanan = new Button();
            buttonTotalEmisi = new Button();
            buttonPolusiUdara = new Button();
            buttonPolusiAir = new Button();
            buttonPolusiTanah = new Button();
            buttonPolusiSuara = new Button();
            buttonRadiasiPengion = new Button();
            label1 = new Label();
            panel1 = new Panel();
            buttonPolusiCahaya = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonTransportasi
            // 
            buttonTransportasi.BackColor = Color.DarkGray;
            buttonTransportasi.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonTransportasi.Location = new Point(13, 18);
            buttonTransportasi.Margin = new Padding(3, 4, 3, 4);
            buttonTransportasi.Name = "buttonTransportasi";
            buttonTransportasi.Size = new Size(128, 40);
            buttonTransportasi.TabIndex = 0;
            buttonTransportasi.Text = "Transportasi";
            buttonTransportasi.UseVisualStyleBackColor = false;
            buttonTransportasi.Click += buttonTransportasi_Click;
            // 
            // buttonEnergi
            // 
            buttonEnergi.BackColor = Color.DarkGray;
            buttonEnergi.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonEnergi.Location = new Point(147, 18);
            buttonEnergi.Margin = new Padding(3, 4, 3, 4);
            buttonEnergi.Name = "buttonEnergi";
            buttonEnergi.Size = new Size(97, 40);
            buttonEnergi.TabIndex = 1;
            buttonEnergi.Text = "Energi";
            buttonEnergi.UseVisualStyleBackColor = false;
            buttonEnergi.Click += buttonEnergi_Click;
            // 
            // buttonMakanan
            // 
            buttonMakanan.BackColor = Color.DarkGray;
            buttonMakanan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonMakanan.Location = new Point(250, 17);
            buttonMakanan.Margin = new Padding(3, 4, 3, 4);
            buttonMakanan.Name = "buttonMakanan";
            buttonMakanan.Size = new Size(106, 40);
            buttonMakanan.TabIndex = 2;
            buttonMakanan.Text = "Makanan";
            buttonMakanan.UseVisualStyleBackColor = false;
            buttonMakanan.Click += buttonMakanan_Click;
            // 
            // buttonTotalEmisi
            // 
            buttonTotalEmisi.BackColor = Color.DarkGray;
            buttonTotalEmisi.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonTotalEmisi.Location = new Point(147, 77);
            buttonTotalEmisi.Margin = new Padding(3, 4, 3, 4);
            buttonTotalEmisi.Name = "buttonTotalEmisi";
            buttonTotalEmisi.Size = new Size(112, 32);
            buttonTotalEmisi.TabIndex = 3;
            buttonTotalEmisi.Text = "Total Emisi";
            buttonTotalEmisi.UseVisualStyleBackColor = false;
            buttonTotalEmisi.Click += buttonTotalEmisi_Click;
            // 
            // buttonPolusiUdara
            // 
            buttonPolusiUdara.BackColor = Color.DarkGray;
            buttonPolusiUdara.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPolusiUdara.Location = new Point(3, 12);
            buttonPolusiUdara.Name = "buttonPolusiUdara";
            buttonPolusiUdara.Size = new Size(122, 39);
            buttonPolusiUdara.TabIndex = 4;
            buttonPolusiUdara.Text = "Polusi Udara";
            buttonPolusiUdara.UseVisualStyleBackColor = false;
            buttonPolusiUdara.Click += buttonPolusiUdara_Click;
            // 
            // buttonPolusiAir
            // 
            buttonPolusiAir.BackColor = Color.DarkGray;
            buttonPolusiAir.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPolusiAir.Location = new Point(3, 103);
            buttonPolusiAir.Name = "buttonPolusiAir";
            buttonPolusiAir.Size = new Size(101, 39);
            buttonPolusiAir.TabIndex = 5;
            buttonPolusiAir.Text = "Polusi Air";
            buttonPolusiAir.UseVisualStyleBackColor = false;
            buttonPolusiAir.Click += buttonPolusiAir_Click;
            // 
            // buttonPolusiTanah
            // 
            buttonPolusiTanah.BackColor = Color.DarkGray;
            buttonPolusiTanah.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPolusiTanah.Location = new Point(158, 12);
            buttonPolusiTanah.Name = "buttonPolusiTanah";
            buttonPolusiTanah.Size = new Size(118, 39);
            buttonPolusiTanah.TabIndex = 6;
            buttonPolusiTanah.Text = "Polusi Tanah";
            buttonPolusiTanah.UseVisualStyleBackColor = false;
            buttonPolusiTanah.Click += buttonPolusiTanah_Click;
            // 
            // buttonPolusiSuara
            // 
            buttonPolusiSuara.BackColor = Color.DarkGray;
            buttonPolusiSuara.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPolusiSuara.Location = new Point(158, 58);
            buttonPolusiSuara.Name = "buttonPolusiSuara";
            buttonPolusiSuara.Size = new Size(118, 38);
            buttonPolusiSuara.TabIndex = 7;
            buttonPolusiSuara.Text = "Polusi Suara";
            buttonPolusiSuara.UseVisualStyleBackColor = false;
            buttonPolusiSuara.Click += buttonPolusiSuara_Click;
            // 
            // buttonRadiasiPengion
            // 
            buttonRadiasiPengion.BackColor = Color.DarkGray;
            buttonRadiasiPengion.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRadiasiPengion.Location = new Point(3, 58);
            buttonRadiasiPengion.Name = "buttonRadiasiPengion";
            buttonRadiasiPengion.Size = new Size(143, 39);
            buttonRadiasiPengion.TabIndex = 8;
            buttonRadiasiPengion.Text = "Radiasi Pengion";
            buttonRadiasiPengion.UseVisualStyleBackColor = false;
            buttonRadiasiPengion.Click += buttonRadiasiPengion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 21);
            label1.Name = "label1";
            label1.Size = new Size(361, 19);
            label1.TabIndex = 9;
            label1.Text = "Aplikasi Penghitung Emisi Karbon dan Polusi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonPolusiCahaya);
            panel1.Controls.Add(buttonPolusiUdara);
            panel1.Controls.Add(buttonPolusiTanah);
            panel1.Controls.Add(buttonPolusiAir);
            panel1.Controls.Add(buttonPolusiSuara);
            panel1.Controls.Add(buttonRadiasiPengion);
            panel1.Location = new Point(510, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 165);
            panel1.TabIndex = 10;
            // 
            // buttonPolusiCahaya
            // 
            buttonPolusiCahaya.BackColor = Color.DarkGray;
            buttonPolusiCahaya.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPolusiCahaya.Location = new Point(148, 113);
            buttonPolusiCahaya.Name = "buttonPolusiCahaya";
            buttonPolusiCahaya.Size = new Size(128, 29);
            buttonPolusiCahaya.TabIndex = 9;
            buttonPolusiCahaya.Text = "Polusi Cahaya";
            buttonPolusiCahaya.UseVisualStyleBackColor = false;
            buttonPolusiCahaya.Click += buttonPolusiCahaya_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(buttonTransportasi);
            panel2.Controls.Add(buttonMakanan);
            panel2.Controls.Add(buttonEnergi);
            panel2.Controls.Add(buttonTotalEmisi);
            panel2.Location = new Point(27, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 123);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 157);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 12;
            label2.Text = "Emisi Karbon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(622, 157);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 13;
            label3.Text = "Polusi";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 401);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(807, 128);
            textBox1.TabIndex = 14;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(371, 375);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 15;
            label4.Text = "About Us";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(636, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(164, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Keluar dari Aplikasi";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 578);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "Aplikasi Penghitung Emisi Karbon";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonTransportasi;
        private System.Windows.Forms.Button buttonEnergi;
        private System.Windows.Forms.Button buttonMakanan;
        private System.Windows.Forms.Button buttonTotalEmisi;
        private System.Windows.Forms.Button buttonPolusiUdara;
        private System.Windows.Forms.Button buttonPolusiAir;
        private System.Windows.Forms.Button buttonPolusiTanah;
        private System.Windows.Forms.Button buttonPolusiSuara;
        private System.Windows.Forms.Button buttonRadiasiPengion;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button buttonPolusiCahaya;
        private Button btnExit;
    }
}
