﻿using techmath;

namespace tests;

public class UnitTestQF
{
    QuadraticFormula qf;

    [Fact]
    public void TestMethodSimple()
    {
        var a = 2;
        var b = 6;
        var c = 4;

        qf = new QuadraticFormula(a, b, c);

        Assert.Equal(4, qf.getD());

        var x1 = qf.getX1();
        var x2 = qf.getX2();

        Assert.Equal(-1, x1);
        Assert.Equal(-2, x2);

        Assert.Equal(0, a * x1 * x1 + b * x1 + c);
    }

    [Fact]
    public void TestMethodSetInstanceIndividually()
    {
        qf = new QuadraticFormula(-1, -1, -1);

        qf.A = 2;
        qf.B = 6;
        qf.C = 4;

        Assert.Equal(4, qf.getD());
        Assert.Equal(-1, qf.getX1());
        Assert.Equal(-2, qf.getX2());
    }

    [Fact]
    public void TestMethodDZero()
    {
        qf = new QuadraticFormula(1, 2, 1);
        Assert.Equal(0, qf.getD());
        Assert.Equal(qf.getX1(), qf.getX2());
    }

    [Fact]
    public void TestMethodDNeg()
    {
        qf = new QuadraticFormula(1, 1, 1);
        Assert.Equal(-3, qf.getD());

        Assert.Throws<NegativeDException>(() => qf.getSqrtD());
        
    }

    [Fact]
    public void TestMethodAZero()
    {
        Assert.Throws<ZeroAException>(() => new QuadraticFormula(0, 1, 1));
    }

    [Fact]
    public void TestMethodSetAZero()
    {
        qf = new QuadraticFormula(2, 1, 1);
        Assert.Throws<ZeroAException>(() => qf.A = 0);
    }
}
