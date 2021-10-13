using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Minesweeper_v1._0
{
    public partial class Score : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        private bool type = true;

        public Score()
        {
            InitializeComponent();
            clickScore();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void clickScore()
        {
            pnlScore.BackColor = Color.LightGray;
            pnlHScore.BackColor = Color.White;
            type = true;
            loadData();
        }

        private void clickHScore()
        {
            pnlHScore.BackColor = Color.LightGray;
            pnlScore.BackColor = Color.White;
            type = false;
            loadData();
        }

        private void loadData()
        {
            string tmp = null;
            string table = null;
            if (type == true)
            { tmp = "score"; table = "score"; }
            else
            { tmp = "h_score"; table = "h_score"; }
            string que = "select date as Date ,settime as Set_Time, gametime as Game_Time, score as Score from " + tmp + " order by id DESC";
            try
            {
                SqlDataAdapter dta = new SqlDataAdapter(que, con);
                DataSet ds = new DataSet();
                dta.Fill(ds, table);
                data.DataSource = ds;
                data.DataMember = table;
                table = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(Convert.ToString(e));
            }
            finally
            {
                con.Close();
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void butScore_Click(object sender, EventArgs e)
        {
            clickScore();
        }

        private void butHScore_Click(object sender, EventArgs e)
        {
            clickHScore();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            FormArrange.MainMenu.Show();
            this.Close();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            Wanning ob1 = new Wanning(type);
            ob1.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
