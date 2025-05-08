namespace P03___DrawElipse
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
           
            Pen red = new Pen(Color.Black,6);
            int x1 = 10;
          

            for (int i = 0; i < 4; i++)
            {
                g.DrawEllipse(red, x1, 10, 120, 120);
                x1 += 80;
            }
        }
    }
}
