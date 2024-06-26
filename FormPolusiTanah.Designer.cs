namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormPolusiTanah
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMassaKontaminan;
        private System.Windows.Forms.TextBox txtMassaTanah;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblMassaKontaminan;
        private System.Windows.Forms.Label lblMassaTanah;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolusiTanah));
            lblMassaKontaminan = new Label();
            txtMassaKontaminan = new TextBox();
            lblMassaTanah = new Label();
            txtMassaTanah = new TextBox();
            btnHitung = new Button();
            txtHasil = new TextBox();
            btnBack = new Button();
            btnRefresh = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblMassaKontaminan
            // 
            lblMassaKontaminan.AutoSize = true;
            lblMassaKontaminan.BackColor = Color.Silver;
            lblMassaKontaminan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMassaKontaminan.Location = new Point(20, 25);
            lblMassaKontaminan.Name = "lblMassaKontaminan";
            lblMassaKontaminan.Size = new Size(186, 20);
            lblMassaKontaminan.TabIndex = 0;
            lblMassaKontaminan.Text = "Massa Kontaminan (mg):";
            // 
            // txtMassaKontaminan
            // 
            txtMassaKontaminan.BackColor = Color.Tan;
            txtMassaKontaminan.Location = new Point(212, 25);
            txtMassaKontaminan.Margin = new Padding(3, 4, 3, 4);
            txtMassaKontaminan.Multiline = true;
            txtMassaKontaminan.Name = "txtMassaKontaminan";
            txtMassaKontaminan.Size = new Size(100, 27);
            txtMassaKontaminan.TabIndex = 1;
            // 
            // lblMassaTanah
            // 
            lblMassaTanah.AutoSize = true;
            lblMassaTanah.BackColor = Color.Silver;
            lblMassaTanah.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMassaTanah.Location = new Point(20, 75);
            lblMassaTanah.Name = "lblMassaTanah";
            lblMassaTanah.Size = new Size(153, 23);
            lblMassaTanah.TabIndex = 2;
            lblMassaTanah.Text = "Massa Tanah (kg):";
            // 
            // txtMassaTanah
            // 
            txtMassaTanah.BackColor = Color.Tan;
            txtMassaTanah.Location = new Point(212, 75);
            txtMassaTanah.Margin = new Padding(3, 4, 3, 4);
            txtMassaTanah.Multiline = true;
            txtMassaTanah.Name = "txtMassaTanah";
            txtMassaTanah.Size = new Size(100, 27);
            txtMassaTanah.TabIndex = 3;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.LimeGreen;
            btnHitung.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(20, 115);
            btnHitung.Margin = new Padding(3, 4, 3, 4);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(77, 29);
            btnHitung.TabIndex = 4;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += BtnHitung_Click;
            // 
            // txtHasil
            // 
            txtHasil.BackColor = Color.BurlyWood;
            txtHasil.Location = new Point(20, 152);
            txtHasil.Margin = new Padding(3, 4, 3, 4);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(280, 79);
            txtHasil.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SandyBrown;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(555, 705);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Kembali Ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGray;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(215, 115);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SandyBrown;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(674, 293);
            textBox1.TabIndex = 8;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormPolusiTanah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(736, 758);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(txtHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtMassaTanah);
            Controls.Add(lblMassaTanah);
            Controls.Add(txtMassaKontaminan);
            Controls.Add(lblMassaKontaminan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPolusiTanah";
            Text = "Konsentrasi Kontaminan dalam Tanah";
            Load += FormPolusiTanah_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
        private Button btnRefresh;
        private TextBox textBox1;
    }
}