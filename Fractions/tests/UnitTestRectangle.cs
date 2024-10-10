namespace tests;
using System;
using System.IO;
using techmath;

public class RectangleUnitTest
{
    readonly double length;
    readonly double width;

    readonly techmath.Rectangle rectangle;

    public RectangleUnitTest()
    {
        length = 5;
        width = 10;

        rectangle = new techmath.Rectangle(length, width);
    }

    [Fact]
    public void TestRectangleArea()
    {
        Assert.Equal(rectangle.Area(), length * width);
    }

    [Fact]
    public void TestRectanglePerimeter()
    {
        Assert.Equal(rectangle.Perimeter(), 2 * length + 2 * width);
    }

    [Fact]
    public void TestRectangleToString()
    {
        Assert.Equal(rectangle.ToString(), "techmath.Rectangle" + "(" + length + "," + width + ")");
    }
}