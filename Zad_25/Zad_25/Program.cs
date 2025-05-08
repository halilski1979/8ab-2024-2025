namespace Zad_25
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.Write("Вход: ");
                int n = int.Parse(Console.ReadLine());
                int tempN = n;
                bool search = true;
                while (tempN > 0)
                {
                    int digit = tempN % 10;
                    if (n % digit != 0)
                    {
                        Console.WriteLine("No");
                        search = false;
                        break;
                    }
                    tempN /= 10;

                }
                if (search == true)
                {
                    Console.WriteLine("Yes");
                }
            }
			catch (Exception)
			{

                Console.WriteLine("Something went wrong!");

            }
        }
    }
}
