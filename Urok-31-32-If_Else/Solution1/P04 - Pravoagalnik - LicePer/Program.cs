namespace P04___Pravoagalnik___LicePer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a=double.Parse(Console.ReadLine());

            Console.Write("b=");
            double b=double.Parse(Console.ReadLine());

            if (a>0 && b>0)
            {
                double s = a * b;
                double p = 2 * a + 2 * b;

                Console.WriteLine($"Liceto e {s}");
                Console.WriteLine($"Perimetara e {p}");
            }
            else
            {
                Console.WriteLine($"Error!");
            }
        }
    }
}
