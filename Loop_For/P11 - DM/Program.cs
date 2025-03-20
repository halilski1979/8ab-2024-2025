namespace P11___DM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = 1; i < 11; i++)
            {
                double sm = (i * 10);
                double m= (i / 10);
                Console.WriteLine($"{i} dm = {sm} cm");
                Console.WriteLine($"{i} dm = {m} metra");
                Console.WriteLine();
            }
        }
    }
}
