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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            this.Hide();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 s = new Form8();
            this.Hide();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 s = new Form9();
            this.Hide();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 s = new Form10();
            this.Hide();
            s.Show();
        }
    }
}
