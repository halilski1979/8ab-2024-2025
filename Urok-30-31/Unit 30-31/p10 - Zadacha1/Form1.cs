namespace p10___Zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

           
            bool flag = a > b;
            textBox3.Text = flag.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
