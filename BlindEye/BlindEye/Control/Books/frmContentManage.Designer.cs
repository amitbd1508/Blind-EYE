namespace BlindEye.Control.Books
{
    partial class frmContentManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContentManage));
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogAudio = new System.Windows.Forms.OpenFileDialog();
            this.tbpFinal = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAudioSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBrowesAudio = new System.Windows.Forms.Button();
            this.txtBrowesAudio = new System.Windows.Forms.TextBox();
            this.rtxtRemarksForAudio = new System.Windows.Forms.RichTextBox();
            this.tbpUploadText = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtRemarksForText = new System.Windows.Forms.RichTextBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.txtBrowesText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowesText = new System.Windows.Forms.Button();
            this.tbpSearchPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbChapter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcUpload = new System.Windows.Forms.TabControl();
            this.tbpFinal.SuspendLayout();
            this.tbpUploadText.SuspendLayout();
            this.tbpSearchPage.SuspendLayout();
            this.tbcUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.FileName = "openFileDialog1";
            this.openFileDialogText.Filter = "Text|*.txt|All|*.*";
            // 
            // openFileDialogAudio
            // 
            this.openFileDialogAudio.DefaultExt = "mp3";
            this.openFileDialogAudio.FileName = "Your File Name";
            this.openFileDialogAudio.Filter = "\"All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            this.openFileDialogAudio.Title = "Select your audio file for these text";
            // 
            // tbpFinal
            // 
            this.tbpFinal.BackColor = System.Drawing.Color.LightGray;
            this.tbpFinal.Controls.Add(this.button3);
            this.tbpFinal.Controls.Add(this.lblAudioSize);
            this.tbpFinal.Controls.Add(this.label5);
            this.tbpFinal.Controls.Add(this.btnExit);
            this.tbpFinal.Controls.Add(this.btnSave);
            this.tbpFinal.Controls.Add(this.label2);
            this.tbpFinal.Controls.Add(this.label14);
            this.tbpFinal.Controls.Add(this.btnBrowesAudio);
            this.tbpFinal.Controls.Add(this.txtBrowesAudio);
            this.tbpFinal.Controls.Add(this.rtxtRemarksForAudio);
            this.tbpFinal.Location = new System.Drawing.Point(4, 22);
            this.tbpFinal.Name = "tbpFinal";
            this.tbpFinal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFinal.Size = new System.Drawing.Size(739, 482);
            this.tbpFinal.TabIndex = 2;
            this.tbpFinal.Text = "Final Step";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 285;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAudioSize
            // 
            this.lblAudioSize.AutoSize = true;
            this.lblAudioSize.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAudioSize.Location = new System.Drawing.Point(428, 240);
            this.lblAudioSize.Name = "lblAudioSize";
            this.lblAudioSize.Size = new System.Drawing.Size(14, 15);
            this.lblAudioSize.TabIndex = 284;
            this.lblAudioSize.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 283;
            this.label5.Text = "Audio File Size (in MB) :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(430, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 282;
            this.btnExit.Text = "CLOSE";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(534, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 29);
            this.btnSave.TabIndex = 281;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 263;
            this.label2.Text = "Remarks  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(216, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 262;
            this.label14.Text = "Audio File :";
            // 
            // btnBrowesAudio
            // 
            this.btnBrowesAudio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrowesAudio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowesAudio.FlatAppearance.BorderSize = 3;
            this.btnBrowesAudio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrowesAudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBrowesAudio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowesAudio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBrowesAudio.ForeColor = System.Drawing.Color.Navy;
            this.btnBrowesAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowesAudio.Image")));
            this.btnBrowesAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowesAudio.Location = new System.Drawing.Point(522, 212);
            this.btnBrowesAudio.Name = "btnBrowesAudio";
            this.btnBrowesAudio.Size = new System.Drawing.Size(84, 29);
            this.btnBrowesAudio.TabIndex = 261;
            this.btnBrowesAudio.Text = "Browse";
            this.btnBrowesAudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowesAudio.UseVisualStyleBackColor = false;
            this.btnBrowesAudio.Click += new System.EventHandler(this.btnBrowesAudio_Click);
            // 
            // txtBrowesAudio
            // 
            this.txtBrowesAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowesAudio.Location = new System.Drawing.Point(290, 215);
            this.txtBrowesAudio.Name = "txtBrowesAudio";
            this.txtBrowesAudio.Size = new System.Drawing.Size(225, 22);
            this.txtBrowesAudio.TabIndex = 260;
            // 
            // rtxtRemarksForAudio
            // 
            this.rtxtRemarksForAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtRemarksForAudio.Location = new System.Drawing.Point(290, 280);
            this.rtxtRemarksForAudio.Name = "rtxtRemarksForAudio";
            this.rtxtRemarksForAudio.Size = new System.Drawing.Size(316, 53);
            this.rtxtRemarksForAudio.TabIndex = 259;
            this.rtxtRemarksForAudio.Text = "";
            // 
            // tbpUploadText
            // 
            this.tbpUploadText.BackColor = System.Drawing.Color.LightGray;
            this.tbpUploadText.Controls.Add(this.button4);
            this.tbpUploadText.Controls.Add(this.button2);
            this.tbpUploadText.Controls.Add(this.label4);
            this.tbpUploadText.Controls.Add(this.rtxtRemarksForText);
            this.tbpUploadText.Controls.Add(this.rtxtContent);
            this.tbpUploadText.Controls.Add(this.txtBrowesText);
            this.tbpUploadText.Controls.Add(this.label6);
            this.tbpUploadText.Controls.Add(this.btnBrowesText);
            this.tbpUploadText.Location = new System.Drawing.Point(4, 22);
            this.tbpUploadText.Name = "tbpUploadText";
            this.tbpUploadText.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUploadText.Size = new System.Drawing.Size(795, 482);
            this.tbpUploadText.TabIndex = 1;
            this.tbpUploadText.Text = "Second Step";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(699, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 268;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 266;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 265;
            this.label4.Text = "Remarks  :";
            // 
            // rtxtRemarksForText
            // 
            this.rtxtRemarksForText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtRemarksForText.Location = new System.Drawing.Point(91, 191);
            this.rtxtRemarksForText.Name = "rtxtRemarksForText";
            this.rtxtRemarksForText.Size = new System.Drawing.Size(178, 53);
            this.rtxtRemarksForText.TabIndex = 264;
            this.rtxtRemarksForText.Text = "";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.Location = new System.Drawing.Point(275, 66);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(499, 401);
            this.rtxtContent.TabIndex = 261;
            this.rtxtContent.Text = "";
            // 
            // txtBrowesText
            // 
            this.txtBrowesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowesText.Location = new System.Drawing.Point(91, 62);
            this.txtBrowesText.Name = "txtBrowesText";
            this.txtBrowesText.Size = new System.Drawing.Size(178, 22);
            this.txtBrowesText.TabIndex = 258;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 260;
            this.label6.Text = "Text  File :";
            // 
            // btnBrowesText
            // 
            this.btnBrowesText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrowesText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowesText.FlatAppearance.BorderSize = 3;
            this.btnBrowesText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrowesText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBrowesText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowesText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBrowesText.ForeColor = System.Drawing.Color.Navy;
            this.btnBrowesText.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowesText.Image")));
            this.btnBrowesText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowesText.Location = new System.Drawing.Point(180, 91);
            this.btnBrowesText.Name = "btnBrowesText";
            this.btnBrowesText.Size = new System.Drawing.Size(89, 29);
            this.btnBrowesText.TabIndex = 259;
            this.btnBrowesText.Text = "Browse";
            this.btnBrowesText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowesText.UseVisualStyleBackColor = false;
            this.btnBrowesText.Click += new System.EventHandler(this.btnBrowesText_Click);
            // 
            // tbpSearchPage
            // 
            this.tbpSearchPage.BackColor = System.Drawing.Color.LightGray;
            this.tbpSearchPage.Controls.Add(this.button1);
            this.tbpSearchPage.Controls.Add(this.cmbChapter);
            this.tbpSearchPage.Controls.Add(this.label3);
            this.tbpSearchPage.Controls.Add(this.cmbBook);
            this.tbpSearchPage.Controls.Add(this.label1);
            this.tbpSearchPage.Location = new System.Drawing.Point(4, 22);
            this.tbpSearchPage.Name = "tbpSearchPage";
            this.tbpSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearchPage.Size = new System.Drawing.Size(890, 482);
            this.tbpSearchPage.TabIndex = 0;
            this.tbpSearchPage.Text = "First Step";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 284;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbChapter
            // 
            this.cmbChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbChapter.FormattingEnabled = true;
            this.cmbChapter.Location = new System.Drawing.Point(192, 216);
            this.cmbChapter.Name = "cmbChapter";
            this.cmbChapter.Size = new System.Drawing.Size(348, 26);
            this.cmbChapter.TabIndex = 283;
            this.cmbChapter.SelectedValueChanged += new System.EventHandler(this.cmbChapter_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(110, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 282;
            this.label3.Text = "Chapter :";
            // 
            // cmbBook
            // 
            this.cmbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(192, 174);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(348, 26);
            this.cmbBook.TabIndex = 281;
            this.cmbBook.SelectedValueChanged += new System.EventHandler(this.cmbBook_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(113, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 280;
            this.label1.Text = "Book :";
            // 
            // tbcUpload
            // 
            this.tbcUpload.Controls.Add(this.tbpSearchPage);
            this.tbcUpload.Controls.Add(this.tbpUploadText);
            this.tbcUpload.Controls.Add(this.tbpFinal);
            this.tbcUpload.Location = new System.Drawing.Point(15, 15);
            this.tbcUpload.Name = "tbcUpload";
            this.tbcUpload.SelectedIndex = 0;
            this.tbcUpload.Size = new System.Drawing.Size(803, 508);
            this.tbcUpload.TabIndex = 280;
            // 
            // frmContentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(840, 552);
            this.Controls.Add(this.tbcUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContentManage";
            this.Text = "Content Manage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbpFinal.ResumeLayout(false);
            this.tbpFinal.PerformLayout();
            this.tbpUploadText.ResumeLayout(false);
            this.tbpUploadText.PerformLayout();
            this.tbpSearchPage.ResumeLayout(false);
            this.tbpSearchPage.PerformLayout();
            this.tbcUpload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.OpenFileDialog openFileDialogAudio;
        private System.Windows.Forms.TabPage tbpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBrowesAudio;
        private System.Windows.Forms.TextBox txtBrowesAudio;
        private System.Windows.Forms.RichTextBox rtxtRemarksForAudio;
        private System.Windows.Forms.TabPage tbpUploadText;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtBrowesText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowesText;
        private System.Windows.Forms.TabPage tbpSearchPage;
        private System.Windows.Forms.ComboBox cmbChapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcUpload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtRemarksForText;
        private System.Windows.Forms.Label lblAudioSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}