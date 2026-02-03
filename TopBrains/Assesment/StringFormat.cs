using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Assignments
{
    public class StringFormat
    {
        public record Student(string Name, int Score);

        public static void Main()
        {
            string[] items =
            {
                "Alice:90",
                "Bob:75",
                "Charlie:90",
                "David:60"
            };

            int minScore = 80;

            List<Student> students = new List<Student>();

            foreach (string item in items)
            {
                string[] parts = item.Split(':');
                string name = parts[0];
                int score = int.Parse(parts[1]);

                students.Add(new Student(name, score));
            }

            var filteredSorted = students
                .Where(s => s.Score >= minScore)
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.Name)
                .ToList();

            string json = JsonSerializer.Serialize(filteredSorted);

            Console.WriteLine(json);
        }
    }
}

