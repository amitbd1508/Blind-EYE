using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlindEye.Control
{
    public partial class frmVoiceRecognigetion : Form
    {
        public frmVoiceRecognigetion()
        {
            InitializeComponent();
        }
        

        private void frmVoiceRecognigetion_Load(object sender, EventArgs e)
        {
            try
            {
                speekRecognigetion();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open Speech Recognigetion");


            }
            
        }
        
        public void speekRecognigetion()
        {



            SpeechRecognizer recognizer = new SpeechRecognizer();
            // Create a new SpeechRecognitionEngine instance.


            // Create a simple grammar that recognizes "red", "green", or "blue".
            Choices colors = new Choices();
            colors.Add(new string[] { "Amit", "blue", "pause", "stop", "play" });

            // Create a GrammarBuilder object and append the Choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);

            // Create the Grammar instance and load it into the speech recognition engine.
            Grammar g = new Grammar(gb);
            recognizer.LoadGrammar(g);

            // Register a handler for the SpeechRecognized event.
            recognizer.SpeechRecognized +=
              new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

        }
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //MessageBox.Show(e.Result.Text);
            MessageBox.Show("jhfhfghf");
            
            if (e.Result.Text == "play" || e.Result.Text=="blue")
            {
                
                speakingMetod();
            }
            


        }
        private void speakingMetod()
        {
           SpeechSynthesizer voice = new SpeechSynthesizer();

            try
            {
                
                voice.SelectVoiceByHints(VoiceGender.Male);
                        
         
                voice.SpeakAsync(richTextBox1.Text);
               // Pause.Enabled = true;
                //Stop.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Speak error", "Text to Speak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void button1_Click_Click(object sender, EventArgs e)
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
                    richTextBox1.Text = sr.ReadToEnd();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("can not open the file", "Text to Speak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
