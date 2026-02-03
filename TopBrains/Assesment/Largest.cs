using System;

namespace Assignments
{
    public class LargestOfThree
    {
        static int GetLargest(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;
        }

        public static void Main()
        {
            int a = 10, b = 25, c = 15;

            int largest = GetLargest(a, b, c);

            Console.WriteLine(largest);
        }
    }
}
