namespace Zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Вземаме числата от RichTextBox
                string input = richTextBox1.Text;

                // Преобразуваме текста в масив от цели числа
                int[] numbers = input
                    .Split(new[] { ' ', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // Вземаме стойностите на P и Q
                int P = int.Parse(textBox1.Text);
                int Q = int.Parse(textBox2.Text);

                // Броим колко числа са в интервала [P;Q]
                int count = numbers.Count(n => n >= P && n <= Q);

                // Показваме резултата
                label1.Text = $"Брой числа в интервала [{P};{Q}]: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Моля, уверете се, че въведените стойности са цели числа.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Red;
        }
    }
}
