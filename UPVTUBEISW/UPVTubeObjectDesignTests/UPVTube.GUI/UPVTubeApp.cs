using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.BusinessLogic.Services;
using UPVTube.Services;

namespace UPVTube.GUI
{
    public partial class UPVTubeApp : Form
    {
        protected IUPVTubeService service;
        private RegisterUserForm registerUserForm;
        public UPVTubeApp()
        {
            InitializeComponent();

        }
        public UPVTubeApp(IUPVTubeService service) : this()
        {
            this.service = service;
            registerUserForm = new RegisterUserForm(service);
        }

    }
}
