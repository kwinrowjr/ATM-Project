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
    public partial class Form2 : Form
    {
        string menu_option;
        double bal = 2000;
        Form1 menuForm = new Form1();

        public Form2()
        {
            InitializeComponent();
            //display the account information
            label2.Text = "Account Information:";
            label2.Visible = true;
            label3.Text = "Name:";
            label3.Visible = true;
            label4.Text = "Type:";
            label4.Visible = true;
            label5.Text = "Phone:";
            label5.Visible = true;
            label6.Text = "Address:";
            label6.Visible = true;
            textBox1.Text = "Kelvin Winrow";
            textBox1.Visible = true;
            textBox2.Text = "Checking";
            textBox2.Visible = true;
            textBox3.Text = "615-555-6666";
            textBox3.Visible = true;
            textBox4.Text = "3500 John A. Merritt Blvd." + Environment.NewLine + "Nashville, TN 37209";
            textBox4.Visible = true;

        }

        private void backsp_button(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void fastcash_button(object sender, EventArgs e)
        {
            if (bal < 200)
            {
                label2.Text = ("Account balance is less than $200");
            }
            else
            {
                bal = bal - 100;
                label2.Text = ("$100 Withdraw Complete!!!");
            }
        }

        private void acctButton(object sender, EventArgs e)
        {
            label2.Text = "Account Information:";
            label2.Visible = true;
            label3.Text = "Name:";
            label3.Visible = true;
            label4.Text = "Type:";
            label4.Visible = true;
            label5.Text = "Phone:";
            label5.Visible = true;
            label6.Text = "Address:";
            label6.Visible = true;
            textBox1.Text = "Kelvin Winrow";
            textBox1.Visible = true;
            textBox2.Text = "Checking";
            textBox2.Visible = true;
            textBox3.Text = "615-555-6666";
            textBox3.Visible = true;
            textBox4.Text = "3500 John A. Merritt Blvd." + Environment.NewLine + "Nashville, TN 37209";
            textBox4.Visible = true;

            
        }

        private void balButton(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label2.Text = "Account Balance:";
            label3.Text = string.Format("Your balance is: {0:C}", bal);
        }

        private void deposit_button(object sender, EventArgs e)
        {
            
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label3.Text = "Amount:";
            menu_option = "Deposit";
            label2.Text = "Make Deposit:";

            textBox1.Clear(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pin_change_Button(object sender, EventArgs e)
        {
            //when this button is clicked, it allowed to change the PIN.
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = true;// here, enters the old pin
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            //btnSubmit.Visible = true;
            label3.Text = "Old PIN:";
            menu_option = "old_pin";
            label2.Text = "Change Your PIN:";

            textBox1.Clear();
        }

        private void withdraw_Button(object sender, EventArgs e)
        {
            //withdraw amount from the account
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = true;//here enter the amount to be withdrawn
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            //btnSubmit.Visible = true;
            label2.Text = "Money Withdraw:";
            label3.Text = "Amount:";
            menu_option = "remove";
            textBox1.Clear();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                Button button = (Button)sender;
                textBox1.Text = textBox1.Text + button.Text;


            }
        }



        private void enter_button(object sender, EventArgs e)
        {
            if (menu_option == "Deposit")
            {
                if (Int64.Parse(textBox1.Text) < 1)
                {
                    label2.Text = ("Invalid amount!");
                    textBox1.Clear();
                }
                else if (Int64.Parse(textBox1.Text) > 1000)
                {
                    label2.Text = ("Deposit must be less than $1000");
                    textBox1.Clear();
                }
                else
                {
                    bal = bal + Int64.Parse(textBox1.Text);
                    label2.Text = "$" + textBox1.Text + " deposited successfully!";
                    textBox1.Visible = false;
                    label3.Visible = false;
                }
            }
            else if (menu_option == "remove")
            {
                if (bal < 100)
                {
                    label2.Text = ("Denied!!! Account balance must be greater than $100");
                    textBox1.Visible = false;
                    label3.Visible = false;
                }
                else if (Int64.Parse(textBox1.Text) < 1)
                {
                    label2.Text = ("Invalid amount!");
                    textBox1.Visible = false;
                    label3.Visible = false;
                }
                else if (Int64.Parse(textBox1.Text) > bal)
                {
                    label2.Text = ("Denied! Account will be overdrawn");
                    textBox1.Visible = false;
                    label3.Visible = false;
                }
                else
                {
                    if ((bal - Int64.Parse(textBox1.Text)) < 100)
                    {
                        label2.Text = ("Denied! Account will be less than $100");
                        textBox1.Visible = false;
                        label3.Visible = false;
                    }
                    else
                    {
                        bal = bal - Int64.Parse(textBox1.Text);
                        label2.Text = "$" + textBox1.Text + " withdrawn successfully!";
                        textBox1.Visible = false;
                        label3.Visible = false;
                    }
                }
            }
            else if (menu_option == "old_pin")
            {
                if (textBox1.Text == menuForm.pinnumber.ToString())
                {
                    textBox1.Clear();
                    label3.Text = "New PIN:";
                    menu_option = "new_pin";
                }
                else
                {
                    label2.Text = ("Incorrect PIN! Try Again!");
                }
            }
            else if (menu_option == "new_pin")
            {
                menuForm.pinnumber = Int32.Parse(textBox1.Text);
                textBox1.Clear(); 
                label2.Text = "PIN changed successfully!";
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                //btnSubmit.Visible = false;
            }
        }

        private void clear_button(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void cancel_button(object sender, EventArgs e)
        {
                        //cancel all the transactions
            textBox1.Clear();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            //btnSubmit.Visible = false;
        }


        




    }
}
