namespace P11___LicaFiguri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Напишете  приложение  с  Конзолен интерфейс
            //Figures, което по зададени страни да може данамира лицето и/или периметъра на избрана отпотребителя  фигура-  квадрат,  правоъгълникили триъгълник.



            string figure =Console.ReadLine();

            if (figure=="square")
            {
                int a=int.Parse(Console.ReadLine());
                if (a<0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    int s = a * a;
                    int p = 4 * a;
                    Console.WriteLine($"S={s}");
                    Console.WriteLine($"P={p}");
                }
            }

            if (figure == "rectangle")
            {
                int a=int.Parse(Console.ReadLine());
                int b=int.Parse(Console.ReadLine());

                if (a < 0 || b < 0)
                {
                    Console.WriteLine("Error");
                }
                else 
                {
                    int p = 2 * a + 2 * b;
                    int s = a * b;
                    Console.WriteLine($"S={s}");
                    Console.WriteLine($"P={p}");
                }
            }

        }
    }
}
