namespace DZI_Zad26
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BookList bookList = new BookList();
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        string title = Console.ReadLine();
                        int pages = int.Parse(Console.ReadLine());
                        bookList.Add(new Book(title, pages));
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }//end for
                Console.WriteLine("Съдържание на списъка:");
                for (int i = 0; i < bookList.Count; i++)
                {
                    Console.WriteLine(bookList.Get(i));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
