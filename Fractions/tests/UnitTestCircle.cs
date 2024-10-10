namespace tests;
using System;
using System.IO;
using techmath;

public class CircleUnitTest
{
    readonly double radius;

    readonly techmath.Circle circle;

    public CircleUnitTest()
    {
        radius = 10;

        circle = new techmath.Circle(radius);
    }

    [Fact]
    public void TestCircleArea()
    {
        Assert.Equal(circle.Area(), radius * radius * Math.PI);
    }

    [Fact]
    public void TestCirclePerimeter()
    {
        Assert.Equal(circle.Perimeter(), 2 * radius * Math.PI);
    }

    [Fact]
    public void TestCircleToString()
    {
        Assert.Equal(circle.ToString(), "techmath.Circle" + "(" + radius + ")");
    }
}