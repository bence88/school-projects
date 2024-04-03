using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Services;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content() 
        { 
            Subjects = new List<Subject>();
            Visualizations = new List<Visualization>();
            Comments = new List<Comment>();
        }

        public Content(string contentURI, string descrption, bool isPublic, string title, DateTime uploadDate, Member owner) :this()
        {
            this.ContentURI = contentURI;
            this.Description = descrption;
            this.IsPublic = isPublic;
            this.Title = title;
            this.UploadDate = uploadDate;
            this.Owner = owner;

            this.Authorized = Authorized.Yes;
            if (Domains.IsStudentDomain(this.Owner.Email))
            {
                this.Authorized = Authorized.Pending;
            }
        }
    }
}
