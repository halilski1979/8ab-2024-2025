namespace P01___Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string name=textBox1.Text;
           string lastName=textBox2.Text;
           int age=int.Parse(textBox3.Text);
           double grade=double.Parse(textBox4.Text);
           int klas=int.Parse(textBox5.Text);
           char par=char.Parse(textBox6.Text);


           label5.Text = $"Казвам се {name} {lastName}. Аз съм на {age} години. Имам успех {grade}!!!  ";



        }
    }
}
