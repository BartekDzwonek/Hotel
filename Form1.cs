using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") & (textBox2.Text == "123"))
            {

                    Form2 s = new Form2();
                    this.Hide();
                    s.Show();
            }
            if ((textBox1.Text == "user") & (textBox2.Text == "123"))
            {

                Form3 s = new Form3();
                this.Hide();
                s.Show();
            }
        }
       
   
        private void button2_Click(object sender, EventArgs e)
        {
 
            this.Close();

        }
    }
}
