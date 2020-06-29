using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.For_project_recurment
{
    public class ExtrafaltuClass
    {
        public static List<string> FaltuqueryForfrmBookReader(string sql)
        {
            List<string> list = new List<string>();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            try{

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    list.Add(rdr["ContentText"].ToString());
                }
                return list;
            }
            catch(Exception e)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public static int  Sumex()
        {
            string sql = "SELECT Sum(Rating) as rt  FROM tblUserMaster ;";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;

            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                if(rdr.Read())
                return Convert.ToInt32(rdr["rt"]);
                return -1;
            }
            catch(Exception)
            {
                return -1;
            }
            finally
            {
                con.Close();

            }
        }


        public static int AvgEx()
        {
            string sql = "SELECT AVG(Rating) as rt  FROM tblUserMaster ;";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;

            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                    return Convert.ToInt32(rdr["rt"]);
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                con.Close();

            }
        }

        public static int MAXEx()
        {
            string sql = "SELECT max(Rating) as rt  FROM tblUserMaster ;";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;

            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                    return Convert.ToInt32(rdr["rt"]);
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                con.Close();

            }
        }

        public static int MinEx()
        {
            string sql = "SELECT min(Rating) as rt  FROM tblUserMaster ;";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;

            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                    return Convert.ToInt32(rdr["rt"]);
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                con.Close();

            }
        }
    }
}
