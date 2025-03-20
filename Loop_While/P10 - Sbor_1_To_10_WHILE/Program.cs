namespace P10___Sbor_1_To_10_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int s = 0;

            while (i<10)
            {
                i++;
                s += i;
            }
            Console.WriteLine(s);
        }
    }
}
