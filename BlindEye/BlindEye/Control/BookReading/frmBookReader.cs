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
using BlindEye_Lib.For_project_recurment;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.IO;

namespace BlindEye.Control.BookReading
{
    public partial class frmBookReader : Form
    {
        List<string> list = new List<string>();
        public frmBookReader()
        {
            InitializeComponent();
            Initiate();
        }
        void Initiate()
        {
            Load_cmbBook();
        }
        public static int countChapter=0;
        private void button3_Click(object sender, EventArgs e)
        {
            ContentTextDto ctext = new ContentTextDto();
            ctext.BookID = Convert.ToInt64(cmbBook.SelectedValue.ToString());
            try
            {
                ctext.ChapterID = Convert.ToInt64(cmbChapter.SelectedValue.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Select Book Name", "Book Name not selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            //uncomplete join is not needed
            //This query is used for only projecet show join and sub query
            //Original query is not Same and no complex
            string sql = "select tblContentText.content as ContentText from tblContentText join tblChapter "
                + "on tblChapter.ChapterID=tblContentText.ChapterID and "
                + "tblContentText.BookId in(select tblBook.BookID from tblBook join tblChapter "
                + "on tblBook.BookID=tblChapter.BookId and   tblBook.BookID="+Convert.ToInt64(cmbBook.SelectedValue)+");";
            string s = "";
          //  MessageBox.Show(sql);
            list = ExtrafaltuClass.FaltuqueryForfrmBookReader(sql);
            
            
            if(list.Count>=0)
            {
                lblBookName.Text = "Book Name : " + this.cmbBook.GetItemText(this.cmbBook.SelectedItem);
                lblChapter.Text = "Chapter Name : " + this.cmbChapter.GetItemText(this.cmbChapter.SelectedItem);
                try
                {
                    rtxtContent.Text = list[countChapter];
                    countChapter++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Chapter not founf", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            

            
               
            
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

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                    Load_cmbChapter(Convert.ToInt64(cmbBook.SelectedValue.ToString()));
               
            }
            catch (Exception ex) { }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            if (countChapter >= list.Count)
                MessageBox.Show("No Chapter Available", "Chapter Not Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
            if(countChapter+1>=0 && countChapter+1<list.Count)
            {
                cmbChapter.SelectedIndex = countChapter + 1+1; 
                
                lblBookName.Text = "Book Name : " + this.cmbBook.GetItemText(this.cmbBook.SelectedItem);
                lblChapter.Text = "Chapter Name : " + this.cmbChapter.GetItemText(this.cmbChapter.SelectedItem);
                rtxtContent.Text = list[countChapter+1];
                countChapter++;

            }


        }
       
        private void button5_Click(object sender, EventArgs e)
        {
           
            if (countChapter-1 >= 0)
            {
                cmbChapter.SelectedIndex = countChapter - 1+1; 
                
                rtxtContent.Text = list[countChapter-1];
                countChapter--;
                lblBookName.Text = "Book Name : " + this.cmbBook.GetItemText(this.cmbBook.SelectedItem);
                lblChapter.Text = "Chapter Name : " + this.cmbChapter.GetItemText(this.cmbChapter.SelectedItem);

            }
            else
                MessageBox.Show("No Chapter Available", "Chapter Not Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        //voice 
        public SpeechSynthesizer voice = new SpeechSynthesizer();

        private void speakingMetod()
        {


            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "NotSet":
                        voice.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                    case "Male":
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case "Female":
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case "Neutral":
                        voice.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                }


                voice.Volume = trackBar1.Value;
                voice.Rate = trackBar2.Value;


                voice.SpeakAsync(lblBookName.Text+"      "+lblChapter.Text+"            "+rtxtContent.Text.Trim());
                Pause.Enabled = true;
                Stop.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Speak error", "Text to Speak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer spell = new SpeechSynthesizer();
            spell.Volume = trackBar1.Value;
            spell.Rate = trackBar2.Value;
            spell.SelectVoiceByHints(VoiceGender.Male);
            String spel = txtSpellBox.Text;
            foreach (Char c in spel)
            {
                String cString = c.ToString();
                spell.Speak(cString);
            }
        }

        private void frmBookReader_Load(object sender, EventArgs e)
        {
            
            comboBox1.Text = "NotSet";
            Pause.Enabled = false;
            Resume.Enabled = false;
        }

        private void Speak_Click(object sender, EventArgs e)
        {
            speakingMetod();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            voice.Pause();
            Resume.Enabled = true;
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            voice.Resume();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav";
            sfd.Title = "Save to a wave file";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                voice.SetOutputToWaveStream(fs);
                voice.Speak(rtxtContent.Text);
                fs.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            rtxtContent.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voice.Pause();
            Resume.Enabled = true;
            txtSpellBox.Text = rtxtContent.SelectedText;
        }

        private void btnrate_Click(object sender, EventArgs e)
        {
            BookDto bd = new BookDto();
            bd = BookDao.GetByID(Convert.ToInt64(cmbBook.SelectedValue));
            
            if (UserMasterDao.UpdateRatingByOne(bd.CreatedBy))
            {
                btnrate.Visible = false;

            }
        }

        
    
    }
}
