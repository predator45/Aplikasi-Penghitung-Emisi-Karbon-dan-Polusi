namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormTotalEmisi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTransportasi;
        private System.Windows.Forms.Label labelEnergi;
        private System.Windows.Forms.Label labelMakanan;
        private System.Windows.Forms.TextBox textBoxTransportasi;
        private System.Windows.Forms.TextBox textBoxEnergi;
        private System.Windows.Forms.TextBox textBoxMakanan;
        private System.Windows.Forms.Button buttonHitungTotal;
        private System.Windows.Forms.Label labelHasilTotal;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTotalEmisi));
            labelTransportasi = new Label();
            labelEnergi = new Label();
            labelMakanan = new Label();
            textBoxTransportasi = new TextBox();
            textBoxEnergi = new TextBox();
            textBoxMakanan = new TextBox();
            buttonHitungTotal = new Button();
            labelHasilTotal = new Label();
            btnBack = new Button();
            btnRefresh = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelTransportasi
            // 
            labelTransportasi.AutoSize = true;
            labelTransportasi.BackColor = Color.Transparent;
            labelTransportasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTransportasi.Location = new Point(20, 20);
            labelTransportasi.Name = "labelTransportasi";
            labelTransportasi.Size = new Size(174, 20);
            labelTransportasi.TabIndex = 0;
            labelTransportasi.Text = "Emisi Transportasi (kg):";
            // 
            // labelEnergi
            // 
            labelEnergi.AutoSize = true;
            labelEnergi.BackColor = Color.Transparent;
            labelEnergi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnergi.Location = new Point(20, 60);
            labelEnergi.Name = "labelEnergi";
            labelEnergi.Size = new Size(131, 20);
            labelEnergi.TabIndex = 1;
            labelEnergi.Text = "Emisi Energi (kg):";
            // 
            // labelMakanan
            // 
            labelMakanan.AutoSize = true;
            labelMakanan.BackColor = Color.Transparent;
            labelMakanan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMakanan.Location = new Point(20, 100);
            labelMakanan.Name = "labelMakanan";
            labelMakanan.Size = new Size(151, 20);
            labelMakanan.TabIndex = 2;
            labelMakanan.Text = "Emisi Makanan (kg):";
            labelMakanan.Click += labelMakanan_Click;
            // 
            // textBoxTransportasi
            // 
            textBoxTransportasi.BackColor = Color.LightGray;
            textBoxTransportasi.Location = new Point(200, 17);
            textBoxTransportasi.Name = "textBoxTransportasi";
            textBoxTransportasi.Size = new Size(100, 27);
            textBoxTransportasi.TabIndex = 3;
            // 
            // textBoxEnergi
            // 
            textBoxEnergi.BackColor = Color.LightGray;
            textBoxEnergi.Location = new Point(200, 57);
            textBoxEnergi.Name = "textBoxEnergi";
            textBoxEnergi.Size = new Size(100, 27);
            textBoxEnergi.TabIndex = 4;
            // 
            // textBoxMakanan
            // 
            textBoxMakanan.BackColor = Color.LightGray;
            textBoxMakanan.Location = new Point(200, 97);
            textBoxMakanan.Name = "textBoxMakanan";
            textBoxMakanan.Size = new Size(100, 27);
            textBoxMakanan.TabIndex = 5;
            // 
            // buttonHitungTotal
            // 
            buttonHitungTotal.BackColor = SystemColors.InactiveCaption;
            buttonHitungTotal.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonHitungTotal.Location = new Point(12, 132);
            buttonHitungTotal.Name = "buttonHitungTotal";
            buttonHitungTotal.Size = new Size(166, 29);
            buttonHitungTotal.TabIndex = 6;
            buttonHitungTotal.Text = "Hitung Total Emisi";
            buttonHitungTotal.UseVisualStyleBackColor = false;
            buttonHitungTotal.Click += buttonHitungTotal_Click;
            // 
            // labelHasilTotal
            // 
            labelHasilTotal.BackColor = Color.Transparent;
            labelHasilTotal.ForeColor = Color.DarkGray;
            labelHasilTotal.Location = new Point(12, 173);
            labelHasilTotal.Name = "labelHasilTotal";
            labelHasilTotal.Size = new Size(280, 40);
            labelHasilTotal.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(583, 600);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(161, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Kembali ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(206, 132);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 227);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(738, 367);
            textBox1.TabIndex = 10;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormTotalEmisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(756, 650);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(labelHasilTotal);
            Controls.Add(buttonHitungTotal);
            Controls.Add(textBoxMakanan);
            Controls.Add(textBoxEnergi);
            Controls.Add(textBoxTransportasi);
            Controls.Add(labelMakanan);
            Controls.Add(labelEnergi);
            Controls.Add(labelTransportasi);
            Name = "FormTotalEmisi";
            Text = "FormTotalEmisi";
            Load += FormTotalEmisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
        private Button btnRefresh;
        private TextBox textBox1;
    }
}
