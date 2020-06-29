using BlindEye_Lib.Data_Access_Layer;
using BlindEye_Lib.Data_Object;
using BlindEye_Lib.Utilities;
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
    public partial class frmResetPassword : Form
    {
        private UserMasterDto user;

        public frmResetPassword()
        {
            InitializeComponent();
            textUserName.Enabled = false;
        }

        public frmResetPassword(string UserName)
        {
            InitializeComponent();
            textUserName.Text = UserName;
            textUserName.Enabled = false;
        }

        public frmResetPassword(UserMasterDto user)
        {
            InitializeComponent();
            this.user = user;
            textUserName.Text = this.user.UserName;
            textUserName.Enabled = false;
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRetypePassword.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtNewPassword.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (textUserName.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtPassword.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtNewPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show("Password doesn't match", "Password match error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            UserMasterDto user = new UserMasterDto();

            user.UserName = textUserName.Text.Trim();
            user.Password = txtNewPassword.Text;

            if (UserMasterDao.ResetPasswordUpdate(user))
            {
                MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNewPassword.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtRetypePassword.Text = string.Empty;
                textUserName.Text = string.Empty;
                this.Close();
            }
            else
            {
                MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text)) 
            {
                if (!UserMasterDao.LoginCheck(user.UserName, txtPassword.Text)) 
                {
                    MessageBox.Show(Constant.NOTIFICATION_INVALID_PASSWORD, Constant.NOTIFICATION_CAPTION_INVALID_PASSWORD, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }                            
            }
        }
    }
}
