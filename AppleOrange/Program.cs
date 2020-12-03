using System;

namespace AppleOrange
{
    class Program
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;
            int i = 0;

            for ( i = 0; i < apples.Length; i++)
            {
                
                if ((apples[i]+a) >= s && (apples[i] + a) <= t)
                {
                    appleCount++;
                }
            }
            for (i = 0; i < oranges.Length; i++)
            {
                
                if ((oranges[i]+b) >= s && (oranges[i] + b) <= t)
                {
                    orangeCount++;
                }
            }
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);

        }


        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
