﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = (a + b).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = (a * b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = (a / b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = (a % b).ToString();
        }
    }
}
