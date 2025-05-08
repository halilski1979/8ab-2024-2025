namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            List<string> data = Console.ReadLine().Split(' ').ToList();
            while (data[0]!="END")
            {
                if (data[0]=="Add")
                {
                    string name = data[1];
                    string phone=data[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }
                }
                if (data[0]=="Remove")
                {
                    string name = data[1];
                    if (phonebook.ContainsKey(name))
                    {
                       phonebook.Remove(name);
                    }
                }
                if (data[0]=="Search")
                {
                    string name = data[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Телефонният номер {name} е: {phonebook[name]}");
                    }
                }
                if (data[0]=="Update")
                {
                    string name = data[1];
                    string phone= data[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name]=phone;
                    }
                }
                if (data[0]=="Print")
                {
                    foreach (var phone in phonebook)
                    {
                        Console.WriteLine($"{phone.Key} | {phone.Value}");
                    }
                }
                data = Console.ReadLine().Split(' ').ToList();
            }//end while

        }
    }
}
