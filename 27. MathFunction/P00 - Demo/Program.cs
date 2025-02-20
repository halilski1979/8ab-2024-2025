namespace P00___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chislo = Math.PI;
            Console.WriteLine(chislo);

            double log = Math.E;
            Console.WriteLine(log);

            Console.WriteLine($"PI={chislo:f3}");
            Console.WriteLine($"E={log:f3}");
        }
    }
}
