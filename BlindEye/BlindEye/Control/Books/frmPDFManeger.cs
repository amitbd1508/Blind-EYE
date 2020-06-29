using BlindEye_Lib.Data_Access_Layer;
using BlindEye_Lib.Data_Object;
using BlindEye_Lib.Utilities;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AxAcroPDFLib;

namespace BlindEye.Control.Books
{
    public partial class frmPDFManeger : Form
    {
        public frmPDFManeger()
        {
            InitializeComponent();
            Initiate();
        }
        public String filePath;

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


            cmbBook.DataSource = _ItemList;
            cmbBook.DisplayMember = "DisplayMember";
            cmbBook.ValueMember = "ValueMember";
            cmbBook.SelectedValue = "-1";

        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
           
            dlg.Filter = "PDF Files(*.PDF)|*.PDF|ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName.ToString();
                
               //axAcroPDF1.Update();
              
                
            }

            txtPdfLocation.Text = filePath; 
        }

        private void InitializeAdobe(string filePath)
        {
            try
            {
                //this.axAcroPDF1.LoadFile(filePath);
                //this.axAcroPDF1.src = filePath;
                //this.axAcroPDF1.setShowToolbar(false);
                //this.axAcroPDF1.setView("FitH");
                //this.axAcroPDF1.setLayoutMode("SinglePage");
                //this.axAcroPDF1.Show();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(filePath!=string.Empty)
            try
            {

                PdfReader reder = new PdfReader(filePath);



                for (int page = 1; page <= reder.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    string s = PdfTextExtractor.GetTextFromPage(reder, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));

                    ChapterDto chapter = new ChapterDto();
                    chapter.ChapterName = "Page " + page;
                    chapter.BookID = Convert.ToInt64(cmbBook.SelectedValue.ToString());
                    chapter.CreatedBy = MDIParent._UserMasterID;
                    chapter.CreatedDate = DateTime.Now;
                    chapter.ModifyDate = DateTime.Now;
                    chapter.ModifyedBy = MDIParent._UserMasterID;
                    chapter.Remarks = rtxtDescreptio.Text.Trim();
                    

                    ChapterDao.Insert(chapter);


                    ContentTextDto ctext = new ContentTextDto();
                    ctext.BookID = Convert.ToInt64(cmbBook.SelectedValue.ToString());
                    ctext.ChapterID = page;
                    ctext.Content = s;
                    ctext.CreatedBy = MDIParent._UserMasterID;
                    ctext.CreatedDate = DateTime.Now;
                    ctext.ModifyedBy = MDIParent._UserMasterID;
                    ctext.ModifyDate = DateTime.Now;
                    ctext.Remarks = rtxtDescreptio.Text;
                    ContentTextDao.Insert(ctext);

                }
                
                MessageBox.Show(Constant.NOTIFICATION_SUCCESS_DATA_SAVING, Constant.NOTIFICATION_CAPTION_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(Constant.DBErrorMsg, Constant.NOTIFICATION_ERROR_DATA_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);

               
                MessageBox.Show(ex.Message);

            }
        }

        
    }
}
