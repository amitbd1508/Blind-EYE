namespace BlindEye.Control
{
    partial class frmAddNewBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtReleseYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaveFileName = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Text(.txt)",
            "PDF(.PDF)"});
            this.comboBox1.Location = new System.Drawing.Point(153, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelect.Location = new System.Drawing.Point(272, 88);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 28);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Name ";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBookName.Location = new System.Drawing.Point(153, 123);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(212, 23);
            this.txtBookName.TabIndex = 4;
            // 
            // txtReleseYear
            // 
            this.txtReleseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReleseYear.Location = new System.Drawing.Point(155, 166);
            this.txtReleseYear.Name = "txtReleseYear";
            this.txtReleseYear.Size = new System.Drawing.Size(212, 23);
            this.txtReleseYear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Relese Year";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAuthorName.Location = new System.Drawing.Point(155, 209);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(212, 23);
            this.txtAuthorName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author Name";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUpload.Location = new System.Drawing.Point(266, 324);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(101, 30);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 12;
            // 
            // lblSaveFileName
            // 
            this.lblSaveFileName.AutoSize = true;
            this.lblSaveFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFileName.Location = new System.Drawing.Point(55, 20);
            this.lblSaveFileName.Name = "lblSaveFileName";
            this.lblSaveFileName.Size = new System.Drawing.Size(0, 16);
            this.lblSaveFileName.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRemarks.Location = new System.Drawing.Point(155, 256);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(212, 62);
            this.txtRemarks.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(63, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Remarks";
            // 
            // frmAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 366);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSaveFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReleseYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAddNewBook";
            this.Text = "Add new Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtReleseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaveFileName;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
    }
}