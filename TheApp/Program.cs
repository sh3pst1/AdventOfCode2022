using TheApp.Days;

namespace TheApp
{
    internal class Program
    {
        private const string BasePath = @"C:\_development\AdventOfCode\AdventOfCode2022\";
        static void Main(string[] args)
        {
            //Day01.Part1();
            //Day01.Part2();
            //Day02.Part1();
            //Day02.Part2();
            //Day03.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day03)}\input.txt"));
            //Day03.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day03)}\input.txt"));
            //Day04.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day04)}\input.txt"));
            //Day04.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day04)}\input.txt"));
            //Day05.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day05)}\input.txt"));
            //Day05.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day05)}\input.txt"));
            //Day06.Part1(File.ReadAllText(@$"{BasePath}{nameof(Day06)}\input.txt"));
            //Day06.Part2(File.ReadAllText(@$"{BasePath}{nameof(Day06)}\input.txt"));
            //Day07.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day07)}\input.txt"));
            //Day07.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day07)}\input.txt"));
            //Day08.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day08)}\input.txt"));
            //Day08.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day08)}\input.txt"));
            Day09.Part1(File.ReadAllLines(@$"{BasePath}{nameof(Day09)}\input.txt"));
            Day09.Part2(File.ReadAllLines(@$"{BasePath}{nameof(Day09)}\input.txt"));
            Console.ReadKey();
        }
    }
}