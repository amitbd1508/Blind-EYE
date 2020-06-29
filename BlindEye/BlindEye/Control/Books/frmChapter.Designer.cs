namespace BlindEye.Control.Books
{
    partial class frmChapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChapter));
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtChapterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBooks
            // 
            this.cmbBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBooks.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(120, 25);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(186, 23);
            this.cmbBooks.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 61;
            this.label14.Text = "Book Name :";
            // 
            // txtChapterName
            // 
            this.txtChapterName.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtChapterName.Location = new System.Drawing.Point(120, 54);
            this.txtChapterName.Name = "txtChapterName";
            this.txtChapterName.Size = new System.Drawing.Size(186, 23);
            this.txtChapterName.TabIndex = 265;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 264;
            this.label5.Text = "Chapter Name :";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(120, 83);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxtDescription.Size = new System.Drawing.Size(186, 68);
            this.rtxtDescription.TabIndex = 267;
            this.rtxtDescription.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(41, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 266;
            this.label13.Text = "Remarks  :";
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
            this.btnExit.Location = new System.Drawing.Point(143, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 269;
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
            this.btnSave.Location = new System.Drawing.Point(234, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 29);
            this.btnSave.TabIndex = 268;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(334, 198);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtChapterName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChapter";
            this.Text = "Chapter Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtChapterName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}