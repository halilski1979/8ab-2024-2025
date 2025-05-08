namespace WinFormsApp1
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
            Random r= new Random();

            //Pen p = new Pen(Color.Blue, 3);
            int a = 20;
            int b = 420;   
                      

            for (int i = 0; i < 11; i++)
            {
                Pen p = new Pen(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)), 3);
                g.DrawEllipse(p, a, a, b, b);
                a += 20;
                b -= 40;
            }
        }
    }
}
