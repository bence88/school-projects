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
    public partial class MainForm : Form
    {
        private IUPVTubeService service;

        public MainForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LogInForm(service).Show();
            this.Hide();
        }

        private void btnUploadContent_Click(object sender, EventArgs e)
        {
            new UploadNewContentForm(service).Show();
            this.Hide();
        }

        private void btnSearchContent_Click(object sender, EventArgs e)
        {
            new SearchContentForm(service).Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPendingContent_Click(object sender, EventArgs e)
        {
            try
            {
                new PendingContentForm(service).Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Permission denied: {exception.Message}");
            }
        }
    }
}
