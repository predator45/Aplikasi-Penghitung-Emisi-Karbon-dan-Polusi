namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormPolusiAir
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMassaBahanKimia;
        private System.Windows.Forms.TextBox txtVolumeAir;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblMassaBahanKimia;
        private System.Windows.Forms.Label lblVolumeAir;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolusiAir));
            lblMassaBahanKimia = new Label();
            txtMassaBahanKimia = new TextBox();
            lblVolumeAir = new Label();
            txtVolumeAir = new TextBox();
            btnHitung = new Button();
            txtHasil = new TextBox();
            btnBack = new Button();
            btnRefresh = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblMassaBahanKimia
            // 
            lblMassaBahanKimia.AutoSize = true;
            lblMassaBahanKimia.BackColor = SystemColors.ActiveCaption;
            lblMassaBahanKimia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMassaBahanKimia.Location = new Point(-1, 26);
            lblMassaBahanKimia.Name = "lblMassaBahanKimia";
            lblMassaBahanKimia.Size = new Size(212, 23);
            lblMassaBahanKimia.TabIndex = 0;
            lblMassaBahanKimia.Text = "Massa Bahan Kimia (mg):";
            // 
            // txtMassaBahanKimia
            // 
            txtMassaBahanKimia.BackColor = SystemColors.InactiveCaption;
            txtMassaBahanKimia.Location = new Point(217, 25);
            txtMassaBahanKimia.Margin = new Padding(3, 4, 3, 4);
            txtMassaBahanKimia.Multiline = true;
            txtMassaBahanKimia.Name = "txtMassaBahanKimia";
            txtMassaBahanKimia.Size = new Size(140, 27);
            txtMassaBahanKimia.TabIndex = 1;
            // 
            // lblVolumeAir
            // 
            lblVolumeAir.AutoSize = true;
            lblVolumeAir.BackColor = SystemColors.ActiveCaption;
            lblVolumeAir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolumeAir.Location = new Point(20, 75);
            lblVolumeAir.Name = "lblVolumeAir";
            lblVolumeAir.Size = new Size(130, 23);
            lblVolumeAir.TabIndex = 2;
            lblVolumeAir.Text = "Volume Air (L):";
            // 
            // txtVolumeAir
            // 
            txtVolumeAir.BackColor = SystemColors.InactiveCaption;
            txtVolumeAir.Location = new Point(217, 72);
            txtVolumeAir.Margin = new Padding(3, 4, 3, 4);
            txtVolumeAir.Name = "txtVolumeAir";
            txtVolumeAir.Size = new Size(140, 27);
            txtVolumeAir.TabIndex = 3;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.Lime;
            btnHitung.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(20, 125);
            btnHitung.Margin = new Padding(3, 4, 3, 4);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(100, 38);
            btnHitung.TabIndex = 4;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += BtnHitung_Click;
            // 
            // txtHasil
            // 
            txtHasil.BackColor = SystemColors.ActiveCaption;
            txtHasil.Location = new Point(20, 175);
            txtHasil.Margin = new Padding(3, 4, 3, 4);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(337, 42);
            txtHasil.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.HotTrack;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(629, 685);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Kembali Ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.RosyBrown;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(206, 134);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 224);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(775, 445);
            textBox1.TabIndex = 8;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormPolusiAir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 726);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(txtHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtVolumeAir);
            Controls.Add(lblVolumeAir);
            Controls.Add(txtMassaBahanKimia);
            Controls.Add(lblMassaBahanKimia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPolusiAir";
            Text = "Konsentrasi Bahan Kimia";
            Load += FormPolusiAir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
        private Button btnRefresh;
        private TextBox textBox1;
    }
}
