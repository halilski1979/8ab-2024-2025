namespace Razpiska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>>products = new Dictionary<string,List<double>>();
            var danni = Console.ReadLine().Split(' ').ToList();
            while (danni[0]!="stocked")
            {
                string productName=danni[0];
                double price=double.Parse(danni[1]);
                double quantity=double.Parse(danni[2]);
                List<double>productInfo = new List<double>();
                productInfo.Add(price);
                productInfo.Add(quantity);
                if (products.ContainsKey(productName))
                {
                    products[productName][1] += quantity;
                    if (price != products[productName][0])
                    {
                        products[productName][0] = price;
                    }
                }
                else 
                { 
                products.Add(productName, productInfo);
                }
                danni = Console.ReadLine().Split(' ').ToList();
            }//end1
            foreach (var p in products) 
            {
                Console.WriteLine($"“{p.Key}: ${p.Value[0]:F2} * {p.Value[1]} = ${p.Value[0]* p.Value[1]:f2}");
                Console.WriteLine(new string('-',30));
            }
        }
    }
}
