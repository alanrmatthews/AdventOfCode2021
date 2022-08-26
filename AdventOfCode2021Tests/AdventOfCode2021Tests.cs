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
}
