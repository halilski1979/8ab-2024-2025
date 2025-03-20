namespace P12___str._98_Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            int max=int.MinValue;

            for (int i = 0; i < br; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max= number;
                }
            }

            Console.WriteLine($"MAX={max}");
        }
    }
}
