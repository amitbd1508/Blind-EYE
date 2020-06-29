namespace BlindEye.Control
{
    partial class frmUserControl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.ratingToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListToolStripMenuItem,
            this.searchBookToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookListToolStripMenuItem.Text = "Book list";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.deactivateAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // deactivateAccountToolStripMenuItem
            // 
            this.deactivateAccountToolStripMenuItem.Name = "deactivateAccountToolStripMenuItem";
            this.deactivateAccountToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deactivateAccountToolStripMenuItem.Text = "Deactivate Account";
            // 
            // ratingToolStripMenuItem
            // 
            this.ratingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myRatingToolStripMenuItem});
            this.ratingToolStripMenuItem.Name = "ratingToolStripMenuItem";
            this.ratingToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ratingToolStripMenuItem.Text = "Rating";
            // 
            // myRatingToolStripMenuItem
            // 
            this.myRatingToolStripMenuItem.Name = "myRatingToolStripMenuItem";
            this.myRatingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myRatingToolStripMenuItem.Text = "My Rating";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            // 
            // frmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 414);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserControl";
            this.Text = "frmUserControl";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}