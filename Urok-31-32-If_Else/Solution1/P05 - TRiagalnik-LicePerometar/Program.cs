namespace P05___TRiagalnik_LicePerometar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // S и P на триъгълник

            Console.Write("a=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b=double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c=double.Parse(Console.ReadLine());

            if (a>0 && b>0 && c>0)
            {
                double p = a + b + c;
                double s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));

                Console.WriteLine($"Liceto e {s:f2}");
                Console.WriteLine($"Perimetara e {p}");
            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
