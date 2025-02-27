﻿namespace left_and_right_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <=2*n; i++)
            {
                int number=int.Parse(Console.ReadLine());
                if (i<=n)
                {
                    leftSum += number;
                }
                else if (i>n)
                {
                    rightSum += number;
                }
            }//end for
            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}
