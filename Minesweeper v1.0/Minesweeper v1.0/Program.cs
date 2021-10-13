using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_v1._0
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
            //Application.Run(new MainInterface());
            //Application.Run(new Test01());
            //Application.Run(new NewGame());
            //Application.Run(FormArrange.NewGame);
            Application.Run(FormArrange.MainMenu);
        }
    }
}
