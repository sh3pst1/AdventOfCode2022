using TheApp.Days;

namespace Tests;

[TestFixture]
internal class Day09Fixtures
{
    [Test]
    public void Day09Part1Test()
    {
        //Arrange
        var lines = new[]
        {
            "R 4",
            "U 4",
            "L 3",
            "D 1",
            "R 4",
            "D 1",
            "L 5",
            "R 2"
        };

        //Act
        var result = Day09.Part1(lines);

        //Assert
        Assert.That(result == 13);
    }

    [Test]
    public void Day09Part2Test1()
    {
        //Arrange
        var lines = new[]
        {
            "R 4",
            "U 4",
            "L 3",
            "D 1",
            "R 4",
            "D 1",
            "L 5",
            "R 2"
        };

        //Act
        var result = Day09.Part2(lines);

        //Assert
        Assert.That(result == 1);
    }

    [Test]
    public void Day09Part2Test2()
    {
        //Arrange
        var lines = new[]
        {
            "R 5",
            "U 8",
            "L 8",
            "D 3",
            "R 17",
            "D 10",
            "L 25",
            "U 20"
        };

        //Act
        var result = Day09.Part2(lines);

        //Assert
        Assert.That(result == 36);
    }
}