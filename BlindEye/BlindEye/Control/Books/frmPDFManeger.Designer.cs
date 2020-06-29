namespace BlindEye.Control.Books
{
    partial class frmPDFManeger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDFManeger));
            this.btnBrowes = new System.Windows.Forms.Button();
            this.txtPdfLocation = new System.Windows.Forms.TextBox();
            this.rtxtDescreptio = new System.Windows.Forms.RichTextBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowes
            // 
            this.btnBrowes.Location = new System.Drawing.Point(208, 121);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(75, 23);
            this.btnBrowes.TabIndex = 11;
            this.btnBrowes.Text = "Browes";
            this.btnBrowes.UseVisualStyleBackColor = true;
            this.btnBrowes.Click += new System.EventHandler(this.btnBrowes_Click);
            // 
            // txtPdfLocation
            // 
            this.txtPdfLocation.Location = new System.Drawing.Point(134, 95);
            this.txtPdfLocation.Name = "txtPdfLocation";
            this.txtPdfLocation.Size = new System.Drawing.Size(149, 20);
            this.txtPdfLocation.TabIndex = 10;
            // 
            // rtxtDescreptio
            // 
            this.rtxtDescreptio.Location = new System.Drawing.Point(18, 245);
            this.rtxtDescreptio.Name = "rtxtDescreptio";
            this.rtxtDescreptio.Size = new System.Drawing.Size(245, 135);
            this.rtxtDescreptio.TabIndex = 9;
            this.rtxtDescreptio.Text = "";
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(134, 56);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(149, 21);
            this.cmbBook.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Book Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "PDF Location :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(78, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Remarks";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(344, 53);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(484, 420);
            this.axAcroPDF1.TabIndex = 15;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(170, 450);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(93, 37);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // frmPDFManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(840, 522);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowes);
            this.Controls.Add(this.txtPdfLocation);
            this.Controls.Add(this.rtxtDescreptio);
            this.Controls.Add(this.cmbBook);
            this.Name = "frmPDFManeger";
            this.Text = "PDF Maneger";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.TextBox txtPdfLocation;
        private System.Windows.Forms.RichTextBox rtxtDescreptio;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnUpload;
    }
}