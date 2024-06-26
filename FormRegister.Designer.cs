namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            labelUsername = new Label();
            labelPassword = new Label();
            labelConfirmPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            registerButton = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(30, 38);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(80, 20);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(30, 88);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 20);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.Location = new Point(30, 141);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(137, 20);
            labelConfirmPassword.TabIndex = 2;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.InactiveCaption;
            textBoxUsername.Location = new Point(173, 38);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.InactiveCaption;
            textBoxPassword.Location = new Point(173, 88);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(200, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = SystemColors.InactiveCaption;
            textBoxConfirmPassword.Location = new Point(173, 141);
            textBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(200, 27);
            textBoxConfirmPassword.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.GradientActiveCaption;
            registerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(160, 188);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(100, 38);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(30, 188);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 38);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(502, 342);
            Controls.Add(btnBack);
            Controls.Add(registerButton);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelConfirmPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegister";
            Text = "Register:";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
