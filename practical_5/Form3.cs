using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical_5
{
    public partial class Form3 : Form
    {
        string pass;
        public Form3(String curr_password)
        {
            InitializeComponent();
            pass = curr_password;
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String curr_pass = textBox4.Text;
            String new_pass = textBox1.Text;
            String conf_pass = textBox2.Text;
            
           
            label4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            if (curr_pass=="" || new_pass == "" || conf_pass == "")
             {

                if (curr_pass != "" && new_pass != "" && conf_pass == "")
                {
                    label8.Visible = true;
                }
                else if (curr_pass == "" && new_pass != "" && conf_pass != "")
                {
                    label4.Visible = true;
                }
                else if (curr_pass != "" && new_pass == "" && conf_pass != "")
                {
                    label7.Visible = true;
                }
                else if (curr_pass == "" && new_pass == "" && conf_pass != "")
                {
                    label4.Visible = true;
                    label7.Visible = true;

                }
                else if (curr_pass == "" && new_pass != "" && conf_pass == "")
                {
                    label4.Visible = true;
                    label8.Visible = true;
                }
                else if (curr_pass != "" && new_pass == "" && conf_pass == "")
                {
                    label7.Visible = true;
                    label8.Visible = true;
                }

                else
                {
                    label4.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;

                }

                }

            else
            {
                if (curr_pass == pass)
                {
                    if (new_pass != conf_pass)
                    {

                        label6.Text = "New password is not equal to conform password";
                    }
                    else
                    {
                        Form1 form = new Form1(new_pass);
                        form.Show();
                        this.Close();
                    }
                }
                else
                {
                    label6.Text = "curr_pass is Wrong!!";
                }   
            }
        }

      
    }
}
