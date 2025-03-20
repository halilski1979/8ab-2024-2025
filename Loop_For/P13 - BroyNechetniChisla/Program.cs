namespace P13___BroyNechetniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i); //Отпечатва нечетно
                    br += 1;              //Увеличава брояча
                }
            }

            Console.WriteLine($"Broy nechetni: {br}");

        }
    }
}
