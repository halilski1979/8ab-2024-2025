namespace P03___Kvadrat_Perimetar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Лице и периметър на квадрат
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());

            if (a>0)
            {
                int s = a * a;
                int p = 4 * a;

                Console.WriteLine($"S={s}");
                Console.WriteLine($"P={p}");
            }
            else
            {
                Console.WriteLine("Greshka vav dannite!");
            }

        }
    }
}
