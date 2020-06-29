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
    public class ContentTextDao
    {
        public static bool Insert(ContentTextDto content)
        {

            string sql = " INSERT INTO tblContentText (ChapterID,Content,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy,BookID) " +
                         "VALUES " +
                         " ( @ChapterID,@Content,@Remarks,@CreatedDate,@CreatedBy,@ModifyDate,@ModifyedBy,@BookID)";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ChapterID", content.ChapterID);
            cmd.Parameters.AddWithValue("@Remarks", content.Remarks);
            cmd.Parameters.AddWithValue("@BookId", content.BookID);
            cmd.Parameters.AddWithValue("@CreatedDate", content.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedBy", content.CreatedBy);
            cmd.Parameters.AddWithValue("@ModifyDate", content.ModifyDate);
            cmd.Parameters.AddWithValue("@ModifyedBy", content.ModifyedBy);
            cmd.Parameters.AddWithValue("@Content", content.Content);

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

        public static bool Update(ContentTextDto content )
        {
            

            string sql = " UPDATE tblContentText SET ChapterID=@ChapterID,Content=@Content,Remarks=@Remarks,CreatedDate=@CreatedDate,CreatedBy=@CreatedBy,ModifyDate=@ModifyDate,ModifyedBy=@ModifyedBy,BookID=@BookID  WHERE ContentID=@ContentID";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ChapterID", content.ChapterID);
            cmd.Parameters.AddWithValue("@Remarks", content.Remarks);
            cmd.Parameters.AddWithValue("@BookId", content.ContentID);
            cmd.Parameters.AddWithValue("@CreatedDate", content.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedBy", content.CreatedBy);
            cmd.Parameters.AddWithValue("@ModifyDate", content.ModifyDate);
            cmd.Parameters.AddWithValue("@ModifyedBy", content.ModifyedBy);
            cmd.Parameters.AddWithValue("@Content", content.Content);
            
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

        public static ContentTextDto GetByID(long contentid)
        {

            ContentTextDto content;

            string sql = "SELECT * FROM tblContentText where ContentID=@ContentID";
            Console.WriteLine(sql);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.BlindEyeDBConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ContentID", contentid);
            //contentID,contentName,AuthorName,ReleseYear,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                content = new ContentTextDto();
                while (rdr.Read())
                {

                    content.ContentID = Convert.ToInt64(rdr["contentID"]);

                    content.Content = Convert.ToString(rdr["Content"]);
                    content.ChapterID = Convert.ToInt64(rdr["ChapterID"]);
                    
                    content.BookID = Convert.ToInt64(rdr["BookID"]);
                    content.Remarks = Convert.ToString(rdr["Remarks"]);
                    content.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    content.CreatedBy = Convert.ToInt64(rdr["CreatedBy"]);
                    content.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    content.ModifyedBy = Convert.ToInt64(rdr["ModifyedBy"]);



                }
                return content;

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

        public static List<ContentTextDto> GetAll()
        {
            List<ContentTextDto>contentList = new List<ContentTextDto>();
            ContentTextDto content;

            string sql = "SELECT * FROM tblContentText";
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
                    content = new ContentTextDto();
                    content.ContentID = Convert.ToInt64(rdr["contentID"]);

                    content.Content = Convert.ToString(rdr["Content"]);
                    content.ChapterID = Convert.ToInt64(rdr["ChapterID"]);

                    content.BookID = Convert.ToInt64(rdr["BookID"]);
                    content.Remarks = Convert.ToString(rdr["Remarks"]);
                    content.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    content.CreatedBy = Convert.ToInt64(rdr["CreatedBy"]);
                    content.ModifyDate = Convert.ToDateTime(rdr["ModifyDate"]);
                    content.ModifyedBy = Convert.ToInt64(rdr["ModifyedBy"]);


                    contentList.Add(content);
                }
                return contentList;

            }
            catch (Exception ex)
            {
                Utilities.Constant.DBErrorMsg = ex.Message;
                return contentList;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
