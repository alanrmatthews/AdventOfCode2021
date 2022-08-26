namespace AdventOfCode2021Tests;
using AdventOfCode2021;

[TestClass]
public class AdventOfCode2021Tests
{
    [TestMethod]
    public void TestDay1()
    {
        Assert.AreEqual(Day1.Part1(), 1292);
        Assert.AreEqual(Day1.Part2(), 1262);
    }

    [TestMethod]
    public void TestDay2()
    {
        Assert.AreEqual(Day2.Part1(), 1383564);
        Assert.AreEqual(Day2.Part2(), 1488311643);
    }
}
