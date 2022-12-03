namespace TheApp.Days
{
    public static class Day03
    {
        public static int Part1(string[] lines)
        {
            var value = 0;
            foreach (var line in lines)
            {
                var half = line.Length / 2;
                var firstCompartment = line[..half];
                var secondCompartment = line[half..];

                value += GetScore(firstCompartment, secondCompartment);
            }

            Console.WriteLine($"{nameof(Day03)}{nameof(Part1)} Result: {value}");
            return value;
        }

        public static int Part2(string[] lines)
        {
            var value = 0;

            for (int i = 0; i < lines.Length; i+=3)
            {
                var c = GetMatchedChar(lines.Skip(i).Take(3).ToArray());
                value += Priorities.First(x => x.Key == c).Value;
            }

            Console.WriteLine($"{nameof(Day03)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static char GetMatchedChar(string[] lines)
        {
            foreach (char c in lines[0])
            {
                if (lines[1].Contains(c) && lines[2].Contains(c))
                {
                    return c;
                }
            }

            throw new ArgumentException("Ooops");
        }

        private static int GetScore(string firstCompartment, string secondCompartment)
        {
            foreach (var c in firstCompartment)
            {
                if (secondCompartment.Contains(c))
                {
                    return Priorities.First(x => x.Key == c).Value;
                }
            }

            return 0;
        }

        private static Dictionary<char, int> Priorities => InitPriorities();

        private static Dictionary<char, int> InitPriorities()
        {
            var priorities = new Dictionary<char, int>();
            var value = 1;
            for (var c = 'a'; c <= 'z'; c++)
            {
                priorities.Add(c, value);
                value++;
            }
            for (var c = 'A'; c <= 'Z'; c++)
            {
                priorities.Add(c, value);
                value++;
            }

            return priorities;
        }
    }
}
