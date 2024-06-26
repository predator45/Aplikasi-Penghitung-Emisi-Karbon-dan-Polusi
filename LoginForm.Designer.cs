namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class LoginForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            label1 = new Label();
            Register = new Button();
            labelUsername = new Label();
            labelPassword = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUsername.BackColor = SystemColors.ActiveBorder;
            textBoxUsername.Location = new Point(49, 144);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(203, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPassword.BackColor = SystemColors.AppWorkspace;
            textBoxPassword.Location = new Point(49, 199);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(203, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogin.BackColor = Color.DarkGray;
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(49, 232);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(76, 31);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(138, 34);
            label1.Name = "label1";
            label1.Size = new Size(466, 60);
            label1.TabIndex = 4;
            label1.Text = "Aplikasi ini Menyediakan Fitur untuk Menghitung Emisi Karbon,\r\nAnda dapat bergabung dengan Login jika ingin mendapatkan\r\n informasi terbaru tentang CO2  di sekitar kita";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Register
            // 
            Register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Register.BackColor = SystemColors.AppWorkspace;
            Register.ForeColor = Color.Black;
            Register.Location = new Point(170, 232);
            Register.Name = "Register";
            Register.Size = new Size(82, 31);
            Register.TabIndex = 5;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelUsername.BackColor = Color.Gray;
            labelUsername.ForeColor = SystemColors.ActiveCaptionText;
            labelUsername.Location = new Point(103, 109);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(97, 32);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username:";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            labelUsername.Click += labelUsername_Click;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelPassword.BackColor = Color.DimGray;
            labelPassword.ForeColor = SystemColors.ActiveCaptionText;
            labelPassword.Location = new Point(103, 174);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 22);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Register);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(textBoxPassword);
            panel1.Location = new Point(206, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 282);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(103, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 102);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            BackColor = Color.MediumSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(706, 539);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkSlateGray;
            Name = "LoginForm";
            Text = "Login";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label label1;
        private Button Register;
        private Label labelUsername;
        private Label labelPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
