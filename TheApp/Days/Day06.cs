using System;

namespace TheApp.Days
{
    public static class Day06
    {
        public static int Part1(string input)
        {
            var value = GetUniqueValue(input, 4);
            Console.WriteLine($"{nameof(Day06)}{nameof(Part1)} Result: {value}");
            return value;
        }

        public static int Part2(string input)
        {
            var value = GetUniqueValue(input, 14);
            Console.WriteLine($"{nameof(Day06)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static int GetUniqueValue(string input, int offset)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var part = input.Substring(i, offset);
                var unique = false;
                foreach (var c in part)
                {
                    if (part.Count(x => x == c) > 1)
                    {
                        unique = false;
                        break;
                    }

                    unique = true;
                }

                if (unique)
                {
                    return i + offset;
                }
            }

            throw new Exception("Something went terrible wrong...");
        }
    }
}
