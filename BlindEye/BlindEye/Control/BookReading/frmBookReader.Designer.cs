namespace BlindEye.Control.BookReading
{
    partial class frmBookReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpellBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Speak = new System.Windows.Forms.Button();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.cmbChapter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblChapter = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnrate = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "==>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Spelling";
            // 
            // txtSpellBox
            // 
            this.txtSpellBox.Location = new System.Drawing.Point(536, 423);
            this.txtSpellBox.Name = "txtSpellBox";
            this.txtSpellBox.Size = new System.Drawing.Size(251, 60);
            this.txtSpellBox.TabIndex = 51;
            this.txtSpellBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(536, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NotSet",
            "Male",
            "Female",
            "Neutral",
            " "});
            this.comboBox1.Location = new System.Drawing.Point(19, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(324, 545);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(107, 32);
            this.Stop.TabIndex = 49;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(536, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 56);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rate";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 19);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(242, 45);
            this.trackBar2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 73);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 35);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(251, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 100;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(692, 545);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 32);
            this.Exit.TabIndex = 45;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(563, 545);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 32);
            this.clear.TabIndex = 44;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(437, 545);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 32);
            this.save.TabIndex = 43;
            this.save.Text = "Save to  wav";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Resume
            // 
            this.Resume.Location = new System.Drawing.Point(217, 545);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(101, 32);
            this.Resume.TabIndex = 42;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(116, 545);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(95, 32);
            this.Pause.TabIndex = 41;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Speak
            // 
            this.Speak.Location = new System.Drawing.Point(21, 545);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(89, 32);
            this.Speak.TabIndex = 40;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(19, 197);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(506, 337);
            this.rtxtContent.TabIndex = 38;
            this.rtxtContent.Text = "";
            // 
            // cmbChapter
            // 
            this.cmbChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbChapter.FormattingEnabled = true;
            this.cmbChapter.Location = new System.Drawing.Point(95, 61);
            this.cmbChapter.Name = "cmbChapter";
            this.cmbChapter.Size = new System.Drawing.Size(220, 26);
            this.cmbChapter.TabIndex = 287;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 286;
            this.label3.Text = "Chapter :";
            // 
            // cmbBook
            // 
            this.cmbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(95, 29);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(222, 26);
            this.cmbBook.TabIndex = 289;
            this.cmbBook.SelectedIndexChanged += new System.EventHandler(this.cmbBook_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 288;
            this.label4.Text = "Book :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 290;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblBookName.Location = new System.Drawing.Point(16, 127);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(93, 17);
            this.lblBookName.TabIndex = 291;
            this.lblBookName.Text = "Book Name : ";
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChapter.Location = new System.Drawing.Point(16, 155);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(111, 17);
            this.lblChapter.TabIndex = 292;
            this.lblChapter.Text = "Chapter Name : ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button4.Location = new System.Drawing.Point(433, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 293;
            this.button4.Text = "Next Chapter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(329, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 294;
            this.button5.Text = "PreviousChapter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRate.Location = new System.Drawing.Point(638, 29);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(147, 17);
            this.lblRate.TabIndex = 295;
            this.lblRate.Text = "Thank You For Rating";
            // 
            // btnrate
            // 
            this.btnrate.Location = new System.Drawing.Point(641, 31);
            this.btnrate.Name = "btnrate";
            this.btnrate.Size = new System.Drawing.Size(152, 23);
            this.btnrate.TabIndex = 296;
            this.btnrate.Text = "Rate The Uploader";
            this.btnrate.UseVisualStyleBackColor = true;
            this.btnrate.Click += new System.EventHandler(this.btnrate_Click);
            // 
            // frmBookReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(831, 581);
            this.Controls.Add(this.btnrate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblChapter);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbChapter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpellBox);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.rtxtContent);
            this.Name = "frmBookReader";
            this.Text = "Book Reader";
//            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBookReader_FormClosed);
            this.Load += new System.EventHandler(this.frmBookReader_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSpellBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.ComboBox cmbChapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnrate;
    }
}