namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormPolusiSuara
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTingkatSuara;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblTingkatSuara;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolusiSuara));
            lblTingkatSuara = new Label();
            txtTingkatSuara = new TextBox();
            btnHitung = new Button();
            txtHasil = new TextBox();
            btnBack = new Button();
            btnRefresh = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblTingkatSuara
            // 
            lblTingkatSuara.AutoSize = true;
            lblTingkatSuara.BackColor = SystemColors.ActiveBorder;
            lblTingkatSuara.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTingkatSuara.Location = new Point(20, 25);
            lblTingkatSuara.Name = "lblTingkatSuara";
            lblTingkatSuara.Size = new Size(301, 20);
            lblTingkatSuara.TabIndex = 0;
            lblTingkatSuara.Text = "Tingkat Suara (dB, dipisah dengan koma):";
            // 
            // txtTingkatSuara
            // 
            txtTingkatSuara.BackColor = SystemColors.ActiveBorder;
            txtTingkatSuara.Location = new Point(327, 25);
            txtTingkatSuara.Margin = new Padding(3, 4, 3, 4);
            txtTingkatSuara.Multiline = true;
            txtTingkatSuara.Name = "txtTingkatSuara";
            txtTingkatSuara.Size = new Size(183, 27);
            txtTingkatSuara.TabIndex = 1;
            txtTingkatSuara.TextChanged += txtTingkatSuara_TextChanged;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.Salmon;
            btnHitung.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(20, 84);
            btnHitung.Margin = new Padding(3, 4, 3, 4);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(77, 29);
            btnHitung.TabIndex = 2;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += BtnHitung_Click;
            // 
            // txtHasil
            // 
            txtHasil.BackColor = SystemColors.AppWorkspace;
            txtHasil.Location = new Point(20, 125);
            txtHasil.Margin = new Padding(3, 4, 3, 4);
            txtHasil.Multiline = true;
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(370, 71);
            txtHasil.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Turquoise;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(543, 604);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Kembali ke Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Coral;
            btnRefresh.Location = new Point(210, 84);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 220);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(694, 177);
            textBox1.TabIndex = 9;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormPolusiSuara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(725, 645);
            Controls.Add(textBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(txtHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtTingkatSuara);
            Controls.Add(lblTingkatSuara);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPolusiSuara";
            Text = "Tingkat Kebisingan (dB)";
            Load += FormPolusiSuara_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
        private Button btnRefresh;
        private TextBox textBox1;
    }
}
