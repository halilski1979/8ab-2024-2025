namespace P03___SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;

            for (int i = 1; i <= 10; i++)
            {
                s = s + i;    //s+=i;
            }

            Console.WriteLine(s);
        }
    }
}
