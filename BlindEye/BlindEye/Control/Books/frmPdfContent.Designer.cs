namespace BlindEye.Control.Books
{
    partial class frmPdfContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdfContent));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtDescreptio = new System.Windows.Forms.RichTextBox();
            this.txtPdfLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowes = new System.Windows.Forms.Button();
            this.adobePdfView = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.adobePdfView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name: ";
            // 
            // cmbBookName
            // 
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(111, 53);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(149, 21);
            this.cmbBookName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remarks";
            // 
            // rtxtDescreptio
            // 
            this.rtxtDescreptio.Location = new System.Drawing.Point(15, 261);
            this.rtxtDescreptio.Name = "rtxtDescreptio";
            this.rtxtDescreptio.Size = new System.Drawing.Size(245, 135);
            this.rtxtDescreptio.TabIndex = 4;
            this.rtxtDescreptio.Text = "";
            // 
            // txtPdfLocation
            // 
            this.txtPdfLocation.Location = new System.Drawing.Point(111, 92);
            this.txtPdfLocation.Name = "txtPdfLocation";
            this.txtPdfLocation.Size = new System.Drawing.Size(149, 20);
            this.txtPdfLocation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "PDF Location:";
            // 
            // btnBrowes
            // 
            this.btnBrowes.Location = new System.Drawing.Point(185, 118);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(75, 23);
            this.btnBrowes.TabIndex = 7;
            this.btnBrowes.Text = "Browes";
            this.btnBrowes.UseVisualStyleBackColor = true;
            // 
            // adobePdfView
            // 
            this.adobePdfView.Enabled = true;
            this.adobePdfView.Location = new System.Drawing.Point(278, 53);
            this.adobePdfView.Name = "adobePdfView";
            this.adobePdfView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adobePdfView.OcxState")));
            this.adobePdfView.Size = new System.Drawing.Size(612, 486);
            this.adobePdfView.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmPdfReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 544);
            this.Controls.Add(this.adobePdfView);
            this.Controls.Add(this.btnBrowes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPdfLocation);
            this.Controls.Add(this.rtxtDescreptio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBookName);
            this.Controls.Add(this.label1);
            this.Name = "frmPdfReader";
            this.Text = "frmPdfReader";
            ((System.ComponentModel.ISupportInitialize)(this.adobePdfView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtDescreptio;
        private System.Windows.Forms.TextBox txtPdfLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowes;
        private AxAcroPDFLib.AxAcroPDF adobePdfView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}