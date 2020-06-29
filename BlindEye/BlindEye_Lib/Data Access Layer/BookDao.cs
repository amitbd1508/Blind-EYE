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
    public class BookDao
    {


        public static List<BookDto> GetAll()
        {
            List<BookDto> bookList = new List<BookDto>();
            BookDto book;

            string sql = "SELECT * FROM tblBook";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            //BookID,BookName,AuthorName,ReleseYear,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    book = new BookDto();
                    book.BookID = Convert.ToInt64(rdr["BookID"]);

                    book.BookName = Convert.ToString(rdr["BookName"]);
                    book.AuthorName = Convert.ToString(rdr["AuthorName"]);
                    book.ReleseYear = Convert.ToInt32(rdr["ReleseYear"]);
                    book.Remarks = Convert.ToString(rdr["Remarks"]);
                    book.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    book.CreatedBy = Convert.ToInt16(rdr["CreatedBy"]);
                    book.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    book.ModifyedBy = Convert.ToInt16(rdr["ModifyedBy"]);


                    bookList.Add(book);
                }
                return bookList;

            }
            catch (Exception ex)
            {
                Utilities.Constant.DBErrorMsg = ex.Message;
                return bookList;
            }
            finally
            {
                con.Close();
            }
         
        }
        //
        public static bool Insert(BookDto book)
        {

            string sql = " INSERT INTO tblBook (BookName,AuthorName,ReleseYear,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy) " +
                        "VALUES " +
                        " (@BookName,@AuthorName,@ReleseYear,@Remarks,@CreatedDate,@CreatedBy,@ModifyDate,@ModifyedBy)";

            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@BookName", book.BookName);
            cmd.Parameters.AddWithValue("@AuthorName", book.AuthorName);
            cmd.Parameters.AddWithValue("@ReleseYear", book.ReleseYear);
            cmd.Parameters.AddWithValue("@Remarks", book.Remarks);
            cmd.Parameters.AddWithValue("@CreatedDate", book.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedBy", book.CreatedBy);
            cmd.Parameters.AddWithValue("@ModifyDate", book.ModifyDate);
            cmd.Parameters.AddWithValue("@ModifyedBy", book.ModifyedBy);
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

        public static bool Update(BookDto book)
        {
            string sql = " UPDATE tblBook SET BookName=@BookName,AuthorName=@AuthorName,ReleseYear=@ReleseYear,Remarks=@Remarks,"
                         + "CreatedDate=@CreatedDate,CreatedBy=@CreatedBy,ModifyDate=@ModifyDate,ModifyedBy=@ModifyedBy  WHERE BookID=@BookID";

            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@BookID", book.BookID);

            cmd.Parameters.AddWithValue("@BookName", book.BookName);
            cmd.Parameters.AddWithValue("@AuthorName", book.AuthorName);
            cmd.Parameters.AddWithValue("@ReleseYear", book.ReleseYear);
            cmd.Parameters.AddWithValue("@Remarks", book.Remarks);
            cmd.Parameters.AddWithValue("@CreatedDate", book.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedBy", book.CreatedBy);
            cmd.Parameters.AddWithValue("@ModifyDate", book.ModifyDate);
            cmd.Parameters.AddWithValue("@ModifyedBy", book.ModifyedBy);
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
        public static bool DeleteByID(long id)
        {
            string sql = "  delete from tblContentText where BookID="+id+";"
                + "delete from tblContentAudio where BookID=" + id + ";"
                + "delete from tblChapter where BookID=" + id + ";"
                + "delete from tblBook where BookID=" + id + ";";

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

        public static BookDto GetByID(long bookid)
        {
           
            BookDto book;

            string sql = "SELECT * FROM tblBook where BookID=@BookID";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", bookid);
            //BookID,BookName,AuthorName,ReleseYear,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                book = new BookDto();
                while (rdr.Read())
                {
                    
                    book.BookID = Convert.ToInt64(rdr["BookID"]);

                    book.BookName = Convert.ToString(rdr["BookName"]);
                    book.AuthorName = Convert.ToString(rdr["AuthorName"]);
                    book.ReleseYear = Convert.ToInt32(rdr["ReleseYear"]);
                    book.Remarks = Convert.ToString(rdr["Remarks"]);
                    book.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    book.CreatedBy = Convert.ToInt16(rdr["CreatedBy"]);
                    book.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    book.ModifyedBy = Convert.ToInt16(rdr["ModifyedBy"]);


                    
                }
                return book;

            }
            catch (Exception ex)
            {
                Utilities.Constant.DBErrorMsg = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public static long  CountBooks()
        {
            string sql = "SELECT count(*) as cou FROM tblBook ";
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
    }
}
