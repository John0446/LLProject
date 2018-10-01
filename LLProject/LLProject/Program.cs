using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLProject
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
            Application.Run(new frmiteminfo());
<<<<<<< HEAD
            Application.Run(new frmcustomerinfo());
=======
>>>>>>> e2d998a00251463c419e6c09d6541081c56226f6
        }
    }
}
