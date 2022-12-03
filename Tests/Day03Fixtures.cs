using TheApp.Days;

namespace Tests
{
    [TestFixture]
    internal static class Day03Fixtures
    {
        [Test]
        public static void Day03Part1Test()
        {
            //Arrange
            var input = new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };

            //Act
            var result = Day03.Part1(input);

            //Assert
            Assert.That(result == 157);
        }

        [Test]
        public static void Day03Part2Test()
        {
            //Arrange
            var input = new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };

            //Act
            var result = Day03.Part2(input);

            //Assert
            Assert.That(result == 70);
        }
    }
}