namespace P06___PoGolqmoChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //По-голямо от две въведени числа
            
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b=int.Parse(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
