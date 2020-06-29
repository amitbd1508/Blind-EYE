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
    public partial class frmInstantReading : Form
    {
        public frmInstantReading()
        {
            InitializeComponent();
        }
        
        private void frmInstant_Reading_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Enter your text for";
            comboBox1.Text = "NotSet";
            Pause.Enabled = false;
            Resume.Enabled = false;
           

            speekRecognigetion();

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
        public SpeechSynthesizer voice = new SpeechSynthesizer();
        private void Browser_Click(object sender, EventArgs e)
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


                voice.SpeakAsync(richTextBox1.Text);
                Pause.Enabled = true;
                Stop.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Speak error", "Text to Speak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                voice.Speak(richTextBox1.Text);
                fs.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voice.Pause();
            Resume.Enabled = true;
            txtSpellBox.Text = richTextBox1.SelectedText;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer spell = new SpeechSynthesizer();
            voice.Volume = trackBar1.Value;
            voice.Rate = trackBar2.Value;
            voice.SelectVoiceByHints(VoiceGender.Male);
            String spel = txtSpellBox.Text;
            foreach (Char c in spel)
            {
                String cString = c.ToString();
                spell.Speak(cString);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region mm
            if (btnStatus.Text == "Menual")
            {
                btnStatus.Text = "Voice";
                Speak.Enabled = false;



            }
            else
            {
                Speak.Enabled = true;
                btnStatus.Text = "Menual";
            }
            #endregion


            

        }
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (btnStatus.Text == "Voice")
            {
                if (e.Result.Text == "play")
                {
                    speakingMetod();
                }
            }
            
            
        }

        private void frmInstantReading_FormClosed(object sender, FormClosedEventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }
       
    }
}