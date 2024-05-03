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
    public void TestCircleArea()
    {
        Circle c1 = new(1);

        Assert.Equal(Math.PI, c1.Area());
    }

    [Fact]
    public void TestCirclePerimeter()
    {
        Circle c1 = new(3);
        // assert reuslt with 2 decimals
        Assert.Equal(18.85, c1.Perimeter(), 2);
    }

    [Fact]
    public void TestCircleToString()
    {
        Circle c1 = new(4);

        Assert.Equal("techmath.Circle(4)", c1.ToString());
    }

    [Fact]
    public void TestRectangleConstructor()
    {
        Rectangle r1 = new(3, 4);
        Assert.NotNull(r1);
    }

    [Fact]
    public void TestRectangleArea()
    {
        Rectangle r1 = new(3, 4);

        Assert.Equal(3 * 4, r1.Area());
    }

    [Fact]
    public void TestRectanglePerimeter()
    {
        Rectangle r1 = new(3, 4);

        Assert.Equal(2 * 3 + 2 * 4, r1.Perimeter());
    }

    [Fact]
    public void TestRectangleToString()
    {
        Rectangle r1 = new(3, 4);

        Assert.Equal("techmath.Rectangle(3,4)", r1.ToString());
    }


}
