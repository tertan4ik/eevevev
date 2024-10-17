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
        int count = 0;
        private void button4_Click (object sender, EventArgs e)
        {
        
            count++;
            if (count%2==0)
            {
                prshow.Visible = false;
            }
            else
            {
                prshow.Visible = true;
                tskshow.Visible = true;
                contshow.Visible = false;
                colorshow.Visible = false;

            }

        }

        private void button5_Click (object sender, EventArgs e)
        {
            prshow.Visible = false;
            tskshow.Visible = true;
            contshow.Visible = false;
            colorshow.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prshow.Visible = false;
            tskshow.Visible = false;
            contshow.Visible = true;
            colorshow.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prshow.Visible = false;
            tskshow.Visible = false;
            contshow.Visible = false;
            colorshow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
