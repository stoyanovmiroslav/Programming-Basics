﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        
    }

        private void buttonCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));

        }
    }
}
