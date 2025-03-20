namespace P12___Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Password=pass

            while (true)
            {
                Console.Write("Insert Password: ");

                string password=Console.ReadLine();

                if (password == "pass")
                {
                    Console.WriteLine("USER, Welcome!");
                    break;
                }

            }
        }
    }
}
