namespace TheApp.Days
{
    public static class Day09
    {
        public static int Part1(string[] lines)
        {
            var value = GetUniquePossessionsCount(lines, 1);
            Console.WriteLine($"{nameof(Day09)}{nameof(Part1)} Result: {value}");
            return value;
        }

        public static int Part2(string[] lines)
        {
            var value = GetUniquePossessionsCount(lines, 9);
            Console.WriteLine($"{nameof(Day09)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static int GetUniquePossessionsCount(string[] lines, int tailLength)
        {
            var lastTailsMovements = new List<Movement>();
            lastTailsMovements.AddRange(GetHeadMovements(lines));
            var currentTailsMovements = new List<Movement>();

            for (var i = 0; i < tailLength; i++)
            {
                var currentX = 0;
                var currentY = 0;
                currentTailsMovements.Clear();
                currentTailsMovements.Add(new() { Y = 0, X = 0 });

                foreach (var tMovement in lastTailsMovements)
                {
                    if (Math.Abs(tMovement.Y - currentY) > 1 || Math.Abs(tMovement.X - currentX) > 1)
                    {
                        var yValue = tMovement.Y;
                        var xValue = tMovement.X;
                        if (Math.Abs(tMovement.Y - currentY) > 1)
                        {
                            yValue = currentY < tMovement.Y ? currentY + 1 : currentY - 1;
                        }

                        if (Math.Abs(tMovement.X - currentX) > 1)
                        {
                            xValue = currentX < tMovement.X ? currentX + 1 : currentX - 1;
                        }

                        currentTailsMovements.Add(new() { Y = yValue, X = xValue });

                        currentX = xValue;
                        currentY = yValue;
                    }
                }

                lastTailsMovements.Clear();
                lastTailsMovements.AddRange(currentTailsMovements);
            }

            return lastTailsMovements.DistinctBy(z => new { z.Y, z.X }).Count();
        }

        private static List<Movement> GetHeadMovements(string[] lines)
        {
            var headMovements = new List<Movement>
            {
                new() { Y = 0, X = 0 }
            };

            var currentX = 0;
            var currentY = 0;
            foreach (var line in lines)
            {
                var directions = line.Split(' ');
                switch (directions[0])
                {
                    case "R":
                        for (var i = 0; i < int.Parse(directions[1]); i++)
                        {
                            headMovements.Add(new() { Y = currentY, X = currentX + 1 });
                            currentX++;
                        }
                        break;

                    case "L":
                        for (var i = 0; i < int.Parse(directions[1]); i++)
                        {
                            headMovements.Add(new() { Y = currentY, X = currentX - 1 });
                            currentX--;
                        }
                        break;

                    case "U":
                        for (var i = 0; i < int.Parse(directions[1]); i++)
                        {
                            headMovements.Add(new() { Y = currentY + 1, X = currentX });
                            currentY++;
                        }
                        break;

                    case "D":
                        for (var i = 0; i < int.Parse(directions[1]); i++)
                        {
                            headMovements.Add(new() { Y = currentY - 1, X = currentX });
                            currentY--;
                        }
                        break;
                    default:
                        throw new Exception("Something bad occurred");
                }
            }

            return headMovements;
        }
    }

    public class Movement
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}
