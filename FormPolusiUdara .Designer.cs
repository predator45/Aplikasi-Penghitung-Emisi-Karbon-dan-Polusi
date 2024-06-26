
namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormPolusiUdara
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMassaPartikel;
        private System.Windows.Forms.TextBox txtVolumeUdara;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblMassaPartikel;
        private System.Windows.Forms.Label lblVolumeUdara;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolusiUdara));
            lblMassaPartikel = new Label();
            txtMassaPartikel = new TextBox();
            lblVolumeUdara = new Label();
            txtVolumeUdara = new TextBox();
            btnHitung = new Button();
            txtHasil = new TextBox();
            btnBack = new Button();
            btnRefresh = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMassaPartikel
            // 
            lblMassaPartikel.AutoSize = true;
            lblMassaPartikel.BackColor = Color.Transparent;
            lblMassaPartikel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMassaPartikel.Location = new Point(20, 25);
            lblMassaPartikel.Name = "lblMassaPartikel";
            lblMassaPartikel.Size = new Size(168, 23);
            lblMassaPartikel.TabIndex = 0;
            lblMassaPartikel.Text = "Massa Partikel (µg):";
            // 
            // txtMassaPartikel
            // 
            txtMassaPartikel.BackColor = SystemColors.ActiveCaption;
            txtMassaPartikel.Location = new Point(206, 24);
            txtMassaPartikel.Margin = new Padding(3, 4, 3, 4);
            txtMassaPartikel.Multiline = true;
            txtMassaPartikel.Name = "txtMassaPartikel";
            txtMassaPartikel.Size = new Size(100, 27);
            txtMassaPartikel.TabIndex = 1;
            // 
            // lblVolumeUdara
            // 
            lblVolumeUdara.AutoSize = true;
            lblVolumeUdara.BackColor = Color.Transparent;
            lblVolumeUdara.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolumeUdara.Location = new Point(27, 75);
            lblVolumeUdara.Name = "lblVolumeUdara";
            lblVolumeUdara.Size = new Size(161, 19);
            lblVolumeUdara.TabIndex = 2;
            lblVolumeUdara.Text = "Volume Udara (m³):";
            // 
            // txtVolumeUdara
            // 
            txtVolumeUdara.BackColor = SystemColors.ActiveCaption;
            txtVolumeUdara.Location = new Point(206, 75);
            txtVolumeUdara.Margin = new Padding(3, 4, 3, 4);
            txtVolumeUdara.Multiline = true;
            txtVolumeUdara.Name = "txtVolumeUdara";
            txtVolumeUdara.Size = new Size(100, 27);
            txtVolumeUdara.TabIndex = 3;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.DimGray;
            btnHitung.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(70, 125);
            btnHitung.Margin = new Padding(3, 4, 3, 4);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(88, 38);
            btnHitung.TabIndex = 4;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += BtnHitung_Click;
            // 
            // txtHasil
            // 
            txtHasil.BackColor = SystemColors.ActiveCaption;
            txtHasil.Location = new Point(27, 171);
            txtHasil.Margin = new Padding(3, 4, 3, 4);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(361, 107);
            txtHasil.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(724, 699);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Kembali ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveCaption;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(206, 130);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuHighlight;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 369);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(875, 324);
            textBox1.TabIndex = 8;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(455, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 364);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormPolusiUdara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(906, 740);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(txtHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtVolumeUdara);
            Controls.Add(lblVolumeUdara);
            Controls.Add(txtMassaPartikel);
            Controls.Add(lblMassaPartikel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPolusiUdara";
            Text = "Konsentrasi Partikulat (PM10, PM2.5)";
            Load += FormPolusiUdara_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMassaPartikel.Text = "";
            txtVolumeUdara.Text = "";
            txtHasil.Text = "";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
           var formMenu = new FormMenu();   
            formMenu.ShowDialog();
            this.Close();
        }

        private void FormPolusiUdara_Load(object sender, EventArgs e)
        {
           
        }

        private Button btnBack;
        private Button btnRefresh;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
