namespace BlindEye.Control.User_Control
{
    partial class frmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btncClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtNewPassword.Location = new System.Drawing.Point(155, 115);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '#';
            this.txtNewPassword.Size = new System.Drawing.Size(202, 23);
            this.txtNewPassword.TabIndex = 210;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 15);
            this.lblEmail.TabIndex = 209;
            this.lblEmail.Text = "New Password  :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(155, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 23);
            this.txtPassword.TabIndex = 208;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(74, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 207;
            this.lblPassword.Text = "Password  :";
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.textUserName.Location = new System.Drawing.Point(155, 57);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(202, 23);
            this.textUserName.TabIndex = 206;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(69, 57);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(78, 15);
            this.lblUserId.TabIndex = 205;
            this.lblUserId.Text = "User Name :";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtRetypePassword.Location = new System.Drawing.Point(155, 149);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '#';
            this.txtRetypePassword.Size = new System.Drawing.Size(202, 23);
            this.txtRetypePassword.TabIndex = 212;
            this.txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 211;
            this.label1.Text = "Re-Type Password  :";
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
            this.btnSave.Location = new System.Drawing.Point(264, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 213;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox11.Location = new System.Drawing.Point(9, 8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(4, 209);
            this.pictureBox11.TabIndex = 314;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(7, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 4);
            this.pictureBox2.TabIndex = 313;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox9.Location = new System.Drawing.Point(363, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(4, 209);
            this.pictureBox9.TabIndex = 311;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 4);
            this.pictureBox1.TabIndex = 310;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(14, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 17);
            this.label13.TabIndex = 309;
            this.label13.Text = "Change Password";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(6, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 4);
            this.pictureBox3.TabIndex = 315;
            this.pictureBox3.TabStop = false;
            // 
            // btncClose
            // 
            this.btncClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncClose.FlatAppearance.BorderSize = 3;
            this.btncClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncClose.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncClose.ForeColor = System.Drawing.Color.Maroon;
            this.btncClose.Image = ((System.Drawing.Image)(resources.GetObject("btncClose.Image")));
            this.btncClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncClose.Location = new System.Drawing.Point(169, 179);
            this.btncClose.Name = "btncClose";
            this.btncClose.Size = new System.Drawing.Size(89, 29);
            this.btncClose.TabIndex = 316;
            this.btncClose.Text = "CLOSE";
            this.btncClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncClose.UseVisualStyleBackColor = false;
            this.btncClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(382, 234);
            this.Controls.Add(this.btncClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.lblUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResetPassword";
            this.Text = "Change my password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btncClose;
    }
}