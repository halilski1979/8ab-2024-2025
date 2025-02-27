namespace P08___CheckRadioButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;

            if (radioButton1.Checked == true)
            {
                price = 10;
            }
            else if (radioButton2.Checked == true)
            {
                price = 12;
            }

            else if (radioButton3.Checked == true)
            {
                price = 14;
            }


            if (checkBox1.Checked==true)
            {
                price = price + 1;
            }
            if(checkBox2.Checked == true)
            {
                price += 1;
            }
            if(checkBox3.Checked == true)
            {
                price += 1;
            }
            if (checkBox4.Checked==true)
            {
                price += 1;
            }

            int broy = int.Parse(textBox2.Text);
            double finalPrice=price*broy;
            
            textBox1.Text = finalPrice.ToString();   

        }


        
    }
}
