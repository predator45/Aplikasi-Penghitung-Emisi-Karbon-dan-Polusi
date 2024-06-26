namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormTransportasi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonHitungTransportasi;
        private System.Windows.Forms.TextBox textBoxMobil;
        private System.Windows.Forms.TextBox textBoxMotor;
        private System.Windows.Forms.TextBox textBoxPesawat;
        private System.Windows.Forms.TextBox textBoxKeretaApi;
        private System.Windows.Forms.TextBox textBoxBus;
        private System.Windows.Forms.Label labelHasilTransportasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransportasi));
            buttonHitungTransportasi = new Button();
            textBoxMobil = new TextBox();
            textBoxMotor = new TextBox();
            textBoxPesawat = new TextBox();
            textBoxKeretaApi = new TextBox();
            textBoxBus = new TextBox();
            labelHasilTransportasi = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRefresh = new Button();
            btnBack = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // buttonHitungTransportasi
            // 
            buttonHitungTransportasi.BackColor = Color.LightGray;
            buttonHitungTransportasi.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHitungTransportasi.Location = new Point(45, 240);
            buttonHitungTransportasi.Name = "buttonHitungTransportasi";
            buttonHitungTransportasi.Size = new Size(151, 33);
            buttonHitungTransportasi.TabIndex = 0;
            buttonHitungTransportasi.Text = "Hitung Emisi Transportasi";
            buttonHitungTransportasi.UseVisualStyleBackColor = false;
            buttonHitungTransportasi.Click += buttonHitungTransportasi_Click;
            // 
            // textBoxMobil
            // 
            textBoxMobil.BackColor = SystemColors.InactiveCaption;
            textBoxMobil.Location = new Point(224, 30);
            textBoxMobil.Multiline = true;
            textBoxMobil.Name = "textBoxMobil";
            textBoxMobil.Size = new Size(100, 27);
            textBoxMobil.TabIndex = 1;
            textBoxMobil.TextChanged += textBoxMobil_TextChanged;
            // 
            // textBoxMotor
            // 
            textBoxMotor.BackColor = SystemColors.InactiveCaption;
            textBoxMotor.Location = new Point(224, 70);
            textBoxMotor.Multiline = true;
            textBoxMotor.Name = "textBoxMotor";
            textBoxMotor.Size = new Size(100, 27);
            textBoxMotor.TabIndex = 2;
            // 
            // textBoxPesawat
            // 
            textBoxPesawat.BackColor = SystemColors.InactiveCaption;
            textBoxPesawat.Location = new Point(224, 110);
            textBoxPesawat.Multiline = true;
            textBoxPesawat.Name = "textBoxPesawat";
            textBoxPesawat.Size = new Size(100, 27);
            textBoxPesawat.TabIndex = 3;
            // 
            // textBoxKeretaApi
            // 
            textBoxKeretaApi.BackColor = SystemColors.InactiveCaption;
            textBoxKeretaApi.Location = new Point(224, 150);
            textBoxKeretaApi.Multiline = true;
            textBoxKeretaApi.Name = "textBoxKeretaApi";
            textBoxKeretaApi.Size = new Size(100, 27);
            textBoxKeretaApi.TabIndex = 4;
            // 
            // textBoxBus
            // 
            textBoxBus.BackColor = SystemColors.InactiveCaption;
            textBoxBus.Location = new Point(224, 190);
            textBoxBus.Multiline = true;
            textBoxBus.Name = "textBoxBus";
            textBoxBus.Size = new Size(100, 27);
            textBoxBus.TabIndex = 5;
            // 
            // labelHasilTransportasi
            // 
            labelHasilTransportasi.AutoSize = true;
            labelHasilTransportasi.BackColor = Color.DarkGray;
            labelHasilTransportasi.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHasilTransportasi.Location = new Point(50, 287);
            labelHasilTransportasi.Name = "labelHasilTransportasi";
            labelHasilTransportasi.Size = new Size(74, 20);
            labelHasilTransportasi.TabIndex = 6;
            labelHasilTransportasi.Text = "0 kg CO2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 7;
            label1.Text = "Mobil Km/Tahun:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 70);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 8;
            label2.Text = "Motor Km/Tahun:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 110);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 9;
            label3.Text = "Pesawat Km/Tahun:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 150);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 10;
            label4.Text = "Kereta Api Km/Tahun:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 190);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 11;
            label5.Text = "Bus Km/Tahun:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 125);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Silver;
            btnRefresh.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(234, 240);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 33);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(694, 812);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Kembali ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(330, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 454);
            textBox1.TabIndex = 15;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(2, 472);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(831, 334);
            textBox2.TabIndex = 16;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // FormTransportasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 846);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHasilTransportasi);
            Controls.Add(textBoxBus);
            Controls.Add(textBoxKeretaApi);
            Controls.Add(textBoxPesawat);
            Controls.Add(textBoxMotor);
            Controls.Add(textBoxMobil);
            Controls.Add(buttonHitungTransportasi);
            DoubleBuffered = true;
            Name = "FormTransportasi";
            Text = "Penghitung Emisi Transportasi";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label6;
        private Button btnRefresh;
        private Button btnBack;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
