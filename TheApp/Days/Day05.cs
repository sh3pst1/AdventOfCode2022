namespace TheApp.Days
{
    public static class Day05
    {
        public static string Part1(string[] lines)
        {
            var stacksOfCrates = GetStacks(lines);

            foreach (var line in lines.Where(x => x.StartsWith("move")))
            {
                var instructions = line.Replace("move", "").Replace("from", ",").Replace("to", ",").Replace(" ", "").Split(",");
                var from = stacksOfCrates.First(x => x.Id == int.Parse(instructions[1]));
                var to = stacksOfCrates.First(x => x.Id == int.Parse(instructions[2]));
                for (var i = 0; i < int.Parse(instructions[0]); i++)
                {
                    to.Crates.Insert(0, from.Crates[0]);
                    from.Crates.RemoveAt(0);
                }
            }

            var value = stacksOfCrates.OrderBy(x => x.Id).Aggregate("", (current, stack) => current + stack.Crates[0]);
            Console.WriteLine($"{nameof(Day05)}{nameof(Part1)} Result: {value}");
            return value;
        }

        public static string Part2(string[] lines)
        {
            var stacksOfCrates = GetStacks(lines);

            foreach (var line in lines.Where(x => x.StartsWith("move")))
            {
                var instructions = line.Replace("move", "").Replace("from", ",").Replace("to", ",").Replace(" ", "").Split(",");
                var from = stacksOfCrates.First(x => x.Id == int.Parse(instructions[1]));
                var to = stacksOfCrates.First(x => x.Id == int.Parse(instructions[2]));

                var range = from.Crates.Skip(0).Take(int.Parse(instructions[0]));
                to.Crates.InsertRange(0, range);
                from.Crates.RemoveRange(0, int.Parse(instructions[0]));
            }

            var value = stacksOfCrates.OrderBy(x => x.Id).Aggregate("", (current, stack) => current + stack.Crates[0]);
            Console.WriteLine($"{nameof(Day05)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static List<Stack> GetStacks(string[] lines)
        {
            var lastCol = int.Parse(lines.First(x => x.StartsWith(" 1")).Trim().Last().ToString());
            var stacksOfCrates = new List<Stack>();
            for (var i = 1; i <= lastCol; i++)
            {
                stacksOfCrates.Add(new Stack { Id = i });
            }

            foreach (var line in lines)
            {
                if (line.StartsWith(" 1"))
                {
                    break;
                }

                var sLine = line;
                for (var i = 1; i <= lastCol; i++)
                {
                    var stopIndex = i == lastCol ? 3 : 4;
                    var part = sLine[..stopIndex];
                    var create = part.Trim().Replace("[", "").Replace("]", "");
                    if (!string.IsNullOrWhiteSpace(create))
                    {
                        stacksOfCrates.First(x => x.Id == i).Crates.Add(create);
                    }

                    sLine = sLine.Remove(0, stopIndex);
                }
            }

            return stacksOfCrates;
        }
    }

    public class Stack
    {
        public int Id { get; set; }
        public List<string> Crates { get; set; } = new();
    }
}
