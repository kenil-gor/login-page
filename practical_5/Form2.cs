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
    public partial class Form2 : Form
    {
        Form f1;
        public Form2(String username, Form1 f)
        {
            InitializeComponent();
            label1.Text += "," + username;
            f1 = f;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
