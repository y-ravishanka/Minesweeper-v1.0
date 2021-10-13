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
    public partial class MainInterface : Form
    {
        SQL_Class sql = new SQL_Class();

        private static Random random = new Random();
        private Panel[] panel = new Panel[266];
        private char[] num = new char[266];
        private bool game = false;
        private bool[] mine = new bool[266];
        private bool[] count = new bool[266];
        private int t = 266;
        private int i = 0;
        private int j = 0;
        private int total = 0;
        private int sec = 0;
        private string stime = null;
        private string gtime = null;
        private bool hscore = false;
        private int score = 0;

        public MainInterface(int sec)
        {
            InitializeComponent();
            this.sec = sec;
            game_start();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void game_start()
        {
            game = true;
            loadNumbers();
            flow1.Controls.Clear();
            loadpanels();
            total = 0;
            timer1.Start();
            score_lb.Text = 0.ToString();
            time_lb.Text = 0.ToString();
            stime = (sec / 60).ToString() + " : " + (sec % 60).ToString();
            score = sql.getHightScore();
            h_score_lb.Text = score.ToString();
        }

        private static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string RandomString17(int length)
        {
            const string chars = "012345";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void loadNumbers()
        {
            string s = RandomString(t);
            num = s.ToCharArray();

            for(i = 0;i<t;++i)
            {
                mine[i] = false;
                count[i] = false;
            }
        }

        private void loadpanels()
        {
            loadmines();
            for (i = 0; i < t; i++)
            {
                Panel lb = new Panel();
                lb.Name = "l" + i.ToString();
                lb.Size = new Size(25, 25);
                lb.BorderStyle = BorderStyle.None;
                lb.BackColor = Color.White;
                lb.Click += new EventHandler(panel_Click);
                flow1.Controls.Add(lb);
                panel[i] = lb;
                //writePanel(lb);
                for (j = 0; j < 4; ++j)
                {
                    Panel sb = new Panel
                    {
                        Name = "s" + i.ToString()+j.ToString(),
                        BackColor = Color.Gray,
                        Size = new Size(1, 1)
                    };
                    switch(j)
                    {
                        case 0:
                            sb.Dock = DockStyle.Bottom;
                            break;
                        case 1:
                            sb.Dock = DockStyle.Top;
                            break;
                        case 2:
                            sb.Dock = DockStyle.Left;
                            break;
                        case 3:
                            sb.Dock = DockStyle.Right;
                            break;
                    }
                    lb.Controls.Add(sb);
                }
            }
            //game_over();
        }

        private void loadmines()
        {
            int tmp = 1;
            int[] ar = new int[10];
            for(i = 0; i < t; ++i)
            {
                ar[tmp - 1] = i;
                if(i!=(t-1))
                {
                    if(tmp == 10)
                    {
                        int nav = 0;
                        int act = 0;
                        int ski = 3;
                        string s1 = RandomString(300);
                        char[] s2 = s1.ToCharArray();
                        int t1 = int.Parse(s2[nav].ToString());
                        int t2 = int.Parse(s2[nav+1].ToString());
                        int t3 = int.Parse(s2[nav+2].ToString());
                        while (act == 0)
                        {
                            if(t1 == t2)
                            {
                                t2 = int.Parse(s2[nav + ski].ToString());
                                ski++;
                            }
                            else if (t1 == t3)
                            {
                                t3 = int.Parse(s2[nav + ski].ToString());
                                ski++;
                            }
                            else if(t2 == t3)
                            {
                                t3 = int.Parse(s2[nav + ski].ToString());
                                ski++;
                            }
                            else
                            {
                                act = 1;
                            }
                        }
                        mine[ar[t1]] = true;
                        mine[ar[t2]] = true;
                        mine[ar[t3]] = true;
                        tmp = 1;
                    }
                }
                else
                {
                    int nav = 0;
                    int act = 0;
                    int ski = 2;
                    string s1 = RandomString17(300);
                    char[] s2 = s1.ToCharArray();
                    int t1 = int.Parse(s2[nav].ToString());
                    int t2 = int.Parse(s2[nav + 1].ToString());
                    while (act == 0)
                    {
                        if (t1 == t2)
                        {
                            t2 = int.Parse(s2[nav + ski].ToString());
                            ski++;
                        }
                        else
                        {
                            act = 1;
                        }
                    }
                    mine[ar[t1]] = true;
                    mine[ar[t2]] = true;
                }
                tmp++;
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel lb1 = sender as Panel;

            if (game == true && count[getItemNumber(lb1)] == false)
            {
                writePanel(lb1);
            }
        }

        private int getItemNumber(Panel lb)
        {
            char[] s = lb.Name.ToCharArray();
            char[] a = new char[s.Length - 1];
            for (i = 1; i < s.Length; ++i)
            {
                a[i - 1] = s[i];
            }
            string d1 = new string(a);
            return (int.Parse(d1));
        }

        private void writePanel(Panel lb)
        {
            int d2 = getItemNumber(lb);
            char d = num[d2];
            if (mine[d2] == false)
            {
                for (i = 0; i < 6; ++i)
                {
                    count[d2] = true;
                    Label lb1 = new Label
                    {
                        Name = lb.Name + d.ToString(),
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.None,
                        Text = d.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.FromArgb(240, 240, 240)
                    };
                    lb.Controls.Add(lb1);
                    if (game == true)
                    {
                        calculate(d);
                    }
                    while (true)
                    {
                        int index = new Random().Next(0, 266);
                        if(count[index] != true && mine[index] != true)
                        {
                            d2 = index;
                            d = num[d2];
                            lb = panel[d2];
                            break;
                        }
                    }
                }
                if (game == true)
                {
                    calculate(d);
                }
            }
            else if(mine[d2] == true)
            {
                PictureBox lb1 = new PictureBox
                {
                    Name = lb.Name + d.ToString(),
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Image.FromFile("C:/Users/Shadow/Documents/C#/Minesweeper v1.0/Minesweeper v1.0/Resources/mine2.png")
                };
                lb.Controls.Add(lb1);
                game = false;
                game_over();
            }
        }

        private void calculate(char z)
        {
            total += int.Parse(z.ToString());
            score_lb.Text = total.ToString();
        }

        private void game_over()
        {
            for(i=0;i<t;++i)
            {
                if (mine[i] == true)
                { panel[i].BackColor = Color.Gray; }
            }
            timer1.Stop();
            gtime = (sec / 60).ToString() + " : " + (sec % 60).ToString();
            if (hscore == false)
            { sql.setScore(true, stime, gtime, total); }
            else
            {
                sql.setScore(true, stime, gtime, total);
                sql.setScore(false, stime, gtime, total);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormArrange.NewGame.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            time_lb.Text = (sec / 60).ToString() + " : " + (sec % 60).ToString();
            if (sec == 0)
            { game_over(); }
            if (score < total)
            { hscore = true; h_score_lb.Text = total.ToString(); }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            game_over();
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
