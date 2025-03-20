namespace P10___PolojitelnoOtricatelno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Polojitelno");
            }
            else if (a < 0)
            {
                Console.WriteLine("Otricatelno");

            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
