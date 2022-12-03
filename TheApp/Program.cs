using TheApp.Days;

namespace TheApp
{
    internal class Program
    {
        private const string BasePath = @"C:\_development\AdventOfCode\AdventOfCode2022\";
        static void Main(string[] args)
        {
            Day01.Part1();
            Day01.Part2();
            Day02.Part1();
            Day02.Part2();
            Day03.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day03)}\input.txt"));
            Day03.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day03)}\input.txt"));
            Console.ReadKey();
        }
    }
}