using System;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormMakanan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDagingSapi;
        private System.Windows.Forms.TextBox textBoxDagingBabi;
        private System.Windows.Forms.TextBox textBoxAyam;
        private System.Windows.Forms.TextBox textBoxSusu;
        private System.Windows.Forms.TextBox textBoxTelur;
        private System.Windows.Forms.TextBox textBoxSayuran;
        private System.Windows.Forms.TextBox textBoxBuah;
        private System.Windows.Forms.Button buttonHitungMakanan;
        private System.Windows.Forms.Label labelHasilMakanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMakanan));
            textBoxDagingSapi = new TextBox();
            textBoxDagingBabi = new TextBox();
            textBoxAyam = new TextBox();
            textBoxSusu = new TextBox();
            textBoxTelur = new TextBox();
            textBoxSayuran = new TextBox();
            textBoxBuah = new TextBox();
            buttonHitungMakanan = new Button();
            labelHasilMakanan = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            btnRefresh = new Button();
            btnBack = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxDagingSapi
            // 
            textBoxDagingSapi.BackColor = SystemColors.InactiveCaption;
            textBoxDagingSapi.Location = new Point(200, 20);
            textBoxDagingSapi.Name = "textBoxDagingSapi";
            textBoxDagingSapi.Size = new Size(100, 27);
            textBoxDagingSapi.TabIndex = 0;
            // 
            // textBoxDagingBabi
            // 
            textBoxDagingBabi.BackColor = SystemColors.InactiveCaption;
            textBoxDagingBabi.Location = new Point(200, 60);
            textBoxDagingBabi.Name = "textBoxDagingBabi";
            textBoxDagingBabi.Size = new Size(100, 27);
            textBoxDagingBabi.TabIndex = 1;
            // 
            // textBoxAyam
            // 
            textBoxAyam.BackColor = SystemColors.InactiveCaption;
            textBoxAyam.Location = new Point(200, 100);
            textBoxAyam.Name = "textBoxAyam";
            textBoxAyam.Size = new Size(100, 27);
            textBoxAyam.TabIndex = 2;
            // 
            // textBoxSusu
            // 
            textBoxSusu.BackColor = SystemColors.InactiveCaption;
            textBoxSusu.Location = new Point(200, 140);
            textBoxSusu.Name = "textBoxSusu";
            textBoxSusu.Size = new Size(100, 27);
            textBoxSusu.TabIndex = 3;
            // 
            // textBoxTelur
            // 
            textBoxTelur.BackColor = SystemColors.InactiveCaption;
            textBoxTelur.Location = new Point(200, 180);
            textBoxTelur.Name = "textBoxTelur";
            textBoxTelur.Size = new Size(100, 27);
            textBoxTelur.TabIndex = 4;
            // 
            // textBoxSayuran
            // 
            textBoxSayuran.BackColor = SystemColors.InactiveCaption;
            textBoxSayuran.Location = new Point(200, 220);
            textBoxSayuran.Name = "textBoxSayuran";
            textBoxSayuran.Size = new Size(100, 27);
            textBoxSayuran.TabIndex = 5;
            // 
            // textBoxBuah
            // 
            textBoxBuah.BackColor = SystemColors.InactiveCaption;
            textBoxBuah.Location = new Point(200, 260);
            textBoxBuah.Name = "textBoxBuah";
            textBoxBuah.Size = new Size(100, 27);
            textBoxBuah.TabIndex = 6;
            // 
            // buttonHitungMakanan
            // 
            buttonHitungMakanan.BackColor = Color.LimeGreen;
            buttonHitungMakanan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHitungMakanan.Location = new Point(34, 306);
            buttonHitungMakanan.Name = "buttonHitungMakanan";
            buttonHitungMakanan.Size = new Size(130, 34);
            buttonHitungMakanan.TabIndex = 7;
            buttonHitungMakanan.Text = "Hitung Emisi Makanan";
            buttonHitungMakanan.UseVisualStyleBackColor = false;
            buttonHitungMakanan.Click += buttonHitungMakanan_Click;
            // 
            // labelHasilMakanan
            // 
            labelHasilMakanan.BackColor = Color.Transparent;
            labelHasilMakanan.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHasilMakanan.Location = new Point(12, 353);
            labelHasilMakanan.Name = "labelHasilMakanan";
            labelHasilMakanan.Size = new Size(250, 40);
            labelHasilMakanan.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 9;
            label1.Text = "Daging Sapi (kg/tahun):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 10;
            label2.Text = "Daging Babi (kg/tahun):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 11;
            label3.Text = "Ayam (kg/tahun):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 140);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 12;
            label4.Text = "Susu (liter/tahun):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 180);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 13;
            label5.Text = "Telur (butir/tahun):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 222);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 14;
            label6.Text = "Sayuran (kg/tahun):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 265);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 15;
            label7.Text = "Buah (kg/tahun):";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 447);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LimeGreen;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(210, 306);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(79, 34);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSeaGreen;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(308, 463);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 39);
            btnBack.TabIndex = 18;
            btnBack.Text = "Kembali Ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(916, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(910, 531);
            textBox1.TabIndex = 19;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMakanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1830, 782);
            Controls.Add(textBox1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHasilMakanan);
            Controls.Add(buttonHitungMakanan);
            Controls.Add(textBoxBuah);
            Controls.Add(textBoxSayuran);
            Controls.Add(textBoxTelur);
            Controls.Add(textBoxSusu);
            Controls.Add(textBoxAyam);
            Controls.Add(textBoxDagingBabi);
            Controls.Add(textBoxDagingSapi);
            Name = "FormMakanan";
            Text = "Form Makanan";
            Load += FormMakanan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        
        private Button btnRefresh;
        private Button btnBack;
        private TextBox textBox1;
    }
}

