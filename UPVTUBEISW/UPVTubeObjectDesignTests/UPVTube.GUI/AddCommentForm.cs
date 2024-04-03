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
    public partial class AddCommentForm : Form
    {
        IUPVTubeService service;
        Content c;
        public AddCommentForm()
        {
            InitializeComponent();
        }

        public AddCommentForm(IUPVTubeService service, Content content)
        {
            InitializeComponent();
            this.service = service;
            this.c = content;
        }

        private void AddCommentForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            if(tb_Comment.Text != "")
            {
                service.AddComment(tb_Comment.Text, c);
                this.Close();
            }
        }

        private void btn_CancelComment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
