using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.BusinessLogic.Services;
using UPVTube.Entities;

namespace UPVTube.GUI
{
    public partial class PendingContentForm : Form
    {
        private IUPVTubeService service;
        private List<Content> pendingContents;
        private Content markedContent;

        public PendingContentForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            Member member = service.GetLoggedInMember();
            pendingContents = service.GetAllPendingContents(member);

            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Content c in pendingContents)
            {

                string subjectNames = "";
                foreach (Subject s in c.Subjects)
                {
                    subjectNames += s.Name + ", ";
                }
                bindinglist.Add(new { 
                    ds_Title = c.Title,
                    ds_UploadDate = c.UploadDate,
                    ds_Owner = c.Owner.FullName,
                    ds_Subjects = subjectNames,
                    ds_Description = c.Description,
                    ds_IsPublic = c.IsPublic,
                });
            }

            pendingContentSource.DataSource = bindinglist;
        }

        private void linkBackToMain_Click(object sender, EventArgs e)
        {
            new MainForm(service).Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
             if (markedContent != null)
             {
                service.AddReview(markedContent.Id,"", false);

                new PendingContentForm(service).Show();
                this.Hide();
             }
             else
             {
                MessageBox.Show("Please select a row first");
             }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

            if (markedContent != null)
            {
                new EvaluationForm(service, markedContent).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row first");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.markedContent = pendingContents[e.RowIndex];
        }

    }
}
