namespace BlindEye.Control
{
    partial class frmVoiceRecognigetion
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button1_Click = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 433);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 45;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 121);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 44;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // button1_Click
            // 
            this.button1_Click.Location = new System.Drawing.Point(12, 58);
            this.button1_Click.Name = "button1_Click";
            this.button1_Click.Size = new System.Drawing.Size(75, 23);
            this.button1_Click.TabIndex = 39;
            this.button1_Click.Text = "Browse";
            this.button1_Click.UseVisualStyleBackColor = true;
            this.button1_Click.Click += new System.EventHandler(this.button1_Click_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(114, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(437, 396);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // frmVoiceRecognigetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 481);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1_Click);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmVoiceRecognigetion";
            this.Text = "frmVoiceRecognigetion";
            this.Load += new System.EventHandler(this.frmVoiceRecognigetion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button1_Click;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}