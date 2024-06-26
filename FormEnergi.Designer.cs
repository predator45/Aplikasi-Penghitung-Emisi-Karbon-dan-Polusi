using System;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormEnergi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxListrik;
        private System.Windows.Forms.TextBox textBoxGas;
        private System.Windows.Forms.Button buttonHitungEnergi;
        private System.Windows.Forms.Label labelHasilEnergi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnergi));
            textBoxListrik = new TextBox();
            textBoxGas = new TextBox();
            buttonHitungEnergi = new Button();
            labelHasilEnergi = new Label();
            label1 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            btnBack = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxListrik
            // 
            textBoxListrik.BackColor = Color.LightGray;
            textBoxListrik.Location = new Point(200, 20);
            textBoxListrik.Multiline = true;
            textBoxListrik.Name = "textBoxListrik";
            textBoxListrik.Size = new Size(100, 27);
            textBoxListrik.TabIndex = 0;
            // 
            // textBoxGas
            // 
            textBoxGas.BackColor = Color.LightGray;
            textBoxGas.Location = new Point(200, 60);
            textBoxGas.Multiline = true;
            textBoxGas.Name = "textBoxGas";
            textBoxGas.Size = new Size(100, 27);
            textBoxGas.TabIndex = 1;
            // 
            // buttonHitungEnergi
            // 
            buttonHitungEnergi.BackColor = Color.CornflowerBlue;
            buttonHitungEnergi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHitungEnergi.Location = new Point(20, 86);
            buttonHitungEnergi.Name = "buttonHitungEnergi";
            buttonHitungEnergi.Size = new Size(129, 32);
            buttonHitungEnergi.TabIndex = 2;
            buttonHitungEnergi.Text = "Hitung Emisi Energi";
            buttonHitungEnergi.UseVisualStyleBackColor = false;
            buttonHitungEnergi.Click += buttonHitungEnergi_Click;
            // 
            // labelHasilEnergi
            // 
            labelHasilEnergi.BackColor = Color.LightGray;
            labelHasilEnergi.Location = new Point(20, 121);
            labelHasilEnergi.Name = "labelHasilEnergi";
            labelHasilEnergi.Size = new Size(280, 40);
            labelHasilEnergi.TabIndex = 3;
            labelHasilEnergi.Click += labelHasilEnergi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 4;
            label1.Text = "Listrik (kWh/bulan):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 63);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 5;
            label2.Text = "Gas (kg/bulan):";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(206, 89);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(588, 824);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(152, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Kembali Ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 164);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(728, 654);
            textBox1.TabIndex = 8;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormEnergi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 862);
            Controls.Add(textBox1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHasilEnergi);
            Controls.Add(buttonHitungEnergi);
            Controls.Add(textBoxGas);
            Controls.Add(textBoxListrik);
            Name = "FormEnergi";
            Text = "Hitung Emisi Energi";
            Load += FormEnergi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnHitungEnergi;
        private Button btnRefresh;
        private Button btnBack;
        private TextBox textBox1;
    }
}
