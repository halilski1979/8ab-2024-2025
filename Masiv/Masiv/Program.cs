namespace Masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[]elements= new int[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }//end for
            Console.WriteLine($"Min= {elements.Min()}");
            Console.WriteLine($"Max= {elements.Max()}");
            Console.WriteLine($"Sum= {elements.Sum()}");
            Console.WriteLine($"Average= {elements.Average()}");
        }
    }
}
