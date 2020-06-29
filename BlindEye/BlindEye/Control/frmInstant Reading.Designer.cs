namespace BlindEye.Control
{
    partial class frmInstantReading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstantReading));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Speak = new System.Windows.Forms.Button();
            this.button1_Click = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtSpellBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(473, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 32;
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
            this.Stop.Location = new System.Drawing.Point(435, 489);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 31;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(473, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 68);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rate";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 29);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(242, 45);
            this.trackBar2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 29;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Volume";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(674, 442);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(674, 489);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 26;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(548, 489);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 25;
            this.save.Text = "Save to  wav";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Resume
            // 
            this.Resume.Location = new System.Drawing.Point(328, 489);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(75, 23);
            this.Resume.TabIndex = 24;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(227, 489);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 23;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Speak
            // 
            this.Speak.Location = new System.Drawing.Point(132, 489);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(75, 23);
            this.Speak.TabIndex = 22;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // button1_Click
            // 
            this.button1_Click.Location = new System.Drawing.Point(42, 487);
            this.button1_Click.Name = "button1_Click";
            this.button1_Click.Size = new System.Drawing.Size(75, 23);
            this.button1_Click.TabIndex = 21;
            this.button1_Click.Text = "Browse";
            this.button1_Click.UseVisualStyleBackColor = true;
            this.button1_Click.Click += new System.EventHandler(this.Browser_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(437, 396);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSpellBox
            // 
            this.txtSpellBox.Location = new System.Drawing.Point(479, 311);
            this.txtSpellBox.Name = "txtSpellBox";
            this.txtSpellBox.Size = new System.Drawing.Size(251, 49);
            this.txtSpellBox.TabIndex = 33;
            this.txtSpellBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Spelling";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "==>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(659, 12);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 37;
            this.btnStatus.Text = "Menual";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmInstantReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 543);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpellBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.button1_Click);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInstantReading";
            this.Text = "Instant Reading Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInstantReading_FormClosed);
            this.Load += new System.EventHandler(this.frmInstant_Reading_Load);
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

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Button button1_Click;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox txtSpellBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStatus;
    }
}