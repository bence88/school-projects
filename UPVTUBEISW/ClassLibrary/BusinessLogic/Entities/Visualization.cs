using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {

        public Visualization()
        {
            //there are no ..n relationships
        }

        public Visualization(DateTime visualizationDate, Content content, Member member) : this()
        {
            this.VisualizationDate = visualizationDate;
            this.Content = content;
            this.Member = member;
        }
    }

    
}
