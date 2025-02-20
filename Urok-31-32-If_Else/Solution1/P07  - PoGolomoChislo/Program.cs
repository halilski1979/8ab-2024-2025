namespace P07____PoGolomoChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine(a);
            }

            if (b>a && b>c)
            {
                Console.WriteLine(b);
            }

            if (c > a && c > b)
            {
                Console.WriteLine(c);
            }

        }
    }
}
