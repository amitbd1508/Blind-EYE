using BlindEye_Lib.Data_Object;
using BlindEye_Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.Data_Access_Layer
{
    public class UserMasterDao
    {

        public static bool Insert(UserMasterDto user)
        {

            string sql = " INSERT INTO tblUserMaster (UserName,Password,UserFullName,DateOfBirth,Email,PhoneNumber,AccountType,Rating) " +
                         "VALUES "+
                         " ( @UserName,@Password,@UserFullName,@DateOfBirth,@Email,@PhoneNumber,@AccountType,@Rating)";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@UserFullName", user.UserFullName);
            cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@AccountType", user.AccountType);
            cmd.Parameters.AddWithValue("@Rating", user.Rating);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Constant.DBErrorMsg =ex.Message;

                return false;
            }

            finally
            {
                con.Close();
            }


        }


        public static bool IsUserExist(string username)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand("select count(*) from tblUserMaster where userName='" + username + "'", con);


            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();


                if (rdr == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return true;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool LoginCheck(string username, string password,out UserMasterDto _user)
        {
            UserMasterDto user;
            string sql = "SELECT *  FROM tblUserMaster WHERE UserName='" + username + "' and Password='" + password + "';";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    user = new UserMasterDto();
                    user.UserMasterID = Convert.ToInt64(rdr["UserMasterID"]);

                    user.UserName = Convert.ToString(rdr["UserName"]);
                    user.Password = Convert.ToString(rdr["Password"]);
                    user.UserFullName = Convert.ToString(rdr["UserFullName"]);
                    user.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                    user.Email = Convert.ToString(rdr["Email"]);
                    user.PhoneNumber = Convert.ToString(rdr["PhoneNumber"]);
                    user.AccountType = Convert.ToInt16(rdr["AccountType"]);
                    user.Rating = Convert.ToInt16(rdr["Rating"]);
                    _user = new UserMasterDto();
                    _user = user;
                    return true;
                }
                _user = new UserMasterDto();
                return false;
            }
            catch (Exception e)
            {
                _user = new UserMasterDto();
                return false;

            }
            finally
            {
                con.Close();
            }


        }
        public static string GetAccountType(string UserName, string Password)
        {
            string sql = "select AccountType from tblUserMaster where UserName='" + UserName + "' and Password='" + Password + "';";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);


            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr == null)
                    {
                        return "";
                    }
                    else
                    {
                        string sx = rdr["AccountType"].ToString();
                        Console.WriteLine(sx);
                        return sx;
                    }

                }

                
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                con.Close();
            }
            return "";
        }
        public static List<UserMasterDto> GetAll()
        {
            List<UserMasterDto> userList = new List<UserMasterDto>();
            UserMasterDto user;

            string sql = "SELECT UserMasterID,UserName,Password,UserFullName,DateOfBirth,Email,PhoneNumber,AccountType,Rating  FROM tblUserMaster";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);


            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user = new UserMasterDto();
                    user.UserMasterID =Convert.ToInt64( rdr["UserMasterID"]);

                    user.UserName = Convert.ToString(rdr["UserName"]);
                    user.Password = Convert.ToString(rdr["Password"]);
                    user.UserFullName = Convert.ToString(rdr["UserFullName"]);
                    user.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                    user.Email = Convert.ToString(rdr["Email"]);
                    user.PhoneNumber = Convert.ToString(rdr["PhoneNumber"]);
                    user.AccountType = Convert.ToInt16(rdr["AccountType"]);
                    user.Rating = Convert.ToInt16(rdr["Rating"]);

                    userList.Add(user);
                }
                return userList;

            }
            catch (Exception ex)
            {
                return userList;
            }
            finally
            {
                con.Close();
            }
         
        }
        public static UserMasterDto GetByUserMasterID(long _UserMasterID)
        {
          
            UserMasterDto user;

            string sql = "SELECT UserMasterID,UserName,Password,UserFullName,DateOfBirth,Email,PhoneNumber,AccountType,Rating  FROM tblUserMaster WHERE UserMasterID=@UserMasterID";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserMasterID", _UserMasterID);

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user = new UserMasterDto();
                    user.UserMasterID = Convert.ToInt64(rdr["UserMasterID"]);

                    user.UserName = Convert.ToString(rdr["UserName"]);
                    user.Password = Convert.ToString(rdr["Password"]);
                    user.UserFullName = Convert.ToString(rdr["UserFullName"]);
                    user.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                    user.Email = Convert.ToString(rdr["Email"]);
                    user.PhoneNumber = Convert.ToString(rdr["PhoneNumber"]);
                    user.AccountType = Convert.ToInt16(rdr["AccountType"]);
                    user.Rating = Convert.ToInt16(rdr["Rating"]);

                    return user;
                }
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool Update(UserMasterDto user)
        {

            string sql = " UPDATE tblUserMaster SET UserName=@UserName,Password=@Password,UserFullName=@UserFullName,DateOfBirth=@DateOfBirth,Email=@Email,PhoneNumber=@PhoneNumber,AccountType=@AccountType,Rating=@Rating  WHERE UserMasterID=@UserMasterID";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
           
            cmd.Parameters.AddWithValue("@UserMasterID", user.UserMasterID);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@UserFullName", user.UserFullName);
            cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@AccountType", user.AccountType);
            cmd.Parameters.AddWithValue("@Rating", user.Rating);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Constant.DBErrorMsg = ex.Message;

                return false;
            }

            finally
            {
                con.Close();
            }

        }
        public static bool DeleteByID(long userid)
        {

            string sql = "delete from tblUserMaster where UserMasterID="+userid+";";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Constant.DBErrorMsg = ex.Message;

                return false;
            }

            finally
            {
                con.Close();
            }

        }
        public static bool ResetPasswordUpdate(UserMasterDto user)
        {

            string sql = " UPDATE tblUserMaster SET Password=@Password  WHERE UserName=@UserName";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Constant.DBErrorMsg = ex.Message;

                return false;
            }

            finally
            {
                con.Close();
            }

        }
        public static bool LoginCheck(string username, string password)
        {
            
            string sql = "SELECT *  FROM tblUserMaster WHERE UserName='" + username + "' and Password='" + password + "';";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {                   
                   if(Convert.ToInt64(rdr["UserMasterID"])>0)
                        return true;
                }                
                return false;
            }
            catch (Exception e)
            {               
                return false;

            }
            finally
            {
                con.Close();
            }

        }

        public static long CountUser()
        {
            string sql = "SELECT count(*) as cou FROM tblUserMaster ";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    long cn = Convert.ToInt64(rdr["cou"]);
                    return cn;

                }
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

        public static bool UpdateRatingByOne(long p)
        {
            string sql = "  UPDATE tblUserMaster SET Rating=Rating+1  WHERE UserMasterID="+p+";";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Constant.DBErrorMsg = ex.Message;

                return false;
            }

            finally
            {
                con.Close();
            }

        }


        public static UserMasterDto GetByUserMasterUsername(string username)
        {

            UserMasterDto user;

            string sql = "SELECT UserMasterID,UserName,Password,UserFullName,DateOfBirth,Email,PhoneNumber,AccountType,Rating  FROM tblUserMaster WHERE UserFullName=@UserFullName";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserFullName", username);

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user = new UserMasterDto();
                    user.UserMasterID = Convert.ToInt64(rdr["UserMasterID"]);

                    user.UserName = Convert.ToString(rdr["UserName"]);
                    user.Password = Convert.ToString(rdr["Password"]);
                    user.UserFullName = Convert.ToString(rdr["UserFullName"]);
                    user.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                    user.Email = Convert.ToString(rdr["Email"]);
                    user.PhoneNumber = Convert.ToString(rdr["PhoneNumber"]);
                    user.AccountType = Convert.ToInt16(rdr["AccountType"]);
                    user.Rating = Convert.ToInt16(rdr["Rating"]);

                    return user;
                }
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        

        
    }
}