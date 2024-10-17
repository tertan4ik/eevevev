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
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
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
        
            count1++;
            if (count1 % 2 != 0)
            {
                prshow.Visible = true;
            }
            else
        
            {
                prshow.Visible = false;
          
                
            }

        }

        private void button5_Click (object sender, EventArgs e)
        {
            count2++;
            if (count2 % 2 != 0)
            {
                tskshow.Visible = true;
                button8.Visible = true;
                button8.Enabled = true;
                button9.Visible = false;
                button9.Enabled = false;
            }
            else
            
            {
                tskshow.Visible = false;
                button8.Visible = false;
                button8.Enabled = false;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
         

            count3++;
            if (count3% 2 != 0)
            {
                contshow.Visible = true;
                button9.Visible = true;
                button9.Enabled = true;
                button8.Visible = false;
                button8.Enabled = false;

            }
            else
          
            {
                contshow.Visible = false;
                button9.Visible = false;
                button9.Enabled = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count4++;
            if (count4 %2!=0)
            {
                colorshow.Visible = true;
            }
            else
         
            {
                colorshow.Visible = false;
                count4 = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click (object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button8_Click (object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox2.Visible = true;
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
        }

        private void button10_Click (object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click (object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            groupBox2.Enabled = false;
            groupBox2.Visible = false;
        }
    }
}
