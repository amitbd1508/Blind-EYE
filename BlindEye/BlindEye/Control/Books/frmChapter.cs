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

namespace BlindEye.Control.Books
{
    public partial class frmChapter : Form
    {
        public frmChapter()
        {
            InitializeComponent();
            Initiate();
        }

        private void Initiate()
        {
            Load_cmbAcctType();
        }
        void Load_cmbAcctType()
        {
            List<BookDto> bookList = new List<BookDto>();

            bookList = BookDao.GetAll();

            List<ComboItems> _ItemList = new List<ComboItems>();

            ComboItems Item;
            Item = new ComboItems();
            Item.DisplayMember = "Select";
            Item.ValueMember = "-1";
            _ItemList.Add(Item);

            foreach (BookDto book in bookList)
            {
                Item = new ComboItems();
                Item.DisplayMember = book.BookName;
                Item.ValueMember = book.BookID.ToString();
                _ItemList.Add(Item);
            }


            cmbBooks.DataSource = _ItemList;
            cmbBooks.DisplayMember = "DisplayMember";
            cmbBooks.ValueMember = "ValueMember";
            cmbBooks.SelectedValue = "-1";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtChapterName.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
           
            ChapterDto chapter = new ChapterDto();
            chapter.ChapterName = txtChapterName.Text.Trim();
            chapter.BookID =Convert.ToInt64( cmbBooks.SelectedValue.ToString());
            chapter.CreatedBy = MDIParent._UserMasterID;
            chapter.CreatedDate = DateTime.Now;
            chapter.ModifyDate = DateTime.Now;
            chapter.ModifyedBy = MDIParent._UserMasterID;
            chapter.Remarks = rtxtDescription.Text.Trim();

            if (ChapterDao.Insert(chapter))
            {
                txtChapterName.Text = string.Empty;
                rtxtDescription.Text = string.Empty;

                MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            else
            {
                MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
