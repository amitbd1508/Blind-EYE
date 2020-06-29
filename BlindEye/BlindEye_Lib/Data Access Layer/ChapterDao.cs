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
    public class ChapterDao
    {
        public static bool Insert(ChapterDto chapter)
        {

            string sql = " INSERT INTO tblChapter (ChapterName,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy,BookID) " +
                         "VALUES " +
                         " ( @ChapterName,@Remarks,@CreatedDate,@CreatedBy,@ModifyDate,@ModifyedBy,@BookID)";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ChapterName", chapter.ChapterName);
            cmd.Parameters.AddWithValue("@Remarks", chapter.Remarks);
            
            cmd.Parameters.AddWithValue("@CreatedDate", chapter.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedBy", chapter.CreatedBy);
            cmd.Parameters.AddWithValue("@ModifyDate", chapter.ModifyDate);
            cmd.Parameters.AddWithValue("@ModifyedBy", chapter.ModifyedBy);
            cmd.Parameters.AddWithValue("@BookID", chapter.BookID);
            
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
       

        public static bool Update(ChapterDto chapter )
        {


            string sql = " UPDATE Chapter SET ChapterName=@ChapterName,Content=@Content,Remarks=@Remarks,CreatedDate=@CreatedDate,CreatedBy=@CreatedBy,ModifyDate=@ModifyDate,ModifyedBy=@ModifyedBy,ChapterID=@ChapterID  WHERE ContentID=@ContentID";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ChapterName", chapter.ChapterName);
            cmd.Parameters.AddWithValue("@Remarks", chapter.Remarks);
            cmd.Parameters.AddWithValue("@ChapterId", chapter.ChapterID);
            cmd.Parameters.AddWithValue("@CreatedDate", chapter.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedBy", chapter.CreatedBy);
            cmd.Parameters.AddWithValue("@ModifyDate", chapter.ModifyDate);
            cmd.Parameters.AddWithValue("@ModifyedBy", chapter.ModifyedBy);
            
            
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


        public static ChapterDto GetByID(long Chapterid)
        {

            ChapterDto Chapter;

            string sql = "SELECT * FROM tblChapter where ChapterID=@ChapterID";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ChapterID",Chapterid);
            //ChapterID,ChapterName,ChapterID,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                Chapter = new ChapterDto();
                while (rdr.Read())
                {

                    Chapter.ChapterID = Convert.ToInt64(rdr["ChapterID"]);
                    Chapter.ChapterName = Convert.ToString(rdr["ChapterName"]);            
                    Chapter.ChapterID = Convert.ToInt64(rdr["ChapterID"]);
                    Chapter.Remarks = Convert.ToString(rdr["Remarks"]);
                    Chapter.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    Chapter.CreatedBy = Convert.ToInt16(rdr["CreatedBy"]);
                    Chapter.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    Chapter.ModifyedBy = Convert.ToInt16(rdr["ModifyedBy"]);



                }
                return Chapter;

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

        public static List<ChapterDto> GetAll()
        {
            List<ChapterDto> ChapterList = new List<ChapterDto>();
            ChapterDto Chapter;

            string sql = "SELECT * FROM tblChapter";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            //ChapterID,ChapterName,AuthorName,ReleseYear,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Chapter = new ChapterDto();
                    Chapter.ChapterID = Convert.ToInt64(rdr["ChapterID"]);

                    Chapter.ChapterName = Convert.ToString(rdr["ChapterName"]);                  
                    Chapter.BookID = Convert.ToInt64(rdr["BookID"]);
                    Chapter.Remarks = Convert.ToString(rdr["Remarks"]);
                    Chapter.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    Chapter.CreatedBy = Convert.ToInt16(rdr["CreatedBy"]);
                    Chapter.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    Chapter.ModifyedBy = Convert.ToInt16(rdr["ModifyedBy"]);


                    ChapterList.Add(Chapter);
                }
                return ChapterList;

            }
            catch (Exception ex)
            {
                Utilities.Constant.DBErrorMsg = ex.Message;
                return ChapterList;
            }
            finally
            {
                con.Close();
            }

        }

        public static List<ChapterDto> GetByBookID(long BookID)
        {
            List<ChapterDto> ChapterList = new List<ChapterDto>();
            ChapterDto Chapter;

            string sql = "SELECT * FROM tblChapter WHERE BookID=@BookID";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", BookID);
            //ChapterID,ChapterName,AuthorName,ReleseYear,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Chapter = new ChapterDto();
                    Chapter.ChapterID = Convert.ToInt64(rdr["ChapterID"]);

                    Chapter.ChapterName = Convert.ToString(rdr["ChapterName"]);
                    Chapter.BookID = Convert.ToInt64(rdr["BookID"]);
                    Chapter.Remarks = Convert.ToString(rdr["Remarks"]);
                    Chapter.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    Chapter.CreatedBy = Convert.ToInt16(rdr["CreatedBy"]);
                    Chapter.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    Chapter.ModifyedBy = Convert.ToInt16(rdr["ModifyedBy"]);


                    ChapterList.Add(Chapter);
                }
                return ChapterList;

            }
            catch (Exception ex)
            {
                Utilities.Constant.DBErrorMsg = ex.Message;
                return ChapterList;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
