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
            label3.Text = $"������������ ���� ({textBox1.Text}) � {textBox2.Text} �������!";

            string day = textBox1.Text;
            int temperatura =int.Parse(textBox2.Text);
            label4.Text = $"������������ ���� ({day}) � {temperatura} �������!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
