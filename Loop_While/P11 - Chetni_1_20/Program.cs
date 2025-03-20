namespace P11___Chetni_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Печат четни 1..20
            
            int i = 0;          
            
            while (i<=20)
            {
                i++;
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
