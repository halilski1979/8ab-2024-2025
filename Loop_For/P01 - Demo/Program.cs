namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int br = int.Parse(Console.ReadLine());
            int Max=int.MinValue;

            for (int i = 0; i < br; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > Max)
                {
                    Max= number;
                }
            }
            Console.WriteLine($"MAX={Max}");
        }
    }
}
