using BlindEye_Lib.Data_Access_Layer;
using BlindEye_Lib.Data_Object;
using BlindEye_Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls;


namespace BlindEye.Control.Books
{
    public partial class frmContentManage : Form
    {
        public frmContentManage()
        {
            InitializeComponent();
            Initiate();
        }
        private byte[] buffAudioData;
         
        void Initiate()
        {
            Load_cmbBook();
        }

        void Load_cmbBook()
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


            cmbBook.DataSource = _ItemList;
            cmbBook.DisplayMember = "DisplayMember";
            cmbBook.ValueMember = "ValueMember";
            cmbBook.SelectedValue = "-1";

        }
        void Load_cmbChapter(long BookID)
        {
            List<ChapterDto> Chapterlist = new List<ChapterDto>();

            Chapterlist = ChapterDao.GetByBookID(BookID);

            List<ComboItems> _ItemList = new List<ComboItems>();

            ComboItems Item;
            Item = new ComboItems();
            Item.DisplayMember = "Select";
            Item.ValueMember = "-1";
            _ItemList.Add(Item);

            foreach (ChapterDto chapter in Chapterlist)
            {
                Item = new ComboItems();
                Item.DisplayMember = chapter.ChapterName;
                Item.ValueMember = chapter.ChapterID.ToString();
                _ItemList.Add(Item);
            }


            cmbChapter.DataSource = _ItemList;
            cmbChapter.DisplayMember = "DisplayMember";
            cmbChapter.ValueMember = "ValueMember";
            cmbChapter.SelectedValue = "-1";

        }
        private void btnBrowesAudio_Click(object sender, EventArgs e)
        {

          
            DialogResult result = openFileDialogAudio.ShowDialog();

            if (result==DialogResult.OK) 
            {
                txtBrowesAudio.Text = openFileDialogAudio.FileName;

                FileStream fs = new FileStream(openFileDialogAudio.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                decimal numBytes = new FileInfo(openFileDialogAudio.FileName).Length;
                lblAudioSize.Text = ((numBytes / 1024) / 1024).ToString("#.##");
                 buffAudioData = File.ReadAllBytes(txtBrowesAudio.Text.ToString());  
      
            }
           
        }
        private void btnBrowesText_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogText.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBrowesText.Text = openFileDialogText.FileName;
                rtxtContent.Text = File.ReadAllText(openFileDialogText.FileName);
            }
            else 
            {
                rtxtContent.Text = String.Empty;
            }
        }

        private void cmbBook_SelectedValueChanged(object sender, EventArgs e)
        {
          

            try
            {
               
                    Load_cmbChapter(Convert.ToInt64(cmbBook.SelectedValue.ToString()));
               
            }
            catch (Exception ex) { }
        }

        private void cmbChapter_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tbcUpload.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbcUpload.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rtxtContent.Text == string.Empty)
            {
                MessageBox.Show("Please Provide content");
                return;
            }
                

            tbcUpload.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbcUpload.SelectedIndex = 1;
        }
        public void ini()
        {
            txtBrowesAudio.Text = string.Empty;
            txtBrowesText.Text = string.Empty;
            rtxtContent.Text = string.Empty;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
                ContentTextDto ctext = new ContentTextDto();
                ctext.BookID = Convert.ToInt64(cmbBook.SelectedValue.ToString());
                ctext.ChapterID = Convert.ToInt64(cmbChapter.SelectedValue.ToString());
                ctext.Content = rtxtContent.Text;
                ctext.CreatedBy = MDIParent._UserMasterID;
                ctext.CreatedDate = DateTime.Now;
                ctext.ModifyedBy = MDIParent._UserMasterID;
                ctext.ModifyDate = DateTime.Now;
                ctext.Remarks = rtxtRemarksForText.Text;
               
                if (ContentTextDao.Insert(ctext))
                {
                    MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   // ini();
                }
                else
                {
                    MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            
           


            //under cn

                if (txtBrowesAudio.Text.Trim() != string.Empty)
                {
                    ContentAudioDto caudio = new ContentAudioDto();
                    caudio.BookID = Convert.ToInt64(cmbBook.SelectedValue.ToString());
                    caudio.ChapterID = Convert.ToInt64(cmbChapter.SelectedValue.ToString());
                    caudio.Content = buffAudioData;
                    caudio.CreatedBy = MDIParent._UserMasterID;
                    caudio.CreatedDate = DateTime.Now;
                    caudio.ModifyedBy = MDIParent._UserMasterID;
                    caudio.ModifyDate = DateTime.Now;
                    ctext.Remarks = rtxtRemarksForAudio.Text;
                    if (ContentAudioDao.Insert(caudio))
                    {
                        MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ini();
                    }
                    else
                    {
                        MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                rtxtContent.Text = string.Empty;
                cmbBook.SelectedIndex = 0;
                cmbChapter.SelectedIndex = 0;
                tbcUpload.SelectedIndex = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
