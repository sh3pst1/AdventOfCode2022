namespace TheApp.Days
{
    public static class Day04
    {
        public static int Part1(string[] lines)
        {
            var value = 0;
            foreach (var line in lines)
            {
                var sectionAssignmentPairs = line.Split(",");
                var firstRange = sectionAssignmentPairs[0].Split("-");
                var secondRange = sectionAssignmentPairs[1].Split("-");
                value += GetFullOverlaps(firstRange, secondRange);
            }

            Console.WriteLine($"{nameof(Day04)}{nameof(Part1)} Result: {value}");
            return value;
        }

        private static int GetFullOverlaps(string[] firstRange, string[] secondRange)
        {
            if (int.Parse(firstRange[0]) >= int.Parse(secondRange[0]) && int.Parse(firstRange[1]) <= int.Parse(secondRange[1]))
            {
                return 1;
            }

            if (int.Parse(secondRange[0]) >= int.Parse(firstRange[0]) && int.Parse(secondRange[1]) <= int.Parse(firstRange[1]))
            {
                return 1;
            }

            return 0;
        }

        public static int Part2(string[] lines)
        {
            var value = 0;
            foreach (var line in lines)
            {
                var sectionAssignmentPairs = line.Split(",");
                var firstRange = sectionAssignmentPairs[0].Split("-");
                var secondRange = sectionAssignmentPairs[1].Split("-");
                value += GetSomeOverlaps(firstRange, secondRange);
            }

            Console.WriteLine($"{nameof(Day04)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static int GetSomeOverlaps(string[] firstRange, string[] secondRange)
        {
            for (var i = int.Parse(firstRange[0]); i <= int.Parse(firstRange[1]); i++)
            {
                for (var j = int.Parse(secondRange[0]); j <= int.Parse(secondRange[1]); j++)
                {
                    if (i==j)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}
