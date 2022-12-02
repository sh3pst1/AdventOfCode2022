namespace TheApp.Days
{
    internal static class Day01
    {
        private const string Path = @"C:\_development\AdventOfCode\AdventOfCode2022\Day01\input.txt";
        public static void Part1()
        {
            var lines = File.ReadAllLines(Path);
            var results = new List<int>();
            var value = 0;
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    results.Add(value);
                    value = 0;
                    continue;
                }

                value += int.Parse(line);
            }
            var result = results.MaxBy(x => x);
            Console.WriteLine($"{nameof(Day01)}{nameof(Part1)} Result: {result}");
        }

        public static void Part2()
        {
            var lines = File.ReadAllLines(Path);
            var results = new List<int>();
            var value = 0;
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    results.Add(value);
                    value = 0;
                    continue;
                }

                value += int.Parse(line);
            }

            var topThree = results.OrderByDescending(x => x).Take(3);
            Console.WriteLine($"{nameof(Day01)}{nameof(Part2)} Result: {topThree.Sum()}");
        }
    }
}
