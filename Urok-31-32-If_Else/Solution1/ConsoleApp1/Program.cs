namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма с графичен интерфейс,която    намира    периметъра и лицето    на правоъгълник, като    прави    проверка    за коректността на входните данни.


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                int s = a * b;
                int p = 2 * a + 2 * b;
                Console.WriteLine($"S={s}");
                Console.WriteLine($"P={p}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
