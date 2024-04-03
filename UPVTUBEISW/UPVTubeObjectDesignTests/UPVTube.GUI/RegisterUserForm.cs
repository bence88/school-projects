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
    public partial class RegisterUserForm : Form
    {
        private IUPVTubeService service;

        public RegisterUserForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text;
                string email = txtEmail.Text;
                string nick = txtNick.Text;
                string password = txtPassword.Text;

                service.RegisterNewUser(email, fullName, DateTime.Now, nick, password);
                MessageBox.Show("User registered successfully!");
                new LogInForm(service).Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Registration failed: {exception.Message}");
            }
        }

        private void linkBackToLogin_Click(object sender, EventArgs e)
        {
            new LogInForm(service).Show();
            this.Hide();
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}

