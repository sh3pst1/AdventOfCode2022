using TheApp.Days;

namespace Tests
{
    [TestFixture]
    internal class Day05Fixtures
    {
        [Test]
        public void Day05Part1Test()
        {
            //Arrange
            var lines = new[]
            {
                @"    [D]    ", 
                @"[N] [C]    ", 
                @"[Z] [M] [P]", 
                @" 1   2   3 ", 
                @$"{Environment.NewLine}", 
                @"move 1 from 2 to 1",
                @"move 3 from 1 to 3", 
                @"move 2 from 2 to 1", 
                @"move 1 from 1 to 2"
            };

            //Act
            var result = Day05.Part1(lines);

            //Assert
            Assert.That(result == "CMZ");
        }

        [Test]
        public void Day05Part2Test()
        {
            //Arrange
            var lines = new[]
            {
                @"    [D]    ",
                @"[N] [C]    ",
                @"[Z] [M] [P]",
                @" 1   2   3 ",
                @$"{Environment.NewLine}",
                @"move 1 from 2 to 1",
                @"move 3 from 1 to 3",
                @"move 2 from 2 to 1",
                @"move 1 from 1 to 2"
            };

            //Act
            var result = Day05.Part2(lines);

            //Assert
            Assert.That(result == "MCD");
        }
    }
}
