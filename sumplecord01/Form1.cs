using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumplecord01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "goodbye";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            a = label2.Text;
            b = label3.Text;
            label2.Text = b;
            label3.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);

            int ans;
            ans = n1 + n2;
            label4.Text = Convert.ToString(ans);

        }
    }
}
