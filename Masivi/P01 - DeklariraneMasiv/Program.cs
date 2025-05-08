namespace P01___DeklariraneMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Деклариране на масив
            int[] num = new int[10];
            string[] names = new string[10];
            char[] chars = new char[10];
            double[] values = new double[10];

            //Задаване на стойности на масив
            num[0] = 12;
            num[1] = 23;
            num[2] = 114;

            names[0] = "Ivan";
            names[1] = "Petar";
            names[2] = "Kiko";

            chars[0] = '!';
            chars[1] = ',';
            chars[2] = 'A';

            values[0] = 3.14;
            values[1] = 4.33;
            values[2] = 8.432;

            //Отпечатване на елементи на масив

            //Вариант 1 на печат
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            //Вариант 2 на печат
           foreach (string element in names)
            {
                Console.WriteLine(element);
            }

            //Вариант 3 на печат
            Console.WriteLine(string.Join(" ",chars));


        }
    }
}
