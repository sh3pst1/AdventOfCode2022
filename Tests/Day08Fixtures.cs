using TheApp.Days;

namespace Tests
{
    [TestFixture]
    internal class Day08Fixtures
    {
        [Test]
        public void Day08Part1Test()
        {
            //Arrange
            var lines = new[]
            {
                "30373",
                "25512",
                "65332",
                "33549",
                "35390"
            };

            //Act
            var result = Day08.Part1(lines);

            //Assert
            Assert.That(result == 21);
        }

        [Test]
        public void Day08Part2Test()
        {
            //Arrange
            var lines = new[]
            {
                "30373",
                "25512",
                "65332",
                "33549",
                "35390"
            };

            //Act
            var result = Day08.Part2(lines);

            //Assert
            Assert.That(result == 8);
        }
    }
}
