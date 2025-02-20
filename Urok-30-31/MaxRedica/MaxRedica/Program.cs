using System.ComponentModel.DataAnnotations;

namespace MaxRedica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]elements=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;int len = 1;
            int bestStart = 0;int bestLen=1;
            for (int i = 1; i < elements.Length-1; i++)
            {
                if (elements[i] == elements[i-1])
                {
                    len++;
                }
                else
                {
                    start = i;len = 1;
                    if (len > bestLen) { bestLen = len; bestStart = start; }
                }
                
            }
            for (int i = bestStart; i <bestLen; i++)
            {
                Console.Write(elements[i]+" ");
            }
        }
                
    }
}
