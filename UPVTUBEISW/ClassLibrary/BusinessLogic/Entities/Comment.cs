using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public Comment()
        {
            // there are no n (many) Relationships
        }

        public Comment(string Text, DateTime WritingDate, //alphabetical order attributes of the class
            Content content, Member writer):this() {           //alphabatical order attributes of the relationship
            this.Text = Text;
            this.WritingDate = WritingDate;
            this.Content = content;
            this.Writer = writer;
        }

        
    }
}
