namespace P03___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            while (true)
            {
                Console.WriteLine($"Name {i}");
                i++;

                if (i==21)
                {
                    break;
                }
            }
        }
    }
}
