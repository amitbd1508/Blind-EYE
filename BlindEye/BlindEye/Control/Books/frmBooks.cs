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
    public partial class frmBooks : Form
    {
        
        long bookid;
        public frmBooks()
        {
            InitializeComponent();
            Initiate();
        }
        void Initiate()
        {
         
            txtBookName.Text = string.Empty;
            txtAuthorName.Text = string.Empty;
            txtReleseYear.Text = string.Empty;
            rtxtDescription.Text = string.Empty;

            bookid = -1;
            LoadGride();
        }

        private void LoadGride()
        {
            dgvBookList.Rows.Clear();
            dgvBookList.Columns.Clear();

            dgvBookList.Columns.Add("BookID", "");
            dgvBookList.Columns.Add("BookName", "Book Name");
            dgvBookList.Columns.Add("AuthorName", "Author Name");
            dgvBookList.Columns.Add("ReleaseYear", "Release Year");
            dgvBookList.Columns.Add("Remarks", "Remarks");

            dgvBookList.Columns["BookName"].Width = 150;
            dgvBookList.Columns["AuthorName"].Width = 100;
            dgvBookList.Columns["ReleaseYear"].Width = 100;
            dgvBookList.Columns["Remarks"].Width = 100;


            dgvBookList.Columns["BookID"].Visible = false;
            List<BookDto> bookList = new List<BookDto>();
            try
            {
                bookList = BookDao.GetAll();
            }
            catch (Exception ex) { }


            if (bookList.Count > 0)
            {

                for (int i = 0; i < bookList.Count; i++)
                {
                    dgvBookList.Rows.Add();
                    dgvBookList.Rows[i].Cells["BookID"].Value = bookList[i].BookID;
                    dgvBookList.Rows[i].Cells["BookName"].Value = bookList[i].BookName;
                    dgvBookList.Rows[i].Cells["AuthorName"].Value = bookList[i].AuthorName;
                    dgvBookList.Rows[i].Cells["ReleaseYear"].Value = bookList[i].ReleseYear;
                    dgvBookList.Rows[i].Cells["Remarks"].Value = bookList[i].Remarks;                    
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            
            if (txtAuthorName.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtBookName.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtReleseYear.Text.Trim() == string.Empty)
            {              

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else 
            {
                int ry;
                if (!int.TryParse(txtReleseYear.Text.Trim(), out ry))
                {
                    MessageBox.Show(Constant.NOTIFICATION_MSG_INT, Constant.NOTIFICATION_DATA_MUST_BE_INTEGER, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            if (rtxtDescription.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, Constant.NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            BookDto _book = new BookDto();
            _book = BookDao.GetByID(bookid);
            BookDto book = new BookDto();
            book.BookName = txtBookName.Text.ToString();
            book.AuthorName = txtAuthorName.Text;
            book.ReleseYear = Convert.ToInt16(txtReleseYear.Text.ToString());
            book.Remarks = rtxtDescription.Text;

            if (bookid > 0)
            {
                book.BookID = bookid;
                book.CreatedDate = _book.CreatedDate;
                book.CreatedBy = _book.CreatedBy;
                book.ModifyedBy = MDIParent._UserMasterID;
                book.ModifyDate = DateTime.Now;
                //Update
                if (BookDao.Update(book))
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
                book.CreatedBy = MDIParent._UserMasterID;
                book.CreatedDate = DateTime.Now;
                book.ModifyedBy = MDIParent._UserMasterID;
                book.ModifyDate = DateTime.Now;
                //Insert

                if (BookDao.Insert(book))
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

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex > -1)
            {

                bookid = Convert.ToInt64(dgvBookList.Rows[e.RowIndex].Cells[0].Value);
                BookDto book = new BookDto();
                book = BookDao.GetByID(bookid);
                FromObjectToFrom(book);
             
                
            }
        }

        private void FromObjectToFrom(BookDto book)
        {
            txtBookName.Text = book.BookName;
            txtAuthorName.Text = book.AuthorName;
            txtReleseYear.Text =Convert.ToString( book.ReleseYear);
            rtxtDescription.Text = book.Remarks;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Initiate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(BookDao.DeleteByID(bookid))
            {
                MessageBox.Show("Succesfully Deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Initiate();
            }
            else
            {
                MessageBox.Show("Oparetion Unsuccesfull ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
