namespace P6___Brush
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

            Brush b = new SolidBrush(Color.Blue);
            g.FillRectangle(b,10,10,200,600);
        }
    }
}
