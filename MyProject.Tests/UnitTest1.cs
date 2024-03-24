namespace MyProject.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1(
        [Values(typeof(float), typeof(double))] Type numericType,
        [Values("∞", "-∞")] string infinity)
    {
        Convert.ChangeType(infinity, numericType);
    }
}