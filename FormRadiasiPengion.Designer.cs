namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormRadiasiPengion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKonsentrasiRadiasi;
        private System.Windows.Forms.TextBox txtFaktorKualitasRadiasi;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblKonsentrasiRadiasi;
        private System.Windows.Forms.Label lblFaktorKualitasRadiasi;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadiasiPengion));
            lblKonsentrasiRadiasi = new Label();
            txtKonsentrasiRadiasi = new TextBox();
            lblFaktorKualitasRadiasi = new Label();
            txtFaktorKualitasRadiasi = new TextBox();
            btnHitung = new Button();
            txtHasil = new TextBox();
            btnBack = new Button();
            btnRefresh = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblKonsentrasiRadiasi
            // 
            lblKonsentrasiRadiasi.AutoSize = true;
            lblKonsentrasiRadiasi.BackColor = Color.LightGray;
            lblKonsentrasiRadiasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKonsentrasiRadiasi.ForeColor = SystemColors.ControlText;
            lblKonsentrasiRadiasi.Location = new Point(20, 25);
            lblKonsentrasiRadiasi.Name = "lblKonsentrasiRadiasi";
            lblKonsentrasiRadiasi.Size = new Size(185, 20);
            lblKonsentrasiRadiasi.TabIndex = 0;
            lblKonsentrasiRadiasi.Text = "Konsentrasi Radiasi (Gy):";
            // 
            // txtKonsentrasiRadiasi
            // 
            txtKonsentrasiRadiasi.BackColor = SystemColors.InactiveCaption;
            txtKonsentrasiRadiasi.Location = new Point(220, 22);
            txtKonsentrasiRadiasi.Margin = new Padding(3, 4, 3, 4);
            txtKonsentrasiRadiasi.Name = "txtKonsentrasiRadiasi";
            txtKonsentrasiRadiasi.Size = new Size(100, 27);
            txtKonsentrasiRadiasi.TabIndex = 1;
            // 
            // lblFaktorKualitasRadiasi
            // 
            lblFaktorKualitasRadiasi.AutoSize = true;
            lblFaktorKualitasRadiasi.BackColor = Color.LightGray;
            lblFaktorKualitasRadiasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFaktorKualitasRadiasi.Location = new Point(20, 75);
            lblFaktorKualitasRadiasi.Name = "lblFaktorKualitasRadiasi";
            lblFaktorKualitasRadiasi.Size = new Size(172, 20);
            lblFaktorKualitasRadiasi.TabIndex = 2;
            lblFaktorKualitasRadiasi.Text = "Faktor Kualitas Radiasi:";
            // 
            // txtFaktorKualitasRadiasi
            // 
            txtFaktorKualitasRadiasi.BackColor = SystemColors.InactiveCaption;
            txtFaktorKualitasRadiasi.Location = new Point(220, 72);
            txtFaktorKualitasRadiasi.Margin = new Padding(3, 4, 3, 4);
            txtFaktorKualitasRadiasi.Name = "txtFaktorKualitasRadiasi";
            txtFaktorKualitasRadiasi.Size = new Size(100, 27);
            txtFaktorKualitasRadiasi.TabIndex = 3;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.Gold;
            btnHitung.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(20, 129);
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
            txtHasil.BackColor = SystemColors.ControlDark;
            txtHasil.Location = new Point(20, 175);
            txtHasil.Margin = new Padding(3, 4, 3, 4);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(280, 67);
            txtHasil.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(507, 549);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Kembali Ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGray;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(220, 129);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 34);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 249);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(642, 195);
            textBox1.TabIndex = 8;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormRadiasiPengion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(666, 590);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(txtHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtFaktorKualitasRadiasi);
            Controls.Add(lblFaktorKualitasRadiasi);
            Controls.Add(txtKonsentrasiRadiasi);
            Controls.Add(lblKonsentrasiRadiasi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRadiasiPengion";
            Text = "Dosis Radiasi Pengion";
            Load += FormRadiasiPengion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
        private Button btnRefresh;
        private TextBox textBox1;
    }
}
