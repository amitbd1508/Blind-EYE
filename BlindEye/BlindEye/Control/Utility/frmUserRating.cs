using BlindEye_Lib.Data_Access_Layer;
using BlindEye_Lib.Data_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlindEye.Control.Utility
{
    public partial class frmUserRating : Form
    {
        public frmUserRating()
        {
            InitializeComponent();
        }

        private void frmUserRating_Load(object sender, EventArgs e)
        {
            LoadGride();
            
        }
        private void LoadGride()
        {
            dvgUserList.Rows.Clear();
            dvgUserList.Columns.Clear();

            dvgUserList.Columns.Add("UserMasterID", "Serial");
            dvgUserList.Columns.Add("UserFullName", "Name");
            dvgUserList.Columns.Add("Email", "Email");
            dvgUserList.Columns.Add("Rating", "Rating");

            dvgUserList.Columns["UserFullName"].Width = 150;
            dvgUserList.Columns["Email"].Width = 100;
            
            dvgUserList.Columns["Rating"].Width = 100;
            dvgUserList.Columns["UserMasterID"].Width = 50;


            
            List<UserMasterDto> userlist = new List<UserMasterDto>();
            try
            {
                userlist = UserMasterDao.GetAll();
            }
            catch (Exception ex) { }


            if (userlist.Count > 0)
            {

                for (int i = 0; i < userlist.Count; i++)
                {
                    dvgUserList.Rows.Add();
                    dvgUserList.Rows[i].Cells["UserMasterID"].Value = i+1;
                    dvgUserList.Rows[i].Cells["UserFullName"].Value = userlist[i].UserName;
                    dvgUserList.Rows[i].Cells["Email"].Value = userlist[i].Email;
                    dvgUserList.Rows[i].Cells["Rating"].Value = userlist[i].Rating;
                    
                }
            }
        }
    }
}
