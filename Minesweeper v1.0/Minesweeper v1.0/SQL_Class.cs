using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Minesweeper_v1._0
{
    class SQL_Class
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        private int i, j;
        private string que;

        public String getDate()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void setScore(bool x, string stime, string gtime, int score)
        {
            string tmp = null;
            if (x == true)
            { tmp = "score"; }
            else
            { tmp = "h_score"; }
            que = "insert into " + tmp + "(date, settime, gametime, score) values ('" + getDate() + "','" + stime + "','" + gtime + "'," + score + ")";
            SqlCommand cmd = new SqlCommand(que, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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

        public void deleteScore(bool x)
        {
            string tmp = null;
            if (x == true)
            { tmp = "score"; }
            else
            { tmp = "h_score"; }
            que = "delete from " + tmp;
            SqlCommand cmd = new SqlCommand(que, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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

        public int getHightScore()
        {
            int tmp = 0;
            que = "select top 1 score from h_score order by score DESC";
            SqlCommand cmd1 = new SqlCommand(que, con);
            try
            {
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        tmp = dr1.GetInt32(0);
                    }
                }
                dr1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(Convert.ToString(e));
            }
            finally
            {
                con.Close();
            }
            return tmp;
        }
    }
}
