using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using СarServiceApplication.Authorization;

namespace СarServiceApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new AuthorizationForm());
            //Application.Run(new VideoForm(Application.StartupPath + "\\Content\\Theory\\videoplayback.mp4"));

        }
    }
}
