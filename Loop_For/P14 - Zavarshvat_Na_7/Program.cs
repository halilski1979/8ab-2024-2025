namespace P14___Zavarshvat_Na_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Числа, завършващи на 7  от 1 до 1000

            for (int i = 1; i < 1001; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
