using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
       
       
        public int pinnumber = 3300;

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //checks PIN is entered or not 
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox2.Text + "----";
            }
            else if (pinnumber == Int64.Parse(textBox2.Text))//checks whether pin is correct and then shows the form 2(menu)
            {
                Form2 menu = new Form2();
                menu.Show();
                this.Hide();
            }
            else
            {
              
                textBox1.Text = "The PIN is Incorrect! Try Again!";

        
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

            if (textBox2.Text == "----")
            {
                textBox2.Clear();
                textBox1.Clear();
            }

            
            if (textBox2.Text.Length < 4)
            {
                Button button = (Button)sender;
                textBox2.Text = textBox2.Text + button.Text;
                textBox2.PasswordChar = '*';
                
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

        }
    }
}
