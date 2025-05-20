using System;
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
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int GetRandNumber()
        {  
           return r.Next() % 49 + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetRandNumber().ToString();
            textBox2.Text = GetRandNumber().ToString();
            textBox3.Text = GetRandNumber().ToString();
            textBox4.Text = GetRandNumber().ToString();
            textBox5.Text = GetRandNumber().ToString();
            textBox6.Text = GetRandNumber().ToString();
        }
     

     }
}
