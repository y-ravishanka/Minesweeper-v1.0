using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_v1._0
{
    public partial class NewGame : Form
    {
        private int min = 0;
        private int sec = 0;

        public NewGame()
        {
            InitializeComponent();
            start();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void start()
        {
            min = 0;
            sec = 0;
            printClock();
        }

        private void printClock()
        {
            minLbl.Text = "0" + min.ToString();
            if (sec > 9)
            { secLbl.Text = sec.ToString(); }
            else
            { secLbl.Text = "0" + sec.ToString(); }
        }

        private void mup_Click(object sender, EventArgs e)
        {
            if (min < 5)
            { min += 1; }
            else if (min == 5)
            { min = 0; }
            printClock();
        }

        private void sup_Click(object sender, EventArgs e)
        {
            if (sec < 60)
            {
                if (min < 5)
                {
                    if (sec == 59)
                    {
                        min += 1;
                        sec = 0;
                    }
                    else
                    { sec += 1; }
                }
                else if (min == 5 && sec < 59)
                { sec += 1; }
                else if (min == 5 && sec == 59)
                { sec = 0; }
            }
            printClock();
        }

        private void sdown_Click(object sender, EventArgs e)
        {
            if (sec == 0)
            { 
                sec = 59;
                if (min > 0)
                { min -= 1; }
            }
            else
            { sec -= 1; }
            printClock();
        }

        private void mdown_Click(object sender, EventArgs e)
        {
            if (min != 0)
            { min -= 1; }
            else if (min == 0)
            { min = 5; }
            printClock();
        }

        private void butGame_Click(object sender, EventArgs e)
        {
            int t = (min * 60) + (sec);
            if (t < 10)
            { t = 10; }
            MainInterface ob1 = new MainInterface(t);
            ob1.Show();
            start();
            this.Hide();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            FormArrange.MainMenu.Show();
            start();
            this.Hide();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
