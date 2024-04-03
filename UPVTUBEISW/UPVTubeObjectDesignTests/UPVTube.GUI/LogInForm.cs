using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.BusinessLogic.Services;

namespace UPVTube.GUI
{
    public partial class LogInForm : Form
    {
        private IUPVTubeService service;

        public LogInForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string nick = txtNick.Text;
                string password = txtPassword.Text;

                service.LogIn(nick, password);

                MessageBox.Show("Login successful!");
                new MainForm(service).Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
        }

        private void linkCreateAccount_Click(object sender, EventArgs e)
        {
            new RegisterUserForm(service).Show();
            this.Hide();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}