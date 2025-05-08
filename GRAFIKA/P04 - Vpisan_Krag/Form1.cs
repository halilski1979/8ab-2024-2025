namespace P04___Vpisan_Krag
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
            Pen p = new Pen(Color.Red,3);
            Graphics g = e.Graphics;

            Random r=new Random();

            int x = 10;
            int y = 400;


            for (int i = 0; i < 10; i++)
            {
                p=new Pen(Color.FromArgb(r.Next(0,255), r.Next(0, 255), r.Next(0, 255)),3);

                g.DrawEllipse(p,x,x,y,y);
                x += 20;
                y -= 40;
            }
        }
    }
}
