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
                   

          


            Pen green = new Pen(Color.Black, 3);
            int x1 = 20;          
            

            for (int i = 0; i < 4; i++)
            {
                g.DrawEllipse(green, x1, 20, 220, 220);
                x1 += 150;
            }
        }
    }
}
