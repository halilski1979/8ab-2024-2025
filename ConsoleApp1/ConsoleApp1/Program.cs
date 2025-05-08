namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Iva","Ivan","Ivancho","Kiril","Petar" };
            Console.WriteLine(string.Join(" ",list));

            var newName=list.Where(x=>x.Contains("ir")).ToList();
            Console.WriteLine(string.Join(" ",newName));

        }
    }
}
