using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Суматорче : Form
    {
        public Суматорче()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(this.textBox1.Text);
            var num2 = decimal.Parse(this.textBox2.Text);
            var sum = num1 + num2;
            textBox3.Text = sum.ToString();
            var num5 = decimal.Parse(this.textBox5.Text);
            var num6 = decimal.Parse(this.textBox6.Text);
            var um = num6 - num5;
            textBox4.Text = um.ToString();
            var num12 = decimal.Parse(this.textBox12.Text);
            var num11 = decimal.Parse(this.textBox11.Text);
            var kj = num12 * num11;
            textBox10.Text = kj.ToString();
            var num9 = decimal.Parse(this.textBox9.Text);
            var num8 = decimal.Parse(this.textBox8.Text);
            var kjf = num9 / num8;
            textBox7.Text = kjf.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Суматорче_Load(object sender, EventArgs e)
        {

        }
    }
}
