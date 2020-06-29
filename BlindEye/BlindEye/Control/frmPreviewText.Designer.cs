namespace BlindEye.Control
{
    partial class frmPreviewText
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
            this.Preview = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Preview
            // 
            this.Preview.AutoSize = true;
            this.Preview.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview.Location = new System.Drawing.Point(-167, 284);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(72, 20);
            this.Preview.TabIndex = 8;
            this.Preview.Text = "Preview";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(548, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.Location = new System.Drawing.Point(32, 39);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.ReadOnly = true;
            this.richTextBoxPreview.Size = new System.Drawing.Size(615, 411);
            this.richTextBoxPreview.TabIndex = 6;
            this.richTextBoxPreview.Text = "";
            // 
            // frmPreviewText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 502);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBoxPreview);
            this.Name = "frmPreviewText";
            this.Text = "frmPreviewText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Preview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
    }
}