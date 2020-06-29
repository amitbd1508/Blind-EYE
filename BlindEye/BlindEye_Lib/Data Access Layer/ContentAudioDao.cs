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
    public class ContentAudioDao
    {
        public static bool Insert(ContentAudioDto content)
        {

            string sql = " INSERT INTO tblContentAudio (ChapterID,Content,Remarks,CreatedDate,CreatedBy,ModifyDate,ModifyedBy,BookID) " +
                         "VALUES " +
                         " ( @ChapterID,@Content,@Remarks,@CreatedDate,@CreatedBy,@ModifyDate,@ModifyedBy,@BookID)";
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

        public static bool Update(ContentAudioDto content)
        {
            

            string sql = " UPDATE tblContentAudio SET ChapterID=@ChapterID,Content=@Content,Remarks=@Remarks,CreatedDate=@CreatedDate,CreatedBy=@CreatedBy,ModifyDate=@ModifyDate,ModifyedBy=@ModifyedBy,BookID=@BookID  WHERE ContentID=@ContentID";
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
    }
}
