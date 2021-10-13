using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_v1._0
{
    class FormArrange
    {
        public static NewGame NewGame
        {
            get
            {
                if (newgame == null)
                {
                    newgame = new NewGame();
                }
                return newgame;
            }
        }
        private static NewGame newgame;

        public static MainMenu MainMenu
        {
            get
            {
                if (mainmenu == null)
                {
                    mainmenu = new MainMenu();
                }
                return mainmenu;
            }
        }
        private static MainMenu mainmenu;
    }
}
