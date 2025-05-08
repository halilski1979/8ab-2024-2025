namespace Miner_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> map = new Dictionary<string,int>();
            while (true) 
            {
             string articul=Console.ReadLine();
             if (articul == "stop") { break; }
             int quantity=int.Parse(Console.ReadLine());
                if (map.ContainsKey(articul))
                {
                    map[articul] += quantity;
                }
                else
                {
                    //map.Add(articul, quantity);
                    map[articul]=quantity;
                }   
            }
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
