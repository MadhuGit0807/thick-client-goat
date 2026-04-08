using System;
using System.Drawing;
using System.Windows.Forms;

namespace VulnThickClient1
{
    public class Form1 : Form
    {
        TextBox txtUser;
        TextBox txtPass;
        Button btnLogin;
        Label lblResult;

        public Form1()
        {
            this.Text = "Login";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Username
            txtUser = new TextBox();
            txtUser.Location = new Point(120, 40);
            txtUser.Width = 150;

            // Password
            txtPass = new TextBox();
            txtPass.Location = new Point(120, 80);
            txtPass.Width = 150;
            txtPass.PasswordChar = '*';

            // Login Button
            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(140, 120);
            btnLogin.Click += BtnLogin_Click;

            // Result Label
            lblResult = new Label();
            lblResult.Location = new Point(140, 160);
            lblResult.ForeColor = Color.Red;

            // Add controls
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Controls.Add(lblResult);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (username == "admin" && password == "admin123")
            {
                Dashboard dash = new Dashboard(username);
                dash.Show();
                this.Hide();
            }
            else
            {
                lblResult.Text = "Login Failed";
            }
        }
    }
}
