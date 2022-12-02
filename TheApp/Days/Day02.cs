namespace TheApp.Days
{
    internal static class Day02
    {
        private const string Path = @"C:\_development\AdventOfCode\AdventOfCode2022\Day02\input.txt";

        public static void Part1()
        {
            var lines = File.ReadAllLines(Path);
            var value = 0;
            foreach (var line in lines)
            {
                var hands = line.Split(" ");
                var game = new Game(new Hand(hands[1]), new Hand(hands[0]));

                value += game.HeroScore;
            }

            Console.WriteLine($"{nameof(Day02)}{nameof(Part1)} Result: {value}");
        }

        public static void Part2()
        {
            var lines = File.ReadAllLines(Path);
            var value = 0;
            foreach (var line in lines)
            {
                var hands = line.Split(" ");
                var fooHand = new Hand(hands[0]);
                var heroHand = GetHeroHand(fooHand, hands[1]);
                var game = new Game(heroHand, fooHand);

                value += game.HeroScore;
            }

            Console.WriteLine($"{nameof(Day02)}{nameof(Part2)} Result: {value}");
        }

        private static Hand GetHeroHand(Hand fooHand, string needsToEnd)
        {
            switch (needsToEnd.ToUpper())
            {
                case "X":
                    return fooHand.Shape switch
                    {
                        Shape.Rock => new Hand("C"),
                        Shape.Paper => new Hand("A"),
                        Shape.Scissors => new Hand("B"),
                        _ => throw new NotImplementedException("X - boohoo")
                    };

                case "Y":
                    return fooHand;

                case "Z":
                    return fooHand.Shape switch
                    {
                        Shape.Rock => new Hand("B"),
                        Shape.Paper => new Hand("C"),
                        Shape.Scissors => new Hand("A"),
                        _ => throw new NotImplementedException("Z - boohoo")
                    };

                default:
                    throw new NotImplementedException("just bad, default bad...");
            }
        }
    }

    public class Game
    {
        public int HeroScore { get; }
        public Game(Hand heroHand, Hand fooHand)
        {
            HeroScore = (int)heroHand.Shape;

            if (heroHand.Shape == fooHand.Shape)
            {
                HeroScore += 3;
                return;
            }

            if ((heroHand.Shape == Shape.Rock && fooHand.Shape == Shape.Scissors) ||
                (heroHand.Shape == Shape.Paper && fooHand.Shape == Shape.Rock) ||
                (heroHand.Shape == Shape.Scissors && fooHand.Shape == Shape.Paper))
            {
                HeroScore += 6;
            }
        }
    }

    public class Hand
    {
        public Shape Shape { get; }
        public Hand(string shape)
        {
            switch (shape.ToUpper())
            {
                case "A":
                case "X":
                    Shape = Shape.Rock;
                    break;
                case "B":
                case "Y":
                    Shape = Shape.Paper;
                    break;
                case "C":
                case "Z":
                    Shape = Shape.Scissors;
                    break;
                default:
                    throw new NotImplementedException($"{shape} - boohoo");
            }
        }
    }

    public enum Shape
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }
}
