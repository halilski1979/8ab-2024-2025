namespace P13___Zadacha3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstIndex=int.Parse(textBox1.Text);
            int secondIndex=int.Parse(textBox2.Text);
            
            textBox4.Text = textBox3.Text.Substring(firstIndex,secondIndex);
        }
    }
}
