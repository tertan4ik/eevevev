using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent( );
        }      
        private void profile_Enter (object sender, EventArgs e)
        {
 
        }

        private void showprofile (object sender, EventArgs e)
        {
            prshow.Visible = false;

        }

        private void groupBox3_Enter (object sender, EventArgs e)
        {

        }

        private void button4_Click (object sender, EventArgs e)
        {
            prshow.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button5_Click (object sender, EventArgs e)
        {
            prshow.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }
    }
}
