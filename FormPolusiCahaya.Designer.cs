namespace Aplikasi_Penghitung_Emisi_Karbon
{
    partial class FormPolusiCahaya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolusiCahaya));
            luminanceLabel = new Label();
            luminanceTextBox = new TextBox();
            calculateButton = new Button();
            resultLabel = new Label();
            btnRefresh = new Button();
            btnBack = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // luminanceLabel
            // 
            luminanceLabel.AutoSize = true;
            luminanceLabel.BackColor = SystemColors.InactiveCaption;
            luminanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            luminanceLabel.Location = new Point(20, 20);
            luminanceLabel.Name = "luminanceLabel";
            luminanceLabel.Size = new Size(192, 20);
            luminanceLabel.TabIndex = 0;
            luminanceLabel.Text = "Luminance (mag/arcsec²):";
            // 
            // luminanceTextBox
            // 
            luminanceTextBox.BackColor = SystemColors.InactiveCaption;
            luminanceTextBox.Location = new Point(229, 20);
            luminanceTextBox.Multiline = true;
            luminanceTextBox.Name = "luminanceTextBox";
            luminanceTextBox.Size = new Size(109, 29);
            luminanceTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateButton.Location = new Point(20, 60);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(90, 37);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Hitung";
            calculateButton.Click += calculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = SystemColors.MenuBar;
            resultLabel.Location = new Point(20, 100);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(147, 20);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Light Pollution Index:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(157, 60);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 37);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.InactiveCaption;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(611, 510);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(156, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Kembali ke Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 155);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(755, 349);
            textBox1.TabIndex = 6;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormPolusiCahaya
            // 
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(779, 556);
            Controls.Add(textBox1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(luminanceLabel);
            Controls.Add(luminanceTextBox);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Name = "FormPolusiCahaya";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Light Pollution Calculator";
            Load += FormPolusiCahaya_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox luminanceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private Label luminanceLabel;
        private Button btnRefresh;
        private Button btnBack;
        private TextBox textBox1;
    }
}
