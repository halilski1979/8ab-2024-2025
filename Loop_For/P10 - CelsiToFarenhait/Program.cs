namespace P10___CelsiToFarenhait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = 36.0; i < 38.0; i+=0.1)
            {
                double F = (9.0 / 5.0) * i + 32.0;
                Console.WriteLine($"{i:f2}C = {F:f2} F");
            }
        }
    }
}
