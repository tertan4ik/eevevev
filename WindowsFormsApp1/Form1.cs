﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void refreshcomb()
        {
            comboBox1.Items.Clear( );
            StreamReader sr = new StreamReader("contacts.txt");
            while (!sr.EndOfStream)
            {
                comboBox1.Items.Add(sr.ReadLine( ));
                for (int i = 0; i < 4; i++)
                {
                    sr.ReadLine( );
                }


            }
            sr.Close( );
        }
        private void button8_Click (object sender, EventArgs e)
        {
            refreshcomb( );
           
            groupBox2.Enabled = true;
            groupBox2.Visible = true;
     


        }

        private void button10_Click (object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                StreamWriter sw = File.AppendText("contacts.txt");

            sw.WriteLine(textBox1.Text);

            sw.WriteLine(textBox2.Text);

            sw.WriteLine(textBox3.Text);

            sw.WriteLine(textBox4.Text);

            sw.WriteLine(textBox5.Text);

            sw.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click (object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
   
  

        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox1.Visible=false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;

        }

        private void Form1_Load (object sender, EventArgs e)
        {
         
      
        }

        private void button14_Click (object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1 (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contshow_Enter (object sender, EventArgs e)
        {

        }
    }
}
