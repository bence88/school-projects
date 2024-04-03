using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.BusinessLogic.Services;
using UPVTube.Persistence;

namespace UPVTube.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            IUPVTubeService service = new UPVTubeService(new EntityFrameworkDAL(new UPVTubeDbContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogInForm(service));
        }
    }
}