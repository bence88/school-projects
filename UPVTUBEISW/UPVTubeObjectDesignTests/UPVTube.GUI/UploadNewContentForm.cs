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
using UPVTube.GUI;
using UPVTube.Entities;

namespace UPVTube.GUI
{
    public partial class UploadNewContentForm : Form
    {
        private IUPVTubeService service;
        public UploadNewContentForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;            
        }
        

        private void linkBackToMain_Click(object sender, EventArgs e)
        {
            new MainForm(service).Show();
            this.Hide();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string URI = txtURI.Text;
                bool publicStatus = checkPublicStatus.Checked;
                Member member = service.GetLoggedInMember();
                if (txtCodeBox.Text != "" && txtSubjectbox.Text != "")
                {
                    if (int.TryParse(txtCodeBox.Text, out int subjectCode))
                    {
                        if(subjectCode >= 0)
                        {
                            service.UploadNewContent(member, URI, description, publicStatus, title, txtSubjectbox.Text, subjectCode);
                            MessageBox.Show("Content is uploaded successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Upload of content failed: the Subject Number must be positive");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show($"Upload of content failed:Invalid input string");
                    }
                }
                else
                {
                    service.UploadNewContent(member, URI, description, publicStatus, title, null, -1);
                    MessageBox.Show("Content is uploaded successfully!");
                }
                
                new MainForm(service).Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Upload of content failed: {exception.Message}");
            }
        }

        private void txtSubjectsbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}