namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("a");
            foreach (var item in set) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
