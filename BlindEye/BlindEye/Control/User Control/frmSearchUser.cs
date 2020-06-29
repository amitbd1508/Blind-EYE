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

namespace BlindEye.Control.User_Control
{
    public partial class frmSearchUser : Form
    {
        public frmSearchUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMasterDto ud = new UserMasterDto();
            ud = UserMasterDao.GetByUserMasterUsername(txtSearch.Text);
            if(ud!=null)
            {

                lblName.Text += "  " + ud.UserFullName;
                lblEmail.Text += "  " + ud.Email;
                lblPhone.Text += " " + ud.PhoneNumber;
            }
        }

       
    }
}
