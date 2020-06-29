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
    public partial class frmCreateUser : Form
    {
        long _UserMasterID;
        public frmCreateUser()
        {
            InitializeComponent();
            Initiate();

        }

        void Initiate() 
        {
            Load_cmbAcctType();
            txtUserFullName.Text = string.Empty;
            txtUserFullName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtUserFullName.Focus();
           // dtpDateOfBirth.Text = "Not Set";
            textUserName.Text = string.Empty;
            textUserName.Enabled = true;
            txtPassword.Enabled = true;
            _UserMasterID = -1;

            LoadGride();
        }

        private void LoadGride()
        {
            dgvUserList.Rows.Clear();
            dgvUserList.Columns.Clear();

            dgvUserList.Columns.Add("UserMasterID", "");
            dgvUserList.Columns.Add("UserFullName", "User Full Name");
            dgvUserList.Columns.Add("DateOFBirth", "DateOfBirth");
            dgvUserList.Columns.Add("Emial", "Email Address");
            dgvUserList.Columns.Add("Phone", "Phone Number");
            dgvUserList.Columns.Add("UserID", "User Name");
            dgvUserList.Columns.Add("AccountType", "Account Type");
            dgvUserList.Columns.Add("Rating", "Rating");

            dgvUserList.Columns["UserFullName"].Width = 150;
            dgvUserList.Columns["DateOFBirth"].Width =100;
            dgvUserList.Columns["Emial"].Width = 100;
            dgvUserList.Columns["Phone"].Width = 100;
            dgvUserList.Columns["UserID"].Width = 120;
            dgvUserList.Columns["Rating"].Width = 70;
            

            dgvUserList.Columns["UserMasterID"].Visible = false;
            List<UserMasterDto> userList = new List<UserMasterDto>();

            try
            {
                userList = UserMasterDao.GetAll();
            }
            catch (Exception ex) { }


            if (userList.Count > 0)
            {

                for (int i = 0; i < userList.Count; i++)
                {
                    dgvUserList.Rows.Add();
                    dgvUserList.Rows[i].Cells["UserMasterID"].Value = userList[i].UserMasterID;
                    dgvUserList.Rows[i].Cells["UserID"].Value = userList[i].UserName;
                    dgvUserList.Rows[i].Cells["UserFullName"].Value = userList[i].UserFullName;
                    dgvUserList.Rows[i].Cells["DateOFBirth"].Value = userList[i].DateOfBirth.ToString("dd-MMM-yyyy");
                    dgvUserList.Rows[i].Cells["Emial"].Value = userList[i].Email;

                    dgvUserList.Rows[i].Cells["Phone"].Value = userList[i].PhoneNumber;
                    dgvUserList.Rows[i].Cells["AccountType"].Value = userList[i].AccountType;
                    dgvUserList.Rows[i].Cells["Rating"].Value = userList[i].Rating;
                }
            }
        }
        void Load_cmbAcctType()
        {

           
            List<ComboItems> _ItemList = new List<ComboItems>();

            ComboItems Item;
            Item = new ComboItems();
            Item.DisplayMember = "Select";
            Item.ValueMember = "-1";
            _ItemList.Add(Item);

            Item = new ComboItems();
            Item.DisplayMember = "Admin";
            Item.ValueMember = "0";
            _ItemList.Add(Item);

            Item = new ComboItems();
            Item.DisplayMember = "User";
            Item.ValueMember = "1";
            _ItemList.Add(Item);

          
            cmbAcctType.DataSource = _ItemList;
            cmbAcctType.DisplayMember = "DisplayMember";
            cmbAcctType.ValueMember = "ValueMember";
            cmbAcctType.SelectedValue = "-1";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (cmbAcctType.SelectedValue == "-1") 
            {
                MessageBox.Show(Constant.NOTIFICATION_MESSEGE_COMBOBOX_SELECTION, Constant.NOTIFICATION_CAPTION_COMBOBOX_SELECTION,MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            if (txtUserFullName.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtPhoneNumber.Text.Trim() == string.Empty)
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
            if (txtPhoneNumber.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtEmail.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dtpDateOfBirth.Value==DateTime.Now)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            //rest all validation


            UserMasterDto user = new UserMasterDto();
       
            user.UserName = textUserName.Text.Trim();
            user.Password = txtPassword.Text;
            user.UserFullName = txtUserFullName.Text;
            user.DateOfBirth = dtpDateOfBirth.Value;
            user.Email = txtEmail.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.AccountType = Convert.ToInt16(cmbAcctType.SelectedValue.ToString());
            user.Rating = 0;

            if (_UserMasterID > 0)
            {
                user.UserMasterID = _UserMasterID;

                if (UserMasterDao.Update(user))
                {
                    MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Initiate();
                }
                else
                {
                    MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (UserMasterDao.Insert(user))
                {
                    MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Initiate();
                }
                else
                {
                    MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Initiate();
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                _UserMasterID = Convert.ToInt64(dgvUserList.Rows[e.RowIndex].Cells[0].Value);
                UserMasterDto user = new UserMasterDto();
                user = UserMasterDao.GetByUserMasterID(_UserMasterID);
                 FromObjectToFrom(user);
             
                
            }
        }

        private void FromObjectToFrom(UserMasterDto user)
        {
            cmbAcctType.SelectedValue = user.AccountType.ToString();
            txtUserFullName.Text = user.UserFullName;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtPassword.Text = user.Password;
            txtEmail.Text = user.Email;
            textUserName.Text = user.UserName;
            dtpDateOfBirth.Value = user.DateOfBirth;

            txtPassword.Enabled = false;
            textUserName.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(UserMasterDao.DeleteByID(_UserMasterID))
            {
                 MessageBox.Show("Succesfully Deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 Initiate();
            }
            else
            {

                MessageBox.Show("Oparetion Unsuccesfull ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

   
    }
}
