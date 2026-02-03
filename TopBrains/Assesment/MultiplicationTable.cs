using System;

namespace Assignments
{
    public class MultiplicationTable
    {
        public static void Main()
        {
            int n = 3;
            int upto = 5;

            int[] row = new int[upto];

            for (int i = 1; i <= upto; i++)
            {
                row[i - 1] = n * i;
            }

            Console.WriteLine("[" + string.Join(", ", row) + "]");
        }
    }
}
