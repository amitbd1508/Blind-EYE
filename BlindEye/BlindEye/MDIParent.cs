using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BlindEye.Control;
using BlindEye.Control.User_Control;
using BlindEye_Lib.Data_Object;
using BlindEye.Control.Books;
using BlindEye.Control.BookReading;
using BlindEye.Control.Utility;

namespace BlindEye
{
    public partial class MDIParent : Form
    {
        public   UserMasterDto user=new UserMasterDto();
        public static long _UserMasterID;
        private int childFormNumber = 0;
        #region
        public MDIParent()
        {
            InitializeComponent();
        }

        public MDIParent(UserMasterDto user)
        {
            InitializeComponent();
            this.user = user;
            tslblUserName.Text +=" : "+ user.UserFullName;
            _UserMasterID = this.user.UserMasterID;
            if(user.AccountType==1)
            {
                btnSellProduct.Enabled = false;
                userToolStripMenuItem.Enabled = false;
                btnVendorSettings.Enabled = false;

            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion


        frmCreateUser _frmCreateUser;
        frmResetPassword _frmResetPassword;
        frmBooks _frmAddNewBook;
        frmChapter _frmChapter;
        frmContentManage _frmContentManage;
        frmStatistics _frmStatistics;
        frmInstantReading _frmInstantReading;
        frmPDFManeger _frmPDFManeger;
        frmBookReader _frmBookReader;
        frmUserRating _frmUserRating;
        frmAbout _frmAbout;
        frgLogIn _frgLogIn;
        //modify User
        

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmCreateUser == null || _frmCreateUser.IsDisposed)
            {
                _frmCreateUser = new frmCreateUser();
                _frmCreateUser.MdiParent = this;
            }

            _frmCreateUser.Show();
            _frmCreateUser.BringToFront();
        }

        private void modifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbChangeMyPassword_Click(object sender, EventArgs e)
        {
            if (_frmResetPassword == null || _frmResetPassword.IsDisposed)
            {
                _frmResetPassword = new frmResetPassword(user);
                _frmResetPassword.MdiParent = this;
            }

            _frmResetPassword.Show();
            _frmResetPassword.BringToFront();
        }

        private void bookTitleMangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmAddNewBook == null || _frmAddNewBook.IsDisposed)
            {
                _frmAddNewBook = new frmBooks();
                _frmAddNewBook.MdiParent = this;
            }

            _frmAddNewBook.Show();
            _frmAddNewBook.BringToFront();
        }

        private void chapterManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_frmChapter
            if (_frmChapter == null || _frmChapter.IsDisposed)
            {
                _frmChapter = new frmChapter();
                _frmChapter.MdiParent = this;
            }

            _frmChapter.Show();
            _frmChapter.BringToFront();
        }

       

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (_frmStatistics == null || _frmStatistics.IsDisposed)
            {
                _frmStatistics = new frmStatistics();
                _frmStatistics.MdiParent = this;
            }

            _frmStatistics.Show();
            _frmStatistics.BringToFront();

        }

        private void btnPaymentSell_Click(object sender, EventArgs e)
        {
            if (_frmInstantReading == null || _frmInstantReading.IsDisposed)
            {
                _frmInstantReading = new frmInstantReading();
                _frmInstantReading.MdiParent = this;
            }

            _frmInstantReading.Show();
            _frmInstantReading.BringToFront();

        }

        private void MDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void contkenManagetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmContentManage == null || _frmContentManage.IsDisposed)
            {
                _frmContentManage = new frmContentManage();
                _frmContentManage.MdiParent = this;
            }

            _frmContentManage.Show();
            _frmContentManage.BringToFront();
        }

        private void pDFManegerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmPDFManeger == null || _frmPDFManeger.IsDisposed)
            {
                _frmPDFManeger = new frmPDFManeger();
                _frmPDFManeger.MdiParent = this;
            }

            _frmPDFManeger.Show();
            _frmPDFManeger.BringToFront();
        }

        private void bookReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmBookReader == null || _frmBookReader.IsDisposed)
            {
                _frmBookReader = new frmBookReader();
                _frmBookReader.MdiParent = this;
            }

            _frmBookReader.Show();
            _frmBookReader.BringToFront();
        }

        private void ratingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmUserRating == null || _frmUserRating.IsDisposed)
            {
                _frmUserRating = new frmUserRating();
                _frmUserRating.MdiParent = this;
            }

            _frmUserRating.Show();
            _frmUserRating.BringToFront();
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {

            if (_frmCreateUser == null || _frmCreateUser.IsDisposed)
            {
                _frmCreateUser = new frmCreateUser();
                _frmCreateUser.MdiParent = this;
            }

            _frmCreateUser.Show();
            _frmCreateUser.BringToFront();

        }

        private void btnVendorSettings_Click(object sender, EventArgs e)
        {
            if (_frmCreateUser == null || _frmCreateUser.IsDisposed)
            {
                _frmCreateUser = new frmCreateUser();
                _frmCreateUser.MdiParent = this;
            }

            _frmCreateUser.Show();
            _frmCreateUser.BringToFront();
        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {

            if (_frmPDFManeger == null || _frmPDFManeger.IsDisposed)
            {
                _frmPDFManeger = new frmPDFManeger();
                _frmPDFManeger.MdiParent = this;
            }

            _frmPDFManeger.Show();
            _frmPDFManeger.BringToFront();
        }

       

        

        private void btnShowSell_Click(object sender, EventArgs e)
        {
            if (_frmAddNewBook == null || _frmAddNewBook.IsDisposed)
            {
                _frmAddNewBook = new frmBooks();
                _frmAddNewBook.MdiParent = this;
            }

            _frmAddNewBook.Show();
            _frmAddNewBook.BringToFront();
        }
        frmSearchUser _frmSearchUser;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_frmSearchUser == null || _frmSearchUser.IsDisposed)
            {
                _frmSearchUser = new frmSearchUser();
                _frmSearchUser.MdiParent = this;
            }

            _frmSearchUser.Show();
            _frmSearchUser.BringToFront();
        }

        private void aboutToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            if (_frmAbout == null || _frmAbout.IsDisposed)
            {
                _frmAbout = new frmAbout();
                _frmAbout.MdiParent = this;
            }

            _frmAbout.Show();
            _frmAbout.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (_frmAbout == null || _frmAbout.IsDisposed)
            {
                _frmAbout = new frmAbout();
                _frmAbout.MdiParent = this;
            }

            _frmAbout.Show();
            _frmAbout.BringToFront();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            _frgLogIn.Show();

        }
        testfrm _testfrm;
        private void sampleQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (_testfrm == null || _testfrm.IsDisposed)
            {
                _testfrm = new testfrm();
                _testfrm.MdiParent = this;
            }

            _testfrm.Show();
            _testfrm.BringToFront();

        }
        

      

       
    }
}
