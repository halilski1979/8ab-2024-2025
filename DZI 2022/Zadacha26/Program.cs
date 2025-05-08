namespace Zadacha26
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                ItemList list = new ItemList();
                Console.Write("Въведете броя на стоките: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Въведи описание: ");
                    string desc = Console.ReadLine();
                    Console.Write("Въведете цена: ");
                    double price = double.Parse(Console.ReadLine());
                    list.Add(new Item(desc, price));
                }
                Console.WriteLine(list);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex);
				
			}
        }
    }
}
