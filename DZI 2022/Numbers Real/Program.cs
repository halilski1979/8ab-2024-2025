namespace Numbers_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{

                List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                SortedDictionary<double, int> sorter = new SortedDictionary<double, int>();
                foreach (var element in list)
                {
                    if (sorter.ContainsKey(element))
                    {
                        sorter[element]++;
                    }
                    else
                    {
                        sorter.Add(element, 1);
                    }
                }
                foreach (var element in sorter)
                {
                    Console.WriteLine($"{element.Key} -> {element.Value}");
                }
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
