namespace TheApp.Days
{
    public static class Day08
    {
        public static int Part1(string[] lines)
        {
            var width = lines[0].Length;
            var height = lines.Length;

            var value = width * 2 + (height - 2) * 2;

            var coordinates = GetCoordinates(lines);

            foreach (var coordinate in coordinates.Where(a => a.X > 0 && a.Y > 0 && a.X < width - 1 && a.Y < height - 1))
            {
                var forCompare = coordinates.Where(a => a.X == coordinate.X || a.Y == coordinate.Y).ToList();

                if (forCompare.Where(a => a.X < coordinate.X).All(z => z.Value < coordinate.Value))
                {
                    value++;
                    continue;
                }

                if (forCompare.Where(a => a.X > coordinate.X).All(z => z.Value < coordinate.Value))
                {
                    value++;
                    continue;
                }

                if (forCompare.Where(a => a.Y < coordinate.Y).All(z => z.Value < coordinate.Value))
                {
                    value++;
                    continue;
                }

                if (forCompare.Where(a => a.Y > coordinate.Y).All(z => z.Value < coordinate.Value))
                {
                    value++;
                }
            }

            Console.WriteLine($"{nameof(Day08)}{nameof(Part1)} Result: {value}");
            return value;
        }

        public static int Part2(string[] lines)
        {
            var width = lines[0].Length;
            var height = lines.Length;

            var value = 0;

            var coordinates = GetCoordinates(lines);

            foreach (var coordinate in coordinates)
            {
                var upCount = 0;
                for (var i = coordinate.Y - 1; i >= 0; i--)
                {
                    var comp = coordinates.First(a => a.Y == i && a.X == coordinate.X);
                    if (comp.Value >= coordinate.Value)
                    {
                        upCount++;
                        break;
                    }

                    upCount++;
                }

                var leftCount = 0;
                for (var i = coordinate.X - 1; i >= 0; i--)
                {
                    var comp = coordinates.First(a => a.X == i && a.Y == coordinate.Y);
                    if (comp.Value >= coordinate.Value)
                    {
                        leftCount++;
                        break;
                    }

                    leftCount++;
                }

                var downCount = 0;
                for (var i = coordinate.Y + 1; i < height; i++)
                {
                    var comp = coordinates.First(a => a.Y == i && a.X == coordinate.X);
                    if (comp.Value >= coordinate.Value)
                    {
                        downCount++;
                        break;
                    }

                    downCount++;
                }

                var rightCount = 0;
                for (var i = coordinate.X + 1; i < width; i++)
                {
                    var comp = coordinates.First(a => a.X == i && a.Y == coordinate.Y);
                    if (comp.Value >= coordinate.Value)
                    {
                        rightCount++;
                        break;
                    }

                    rightCount++;
                }

                var score = upCount * leftCount * downCount * rightCount;
                if (score > value)
                {
                    value = score;
                }
            }

            Console.WriteLine($"{nameof(Day08)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static List<Coordinate> GetCoordinates(string[] lines)
        {
            var result = new List<Coordinate>();
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                for (var j = 0; j < line.Length; j++)
                {
                    result.Add(new Coordinate { Value = int.Parse(line[j].ToString()), X = j, Y = i });
                }
            }

            return result;
        }
    }

    public class Coordinate
    {
        public int Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }
}
