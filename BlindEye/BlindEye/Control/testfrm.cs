using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using BlindEye_Lib.For_project_recurment;

namespace BlindEye.Control
{
    public partial class testfrm : Form
    {
        public testfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s=ExtrafaltuClass.Sumex();
            MessageBox.Show(s+"");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = ExtrafaltuClass.AvgEx();
            MessageBox.Show(s + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = ExtrafaltuClass.MAXEx();
            MessageBox.Show(s + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = ExtrafaltuClass.MinEx();
            MessageBox.Show(s + "");
        }
    }
}
