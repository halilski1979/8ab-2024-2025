namespace Longest_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string,int> map = new Dictionary<string,int>();
            Dictionary<string,int>map1= new Dictionary<string,int>();   
            int lenOne=arrayOne.Length;
            int lenTwo=arrayTwo.Length;
            int minLen = 0;int br1=0; int br2=0;
            if (lenOne>=lenTwo)
            {
                minLen = lenTwo;
            }
            else { minLen = lenOne; }
            for (int i = 0; i < minLen; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    if (!map.ContainsKey(arrayOne[i]))
                    {
                        map.Add(arrayOne[i], 1);
                        br1++;
                    }
                }
            }
            for (int i = minLen - 1; i >= 0; i--)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    if (!map1.ContainsKey(arrayOne[i]))
                    {
                        map1.Add(arrayOne[i], 1);
                        br2++;
                    }
                }
            }
            if (br1>br2)
            {
                foreach (var item in map)
                {
                    Console.Write(item.Key+" ");
                }
            }
            if (br2>br1)
            {
                foreach (var item in map1)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
