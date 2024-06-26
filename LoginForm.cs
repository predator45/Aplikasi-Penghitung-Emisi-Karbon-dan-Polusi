using System;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Emisi_Karbon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from text boxes
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Validate user credentials
            if (IsValidUser(username, password))
            {
                // If login is successful, proceed to the main application
                FormMenu mainForm = new FormMenu();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // If login fails, show an error message
                MessageBox.Show("Username atau password salah. Silakan coba lagi.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Simple validation logic
            // You can replace this with logic appropriate for your application
            return username == "admin" && password == "admin123";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Ensures the form is properly set up when loaded
            this.DialogResult = DialogResult.Cancel;
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            var formRegister = new FormRegister();
            formRegister.ShowDialog();
            this.Hide();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
