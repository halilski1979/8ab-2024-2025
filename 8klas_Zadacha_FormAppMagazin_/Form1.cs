namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kol = double.Parse(textBox1.Text);
            double price = double.Parse(textBox2.Text);

            double s = kol * price;
           textBox4.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label3.Text= string.Empty;
            label5.Text = string.Empty;
        }
    }
}
