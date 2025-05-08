namespace zad_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> listOfString = new List<string>();
           var command = Console.ReadLine().Split(' ').ToList();
            while (command[0]!="END")
            {
                try
                {
                    if (command[0] == "Add")
                    {
                        for (int i = 1; i < command.Count; i++)
                        {
                            listOfString.Add(command[i]);
                        }
                    }
                    else if (command[0] == "Update")
                    {
                        for (int i = 0; i < listOfString.Count-1; i++)
                        {
                            if (char.IsLetter(listOfString[i][0]))
                            {
                                string temp = listOfString[i][0].ToString().ToUpper() + listOfString[i].Substring(1, listOfString.Count - 1);
                                listOfString[i] = temp;
                            }
                        }

                    }
                    else if (command[0] == "Remove")
                    {
                        int n = int.Parse(command[1]);
                        listOfString.RemoveAt(n);
                    }
                    else if (command[0] == "Search")
                    {
                        string search = command[1];
                        if (listOfString.Contains(search))
                        {
                            Console.WriteLine(search);
                        }
                        Console.WriteLine("Not contained.");
                    }
                    else if (command[0] == "Length")
                    {
                        int num = int.Parse(command[1]);
                        var list5 = listOfString.Where(x => x.Length == num).ToList();
                        Console.WriteLine(string.Join("-", list5));
                    }
                    else if (command[0] == "Insert")
                    {
                        int number = int.Parse(command[1]);
                        string word = command[2];
                        if (number < 0 || number > listOfString.Count - 1)
                        {
                            throw new ArgumentException("There are not enough items in the list.");
                        }
                        else
                        {
                            listOfString.Insert(number, word);
                        }
                    }
                    else if (command[0] == "Print")
                    {

                        Console.WriteLine(string.Join("; ", listOfString));

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                   
                }
               command = Console.ReadLine().Split(' ').ToList();

            }
        }
    }
}
