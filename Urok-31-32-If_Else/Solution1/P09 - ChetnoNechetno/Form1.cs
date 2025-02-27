namespace P09___ChetnoNechetno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);



            if (a/2>0 && a%2==0)
            {
                textBox2.Text = "вермн";
            }
            else
            {
               textBox2.Text = "мевермн";
            }
        }
    }
}
