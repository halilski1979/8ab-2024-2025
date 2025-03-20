namespace P10___SborChisla_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int s = 0;

            while (true)
            {
                i++;
                s += i;
                if (i>=10)
                {
                    break; 
                }
            }
            Console.WriteLine(s);

        }
    }
}
