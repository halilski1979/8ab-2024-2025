namespace IndexLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            for (var j = 0; j < text.Length; j++)
            {
                for (var i = 'a'; i <= 'z'; i++)
                {
                    if (text[j] == i)
                    {
                        Console.WriteLine($"{text[j]}->{(int)i - 97}");
                    }
                }//end2

            }//end 1
        }
    }
}
