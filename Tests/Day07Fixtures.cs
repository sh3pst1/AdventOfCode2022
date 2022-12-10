using TheApp.Days;

namespace Tests
{
    [TestFixture]
    internal class Day07Fixtures
    {
        [Test]
        public void Day07Part1Test()
        {
            //Arrange
            var lines = new[]
            {
                @"$ cd /", @"$ ls", @"dir a", @"14848514 b.txt", @"8504156 c.dat", @"dir d", @"$ cd a", @"$ ls",
                @"dir e", @"29116 f", @"2557 g", @"62596 h.lst", @"$ cd e", @"$ ls", @"584 i", @"$ cd ..", @"$ cd ..",
                @"$ cd d", @"$ ls", @"4060174 j", @"8033020 d.log", @"5626152 d.ext", @"7214296 k"
            };

            //Act
            var result = Day07.Part1(lines);

            //Assert
            Assert.That(result == 95437);
        }

        [Test]
        public void Day07Part2Test()
        {
            //Arrange
            var lines = new[]
            {
                @"$ cd /", @"$ ls", @"dir a", @"14848514 b.txt", @"8504156 c.dat", @"dir d", @"$ cd a", @"$ ls",
                @"dir e", @"29116 f", @"2557 g", @"62596 h.lst", @"$ cd e", @"$ ls", @"584 i", @"$ cd ..", @"$ cd ..",
                @"$ cd d", @"$ ls", @"4060174 j", @"8033020 d.log", @"5626152 d.ext", @"7214296 k"
            };

            //Act
            var result = Day07.Part2(lines);

            //Assert
            Assert.That(result == 24933642);
        }
    }
}
