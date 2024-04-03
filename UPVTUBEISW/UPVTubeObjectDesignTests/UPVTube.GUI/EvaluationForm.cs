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
using UPVTube.Entities;

namespace UPVTube.GUI
{
    public partial class EvaluationForm : Form
    {
        private IUPVTubeService service;
        private Content content;
        public EvaluationForm(IUPVTubeService service, Content content)
        {
            this.service = service;
            this.content = content;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            string rejectReason = txtRejectionReason.Text;
            if(rejectReason == "")
            {
                MessageBox.Show("Please provide a rejection reason");
            }
            else
            {
                service.AddReview(content.Id, rejectReason, true);
                new PendingContentForm(service).Show();
                this.Hide();
                
            }
        }
    }
}
