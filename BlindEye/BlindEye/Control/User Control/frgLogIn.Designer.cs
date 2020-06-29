namespace BlindEye.Control.User_Control
{
    partial class frgLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frgLogIn));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnlForgetPassword = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(123, 163);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 31);
            this.btnLogin.TabIndex = 247;
            this.btnLogin.Text = "Log in ";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(26, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(172, 23);
            this.txtPassword.TabIndex = 246;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 245;
            this.label1.Text = "PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.lnlForgetPassword);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblCategoryName);
            this.panel1.Location = new System.Drawing.Point(77, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 216);
            this.panel1.TabIndex = 1;
            // 
            // lnlForgetPassword
            // 
            this.lnlForgetPassword.AutoSize = true;
            this.lnlForgetPassword.Location = new System.Drawing.Point(44, 131);
            this.lnlForgetPassword.Name = "lnlForgetPassword";
            this.lnlForgetPassword.Size = new System.Drawing.Size(154, 13);
            this.lnlForgetPassword.TabIndex = 249;
            this.lnlForgetPassword.TabStop = true;
            this.lnlForgetPassword.Text = "Forget your userID/Password ?";
            this.lnlForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlForgetPassword_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(26, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 31);
            this.btnCancel.TabIndex = 248;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Navy;
            this.txtUserName.Location = new System.Drawing.Point(26, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 23);
            this.txtUserName.TabIndex = 244;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCategoryName.Location = new System.Drawing.Point(71, 25);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(82, 14);
            this.lblCategoryName.TabIndex = 243;
            this.lblCategoryName.Text = "USER NAME";
            // 
            // frgLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 433);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frgLogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frgLogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnlForgetPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblCategoryName;
    }
}