using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace TourManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DB.SetConfiguration("PI2526_lmihalic24_DB", "PI2526_lmihalic24", "xXYE1uAU>*{y>WLb");

            Application.Run(new FrmLogin());
        }
    }
}
