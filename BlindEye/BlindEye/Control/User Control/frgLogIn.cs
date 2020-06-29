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
    public partial class frgLogIn : Form
    {
        public frgLogIn()
        {
            InitializeComponent();
        }

        private void frgLogIn_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "user name";
            txtUserName.Font = new Font(txtUserName.Font, FontStyle.Italic);
            txtUserName.ForeColor = Color.DarkGray;

            txtPassword.Text = "password";
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
            txtPassword.ForeColor = Color.DarkGray;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "user name")
            {
                txtUserName.Text = "";
                txtUserName.Font = new Font(txtUserName.Font, FontStyle.Regular);
                txtUserName.ForeColor = Color.Navy;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                txtUserName.Text = "user name";
                txtUserName.Font = new Font(txtUserName.Font, FontStyle.Italic);
                txtUserName.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
                txtPassword.ForeColor = Color.Navy;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                txtPassword.Text = "password";
                txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
                txtPassword.ForeColor = Color.DarkGray;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you really want to exit from this application ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
                
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;

            }


            bool IsValid = false;
            UserMasterDto user = new UserMasterDto();
            IsValid = UserMasterDao.LoginCheck(txtUserName.Text.Trim(), txtPassword.Text, out user);
            



            if (IsValid) 
            {
                MDIParent mdi = new MDIParent(user);
                mdi.IsMdiContainer = true;
                mdi.Show();
                mdi.BringToFront();
                this.Hide();
            }






            //if (txtUserName.Text == "user name")
            //{
            //    MessageBox.Show("Please intput your user name.", "User Name is required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtUserName.Focus();
            //}
            //else if (txtPassword.Text == "password")
            //{
            //    MessageBox.Show("Please intput your password.", "Password is required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtPassword.Focus();
            //}
            //else
            //{
            //    USER_MASTER _user = new USER_MASTER();
            //    try
            //    {
            //        using (BaseManager manager = new BaseManager())
            //        {
            //            _user = manager.GetManagerInstance<UserManager>().GetUserByNameORPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            //        }
            //        if (_user != null)
            //        {
            //            frmMDIParent _parent = new frmMDIParent(_user.USERNAME, _user.USERFULLNAME);
            //            _parent.Show();
            //            _parent.BringToFront();
            //            this.Hide();


            //        }
            //        else
            //        {
            //            MessageBox.Show("Login ID/Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }



            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message, "Fatal Error Occured!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
        }

        private void lnlForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Goto Forget Option
            //MessageBox.Show("Comming Soon..................!", "Under Constraction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            new frmForgetPassword().Show();

        }
    }
}
