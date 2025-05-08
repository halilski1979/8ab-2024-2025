namespace Zadacha_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int n = int.Parse(Console.ReadLine());
                Dictionary<int, int> elements = new Dictionary<int, int>();
                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (elements.ContainsKey(num))
                    {
                        elements[num]++;
                    }
                    else
                    {
                        elements.Add(num, 1);
                    }

                }
                foreach (var item in elements)
                {
                    Console.WriteLine($"число: {item.Key}, брой: {item.Value}");
                }
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
