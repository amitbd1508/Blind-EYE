using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlindEye.Control
{
    public partial class frmPreviewText : Form
    {
        public  string btext="";
        
        public frmPreviewText()
        {
        
            InitializeComponent();
            
          
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Successfully added");
            this.Close();

        }
      
        public void setRichBox(string s)
        {
            richTextBoxPreview.Text  = s;

            this.Show();
            
        }


    }
}
