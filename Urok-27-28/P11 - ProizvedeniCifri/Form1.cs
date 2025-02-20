namespace P11___ProizvedeniCifri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);

            int result = (a / 10) * (a % 10);
            label2.Text = result.ToString();
        }
    }
}
