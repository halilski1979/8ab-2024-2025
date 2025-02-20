namespace MaxEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();
            int minLen=Math.Min(arrayOne.Length, arrayTwo.Length);
            int brLeft = 0;int brRight = 0;
            for (int i = 0; i < minLen; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    brLeft++;
                }
            }//end1
            for (int i = 0; i <minLen; i++)
            {
                if (arrayOne[arrayOne.Length - 1 - i] == arrayTwo[arrayTwo.Length-1-i])
                {
                    brRight++;
                }
            }//end2
            if (brLeft>=brRight&&brLeft>0)
            {
                for (int i = 0; i < brLeft; i++)
                {
                    Console.Write(arrayOne[i]+" ");
                }
            }
            else if (brRight>brLeft&&brRight>0)
            {
                for (int i = 0; i < minLen; i++)
                {
                    Console.Write(arrayOne[arrayOne.Length-1-i]+" ");
                }
            }
            else
            {
                Console.WriteLine("Няма общи думи от ляво и от дясно");
            }
        }
    }
}
