namespace P02___Kvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a=int.Parse(Console.ReadLine());

            if (a > 0)
            {
                int s = a * a;
                Console.WriteLine($"S={s}");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
