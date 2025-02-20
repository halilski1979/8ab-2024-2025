namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine($"{a} e polojitelno.");
            }
            else
            {
                Console.WriteLine($" {a} e otricatelno");           
            }


        }
    }
}
