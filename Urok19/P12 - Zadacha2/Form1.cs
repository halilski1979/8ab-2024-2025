namespace P12___Zadacha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = $"Темературата днес ({textBox1.Text}) е {textBox2.Text} градуса!";

            string day = textBox1.Text;
            int temperatura =int.Parse(textBox2.Text);
            label4.Text = $"Темературата днес ({day}) е {temperatura} градуса!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
