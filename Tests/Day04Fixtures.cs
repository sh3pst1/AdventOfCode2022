using TheApp.Days;

namespace Tests
{
    [TestFixture]
    internal class Day04Fixtures
    {
        [Test]
        public void Day04Part1Test()
        {
            //Arrange
            var input = new[] { "2-4,6-8", "2-3,4-5", "5-7,7-9", "2-8,3-7", "6-6,4-6", "2-6,4-8" };

            //Act
            var result = Day04.Part1(input);

            //Assert
            Assert.That(result == 2);
        }

        [Test]
        public void Day04Part2Test()
        {
            //Arrange
            var input = new[] { "2-4,6-8", "2-3,4-5", "5-7,7-9", "2-8,3-7", "6-6,4-6", "2-6,4-8" };

            //Act
            var result = Day04.Part2(input);

            //Assert
            Assert.That(result == 4);
        }
    }
}
