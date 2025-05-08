namespace P01___Demo
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

        protected override void OnPaint(PaintEventArgs e)
        {
           Graphics g = e.Graphics;

           //Задаване цвят н аработно поле
           // g.Clear(Color.Purple);
           g.Clear(Color.FromArgb(51,255,100));

            //2. Създаване на писалка
            Pen p = new Pen(Color.Blue,3);
            Pen q= new Pen(Color.Red,3);
            Pen m = new Pen(Color.Yellow, 3);             

        }


    }
}
