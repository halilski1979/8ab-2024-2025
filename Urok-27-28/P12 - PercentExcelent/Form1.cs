namespace P12___PercentExcelent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uchenici=double.Parse(textBox1.Text);
            double otlichnici=double.Parse(textBox2.Text);
            double percent=(otlichnici/uchenici)*100;
            label3.Text = $"Procenta na otlichicite e {percent:f2}%.";
        }
    }
}
