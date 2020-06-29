namespace BlindEye.Control.User_Control
{
    partial class frmCreateUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserFullName = new System.Windows.Forms.TextBox();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAcctType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(387, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 217;
            this.label1.Text = "List of User Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUserList);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 269);
            this.groupBox1.TabIndex = 216;
            this.groupBox1.TabStop = false;
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.Location = new System.Drawing.Point(3, 22);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.ShowEditingIcon = false;
            this.dgvUserList.Size = new System.Drawing.Size(682, 244);
            this.dgvUserList.TabIndex = 0;
            this.dgvUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellClick);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(133, 221);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(202, 23);
            this.txtPhoneNumber.TabIndex = 206;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(19, 228);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(99, 15);
            this.lblPhoneNumber.TabIndex = 205;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(133, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 23);
            this.txtEmail.TabIndex = 204;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(70, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 203;
            this.lblEmail.Text = "Email  :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(133, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 23);
            this.txtPassword.TabIndex = 202;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(45, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 201;
            this.lblPassword.Text = "Password  :";
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.textUserName.Location = new System.Drawing.Point(133, 134);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(202, 23);
            this.textUserName.TabIndex = 200;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(40, 141);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(78, 15);
            this.lblUserId.TabIndex = 199;
            this.lblUserId.Text = "User Name :";
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtUserFullName.Location = new System.Drawing.Point(133, 73);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.Size = new System.Drawing.Size(202, 23);
            this.txtUserFullName.TabIndex = 198;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.Location = new System.Drawing.Point(17, 80);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(101, 15);
            this.lblUserFullName.TabIndex = 197;
            this.lblUserFullName.Text = "User Full Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(5, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 192;
            this.label13.Text = "User Info";
            // 
            // cmbAcctType
            // 
            this.cmbAcctType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcctType.FormattingEnabled = true;
            this.cmbAcctType.Location = new System.Drawing.Point(133, 43);
            this.cmbAcctType.Name = "cmbAcctType";
            this.cmbAcctType.Size = new System.Drawing.Size(202, 24);
            this.cmbAcctType.TabIndex = 306;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 307;
            this.label2.Text = "Account Type :";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(133, 102);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(202, 27);
            this.dtpDateOfBirth.TabIndex = 309;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 310;
            this.label3.Text = "Date Of Birth :";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox11.Location = new System.Drawing.Point(0, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(4, 290);
            this.pictureBox11.TabIndex = 308;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(1071, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(4, 291);
            this.pictureBox8.TabIndex = 215;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(378, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(4, 291);
            this.pictureBox7.TabIndex = 214;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(380, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(693, 4);
            this.pictureBox3.TabIndex = 213;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(380, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(693, 4);
            this.pictureBox4.TabIndex = 212;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(380, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(693, 4);
            this.pictureBox5.TabIndex = 211;
            this.pictureBox5.TabStop = false;
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
            this.btnDelete.Location = new System.Drawing.Point(165, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.TabIndex = 210;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(251, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 29);
            this.btnSave.TabIndex = 209;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 4);
            this.pictureBox2.TabIndex = 208;
            this.pictureBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Navy;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(84, 258);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 29);
            this.btnNew.TabIndex = 207;
            this.btnNew.Text = "NEW";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(4, 243);
            this.pictureBox6.TabIndex = 196;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox10.Location = new System.Drawing.Point(-2, 293);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(360, 4);
            this.pictureBox10.TabIndex = 195;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox9.Location = new System.Drawing.Point(354, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(4, 291);
            this.pictureBox9.TabIndex = 194;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 4);
            this.pictureBox1.TabIndex = 193;
            this.pictureBox1.TabStop = false;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1083, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAcctType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserFullName);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Name = "frmCreateUser";
            this.Text = "User Management";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserFullName;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAcctType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label3;
    }
}