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
    public partial class Form1 : Form
    {

        string username = "Gor Kenil", password = "123";
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(String new_pass)
        {
            InitializeComponent();
            password = new_pass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(password);
            form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iusername = textBox3.Text;
            string ipassword = textBox4.Text;

            if(iusername == "" || ipassword == "")
            {
                label3.Visible = true;
                label4.Visible = true;

            }
            else if(iusername.Equals(username) && password.Equals(ipassword))
            {
                Form2 form = new Form2(username, this);
                textBox3.Text = "";
                textBox4.Text = "";
                form.Show();
                this.Hide();
            }
            else
            {
                if(username != iusername && ipassword == password)
                {
                    label5.Text = "Incorrect Username";
                }
                else if(username == iusername && ipassword != password)
                {
                    label5.Text = "Incorrect Password";
                    button3.Visible = true;
                }
                else
                {
                    label5.Text = "Both Username and password are incorrect";
                }
                label5.Visible = true;
            }


        }
    }
}
