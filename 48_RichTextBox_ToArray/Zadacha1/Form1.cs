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
                // ������� ������� �� RichTextBox
                string input = richTextBox1.Text;

                // ������������� ������ � ����� �� ���� �����
                int[] numbers = input
                    .Split(new[] { ' ', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // ������� ����������� �� P � Q
                int P = int.Parse(textBox1.Text);
                int Q = int.Parse(textBox2.Text);

                // ����� ����� ����� �� � ��������� [P;Q]
                int count = numbers.Count(n => n >= P && n <= Q);

                // ��������� ���������
                label1.Text = $"���� ����� � ��������� [{P};{Q}]: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("����, ������� ��, �� ���������� ��������� �� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Red;
        }
    }
}
