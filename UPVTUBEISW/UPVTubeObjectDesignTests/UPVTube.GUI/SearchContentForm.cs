using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UPVTube.BusinessLogic.Services;
using UPVTube.Entities;

namespace UPVTube.GUI 
{
    public partial class SearchContentForm : Form
    {
        private IUPVTubeService service;

        //Content db = new Content();
        //DataTable dt = new DataTable();

        private List<Content> contentList;

        public SearchContentForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;

            dataGridView1.AutoGenerateColumns = false;
        }

        private void checkPublicStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkBackToMain_Click(object sender, EventArgs e)
        {
            new MainForm(service).Show();
            this.Hide();
        }


        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            searchContent();
        }

        private void txtURI_TextChanged(object sender, EventArgs e)
        {
            searchContent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            searchContent();
        }

        private void btnSearchClick(object sender, EventArgs e)
        {
            searchContent();

        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchContent();
        }

        private void SearchContentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Content c = contentList[e.RowIndex];
            new DisplayConentDetailsForm(service, c).ShowDialog();
        }

        private void searchContent()
        {
            string title = txtTitle.Text;
            string subject = txtSubject.Text;
            string owner = txtNick.Text;
            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;
            Member member = service.GetLoggedInMember();


            contentList = service.SearchContent(member, start, end, owner, title, subject);
            
            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Content c in contentList)
            {
                string subjectNames = "";
                foreach (Subject s in c.Subjects)
                {
                    subjectNames += s.Name + ", ";
                }

                bindinglist.Add(new
                {
                    Title = c.Title,
                    Owner = c.Owner.Nick,
                    Description = c.Description,
                    Subjects = subjectNames,
                    UploadDate = c.UploadDate,
                    ContentURI = c.ContentURI,
                });
            }
            contentBindingSource.DataSource = bindinglist;
        }

    }
}
