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
            int a = int.Parse(textBox1.Text);
            int p = a * 4;
            label3.Text = $"{p.ToString()} kv.sm"; 
            int s = a * a;
            label5.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label3.Text= string.Empty;
            label5.Text = string.Empty;
        }
    }
}
