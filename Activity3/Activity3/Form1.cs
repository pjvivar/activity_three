using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox1 - Japan
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox2 - Thailand
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox3 -  Philippines
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox4 - South Korea
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            String str = " ";

            // Checkbox1 - Japan
            if(checkBox1.Checked == true) {
                str = str + checkBox1.Text;
                str += " ";
            }
            // Checkbox2 - Thailand
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            }
            // Checkbox3 - Philippines
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            }
            // Checkbox1 - South Korea
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            }
            // Others - checkbox
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text;
                str += " ";
            }

            if (str != null) {
                MessageBox.Show("You selected: \n "+ str +"\nThankyou!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // End if is statement 
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            // Close button
            MessageBox.Show("Are you sure to close it?");
            Application.Exit();
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // Others checkbox
            if (checkBox5.Checked == true)
            {
                label3.Visible = true; // Specify
                textBox1.Visible = true; // Textbox input
            }
            else {
                label3.Visible = false; // Specify
                textBox1.Visible = false; // Textbox input       
            }
          

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Others textbox - specification

        }
    
               
     // End of class
    }
}
