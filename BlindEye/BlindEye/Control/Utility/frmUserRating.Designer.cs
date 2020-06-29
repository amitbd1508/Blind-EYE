namespace BlindEye.Control.Utility
{
    partial class frmUserRating
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
            this.dvgUserList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgUserList
            // 
            this.dvgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUserList.Location = new System.Drawing.Point(12, 56);
            this.dvgUserList.Name = "dvgUserList";
            this.dvgUserList.Size = new System.Drawing.Size(401, 320);
            this.dvgUserList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rating ";
            // 
            // frmUserRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgUserList);
            this.Name = "frmUserRating";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.frmUserRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgUserList;
        private System.Windows.Forms.Label label1;
    }
}