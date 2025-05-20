using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] questions;
        int numQuestions, currQuestion, points=0, time;
        string[] answers;
        StreamWriter w = new StreamWriter("results.txt", true, Encoding.GetEncoding("windows-1251"));

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader r1 = new StreamReader("questions.txt", Encoding.GetEncoding("windows-1251"));
            questions = new string[100];
            string line = ".", q="";
            numQuestions = 0;
            while (line != null)
            {
                q = "";
                line = ".";
                while (line!="" && line!=null)
                {
                    line = r1.ReadLine();
                    q = q + line + "\n";
                }
                numQuestions++;
                questions[numQuestions] = q;
            }
            r1.Close();
            currQuestion = 1;
            richTextBox1.Text = questions[currQuestion];
            label5.Text = (numQuestions - currQuestion).ToString();
            w.WriteLine("№\tТвоят отговор\tВерен отговор");
            label3.Text = "Въпрос " + currQuestion;
            time = numQuestions * 10; //времето в секунди

            StreamReader r2 = new StreamReader("answers.txt", Encoding.GetEncoding("windows-1251"));
            answers = new string[100];
            for(int i=1; i<=numQuestions; i++)
            {
                line = r2.ReadLine();
                answers[i] = line;
            }
            r2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="Виж резултата си")
            {
                button1.Enabled = false;
                StreamReader r = new StreamReader("results.txt", Encoding.GetEncoding("windows-1251"));
                richTextBox1.Text = r.ReadToEnd();
                r.Close();
                return;
            }
            if(button1.Text=="Край на теста")
            {
                timer1.Stop();
                label4.Text = "Брой точки:";
                label5.Text = points.ToString();
                w.Close();
                button1.Text = "Виж резултата си";
                return;
            }
           
            if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Маркирай отговор!");
                return;
            }
            string ans="";
            if (radioButton1.Checked) { ans = "a"; }
            if (radioButton2.Checked) { ans = "б"; }
            if (radioButton3.Checked) { ans = "в"; }
            if (radioButton4.Checked) { ans = "г"; }
            if (radioButton1.Checked && answers[currQuestion] == "а") { points++; }
            if (radioButton2.Checked && answers[currQuestion] == "б") { points++; }
            if (radioButton3.Checked && answers[currQuestion] == "в") { points++; }
            if (radioButton4.Checked && answers[currQuestion] == "г") { points++; }
            w.WriteLine("{2}\t{0}\t\t\t{1}", ans, answers[currQuestion], currQuestion);
            if (currQuestion == numQuestions)
            {
                button1.Text = "Край на теста";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                return;
            }
            currQuestion++;
            richTextBox1.Text = questions[currQuestion];
            label3.Text = "Въпрос " + currQuestion;
            label5.Text = (numQuestions - currQuestion).ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = time / 60 + " мин. " + time % 60 + " сек.";
            if (time==0)
            {
                timer1.Stop();
                button1.Text = "Край на теста";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
        }
    }
}
