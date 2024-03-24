using System.Globalization;

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
        [ValueSource(nameof(Infinities))] string infinity)
    {
        Convert.ChangeType(infinity, numericType);
    }

    private static readonly string[] Infinities =
    {
        CultureInfo.CurrentCulture.NumberFormat.PositiveInfinitySymbol,
        CultureInfo.CurrentCulture.NumberFormat.NegativeInfinitySymbol,
        "∞",
        "-∞",
}