namespace tests;

public class UnitTestQF
{
    [Fact]
    public void TestDefaultConstructor()
    {
        QuadraticFormula qf = new();

        Assert.NotNull(qf);
    }

    [Fact]
    public void TestGetST()
    {
        QuadraticFormula qf = new(2, 0, 4);

        Assert.Equal(0, qf.GetS());
        Assert.Equal(4, qf.GetT());
    }


    [Fact]
    public void TestMethodSimple()
    {
        var a = 2;
        var b = 6;
        var c = 4;

        QuadraticFormula qf = new(a, b, c);

        Assert.Equal(4, qf.GetD());

        var x1 = qf.GetX1();
        var x2 = qf.GetX2();

        Assert.Equal(-1, x1);
        Assert.Equal(-2, x2);

        Assert.Equal(0, a * x1 * x1 + b * x1 + c);
    }

    [Fact]
    public void TestMethodSetInstanceIndividually()
    {
        QuadraticFormula qf = new(-1, -1, -1);

        qf.A = 2;
        qf.B = 6;
        qf.C = 4;

        Assert.Equal(4, qf.GetD());
        Assert.Equal(-1, qf.GetX1());
        Assert.Equal(-2, qf.GetX2());
    }

    [Fact]
    public void TestMethodDZero()
    {
        QuadraticFormula qf = new(1, 2, 1);
        Assert.Equal(0, qf.GetD());
        Assert.Equal(qf.GetX1(), qf.GetX2());
    }

    [Fact]
    public void TestMethodDNeg()
    {
        QuadraticFormula qf = new(1, 1, 1);
        Assert.Equal(-3, qf.GetD());

        Assert.Throws<NegativeDException>(() => qf.GetSqrtD());

    }

    [Fact]
    public void TestMethodAZero()
    {
        Assert.Throws<ZeroAException>(() => new QuadraticFormula(0, 1, 1));
    }

    [Fact]
    public void TestMethodSetAZero()
    {
        QuadraticFormula qf = new(2, 1, 1);
        Assert.Throws<ZeroAException>(() => qf.A = 0);
    }
}