using System;
using System.Collections.Generic;

namespace Assignments
{
    public static class Extensions
    {
        // Custom DistinctBy extension (NO LINQ DistinctBy)
        public static IEnumerable<T> DistinctBy<T, TKey>(
            this IEnumerable<T> source,
            Func<T, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();

            foreach (var item in source)
            {
                if (seenKeys.Add(keySelector(item)))
                {
                    yield return item;
                }
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            string[] items =
            {
                "1:Alice",
                "2:Bob",
                "1:Alex",
                "3:Charlie",
                "2:Brian"
            };

            List<string> distinctNames = new List<string>();

            foreach (var item in items.DistinctBy(i => i.Split(':')[0]))
            {
                distinctNames.Add(item.Split(':')[1]);
            }

            Console.WriteLine("[" + string.Join(", ", distinctNames) + "]");
        }
    }
}
