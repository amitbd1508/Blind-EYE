using BlindEye_Lib;
using BlindEye_Lib.Data_Object;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
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

namespace BlindEye.Control
{
    public partial class frmAddNewBook : Form
    {
        public frmAddNewBook()
        {
            InitializeComponent();
        }
        public List<string> convertedTextFromPdf = new List<string>();
        public bool ispdf = false;

        private void button1_Click(object sender, EventArgs e)
        {
            string bookText = "", fileName="" ;
            if (comboBox1.Text == "Text(.txt)")
            {
                try
                {

                    OpenFileDialog ofd = new OpenFileDialog();

                    ofd.CheckFileExists = true;
                    ofd.CheckPathExists = true;
                    ofd.DefaultExt = "txt";
                    ofd.DereferenceLinks = true;
                    ofd.Filter = "Text files (*.txt)|*.txt|" + "RTF files (*.rtf)|*.rtf|" + "Works 6 and 7 (*.wps)|*.wps|" +
                                      "Windows Write (*.wri)|*.wri|" + "WordPerfect document (*.wpd)|*.wpd";
                    ofd.Multiselect = false;
                    ofd.RestoreDirectory = true;
                    ofd.ShowHelp = true;
                    ofd.ShowReadOnly = false;
                    ofd.Title = "select a file";
                    ofd.ValidateNames = true;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        StreamReader sr = new StreamReader(ofd.OpenFile());
                        //richTextBox1.Text = sr.ReadToEnd();
                        bookText = sr.ReadToEnd();
                        frmPreviewText pvt = new frmPreviewText();
                        pvt.setRichBox(bookText);
                        pvt.Show();
                        fileName = System.IO.Path.GetFileName(ofd.FileName);
                        lblSaveFileName.Text="File Name: "+fileName;
                        
                        
                      
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("can not open the file", "Text to Speak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if(comboBox1.Text=="PDF(.PDF)")
            {
                ispdf = true;
                OpenFileDialog dlg = new OpenFileDialog();
                String filePath;
                dlg.Filter = "PDF Files(*.PDF)|*.PDF|ALL Files(*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.FileName.ToString();

                    try
                    {

                        PdfReader reder = new PdfReader(filePath);
                        for (int page = 1; page <= reder.NumberOfPages; page++)
                        {
                            ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                            string s = PdfTextExtractor.GetTextFromPage(reder, page, its);
                            s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                            convertedTextFromPdf.Add(s);
                           
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }

            }


        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            BookDto book = new BookDto();
            book.AuthorName = txtAuthorName.Text.Trim();
            book.BookName = txtBookName.Text.Trim();
            book.CreatedBy = LoginSeson.userMasterID;
            book.CreatedDate = DateTime.Today;
            book.Remarks = txtRemarks.Text;
            int j;
            if (Int32.TryParse(txtReleseYear.Text, out j))
                book.ReleseYear = j;
            else MessageBox.Show("Invalid Year","Invalid Year Formet",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            



        }

    }
}
