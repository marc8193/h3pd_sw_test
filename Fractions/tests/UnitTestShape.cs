using techmath;

namespace tests;

public class UnitTestShape
{
    [Fact]
    public void TestCircleConstructor()
    {
        Circle c1 = new(3);
        Assert.NotNull(c1);
    }

    [Fact]
    public void TestCirclePerimeter()
    {
        Circle c1 = new(3);
        // assert reuslt with 2 decimals
        Assert.Equal(18.85, c1.Perimeter(), 2);
    }

    [Fact]
    public void TestRectangleConstructor()
    {
        Rectangle r1 = new(3, 4);
        Assert.NotNull(r1);
    }
}
