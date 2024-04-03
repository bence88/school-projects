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
    public partial class DisplayConentDetailsForm : Form
    {
        private IUPVTubeService service;
        private Content c;

        public DisplayConentDetailsForm()
        {
            InitializeComponent();
        }
        public DisplayConentDetailsForm(IUPVTubeService service, Content content) :this()
        {
            this.service = service;
            this.c = content;

            tb_URI.Text = c.ContentURI;
            tb_Title.Text = c.Title;
            tb_Owner.Text = c.Owner.FullName;
            tb_UpLoadDate.Text = c.UploadDate.ToString();
            tb_Authorized.Text = c.Authorized.ToString();
            if (c.IsPublic)
            {
                tb_IsPublic.Text = "Yes";
            }
            else
            {
                tb_IsPublic.Text = "No";
            }
            if (c.Authorized == Authorized.No)
            {
                tb_Eval.Text = c.Evaluation.RejectionReason;
            }
            else
            {
                tb_Eval.Text = "Content is approved!";
            }
            string subjectNames = "";
            foreach (Subject s in c.Subjects)
            {
                subjectNames += s.Name + ", ";
            }
            tb_Subjects.Text = subjectNames;

            string comments = string.Empty;
            foreach(Comment com in c.Comments)
            {
                comments += com.WritingDate + " " + com.Writer.Nick + ": " + com.Text + "\r\n";
            }
            tb_Comments.Text = comments;
        }

        private void DisplayConentDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMakeComment_Click(object sender, EventArgs e)
        {
            new AddCommentForm(service, c).ShowDialog();
        }
    }
}
