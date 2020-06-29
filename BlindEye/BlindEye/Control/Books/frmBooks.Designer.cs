namespace BlindEye.Control.Books
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlGride = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtReleseYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlGride.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSearch.Location = new System.Drawing.Point(302, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search By Book/Author Name : ";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtWeight.Location = new System.Drawing.Point(-13, 45);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(196, 23);
            this.txtWeight.TabIndex = 30;
            this.txtWeight.Text = "0";
            this.txtWeight.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "(e.g: Bosta/KG/gm etc)";
            this.label1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-91, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Weight :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "(must be a real number)";
            this.label2.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-74, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Unit :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(-142, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 4);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtUnit.Location = new System.Drawing.Point(-13, 87);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(196, 23);
            this.txtUnit.TabIndex = 32;
            this.txtUnit.Text = "0";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox10.Location = new System.Drawing.Point(6, 503);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(628, 2);
            this.pictureBox10.TabIndex = 258;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox9.Location = new System.Drawing.Point(5, 251);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(628, 2);
            this.pictureBox9.TabIndex = 257;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(6, 227);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(628, 2);
            this.pictureBox8.TabIndex = 256;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(285, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 255;
            this.label3.Text = "Book List";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBookList.Location = new System.Drawing.Point(10, 256);
            this.dgvBookList.MultiSelect = false;
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(622, 208);
            this.dgvBookList.TabIndex = 237;
            this.dgvBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(407, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 252;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(132, 117);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxtDescription.Size = new System.Drawing.Size(487, 57);
            this.rtxtDescription.TabIndex = 245;
            this.rtxtDescription.Text = "";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(6, 464);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(628, 2);
            this.pictureBox7.TabIndex = 254;
            this.pictureBox7.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Navy;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(487, 470);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 29);
            this.btnNew.TabIndex = 253;
            this.btnNew.Text = "NEW";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnSave.Location = new System.Drawing.Point(561, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 29);
            this.btnSave.TabIndex = 251;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(5, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(4, 427);
            this.pictureBox5.TabIndex = 250;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(630, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(4, 427);
            this.pictureBox4.TabIndex = 249;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(10, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 4);
            this.pictureBox1.TabIndex = 248;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(53, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 244;
            this.label13.Text = "Remarks  :";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtBookName.Location = new System.Drawing.Point(132, 59);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(487, 23);
            this.txtBookName.TabIndex = 243;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 242;
            this.label7.Text = "Book Name :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(6, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(626, 3);
            this.pictureBox2.TabIndex = 240;
            this.pictureBox2.TabStop = false;
            // 
            // pnlGride
            // 
            this.pnlGride.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGride.Controls.Add(this.txtWeight);
            this.pnlGride.Controls.Add(this.label1);
            this.pnlGride.Controls.Add(this.label11);
            this.pnlGride.Controls.Add(this.label2);
            this.pnlGride.Controls.Add(this.label12);
            this.pnlGride.Controls.Add(this.txtUnit);
            this.pnlGride.Controls.Add(this.pictureBox3);
            this.pnlGride.Location = new System.Drawing.Point(752, 573);
            this.pnlGride.Name = "pnlGride";
            this.pnlGride.Size = new System.Drawing.Size(184, 148);
            this.pnlGride.TabIndex = 238;
            this.pnlGride.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(227, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 33);
            this.label8.TabIndex = 241;
            this.label8.Text = "Book Set-Up Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 40);
            this.panel1.TabIndex = 239;
            // 
            // txtReleseYear
            // 
            this.txtReleseYear.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtReleseYear.Location = new System.Drawing.Point(433, 88);
            this.txtReleseYear.Name = "txtReleseYear";
            this.txtReleseYear.Size = new System.Drawing.Size(186, 23);
            this.txtReleseYear.TabIndex = 261;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 260;
            this.label4.Text = "Relese Year :";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtAuthorName.Location = new System.Drawing.Point(132, 88);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(186, 23);
            this.txtAuthorName.TabIndex = 263;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 262;
            this.label5.Text = "Author Name :";
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(651, 513);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReleseYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlGride);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBooks";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlGride.ResumeLayout(false);
            this.pnlGride.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlGride;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtReleseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label5;
    }
}