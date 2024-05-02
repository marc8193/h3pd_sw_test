namespace tests;

public class UnitTestFraction
{
    [Fact]
    public void TestConstructorInteger()
    {
        Fraction f1 = new(4, 2);
        Fraction f2 = new(2, 1);

        Assert.Equal(f2, f1);
        Assert.Equal(2, f1.GetNumerator());
        Assert.Equal(1, f1.GetDenominator());

        Assert.True(f1.IsInteger());
        Assert.True(f2.IsInteger());

        Assert.Equal(2, f1.GetInteger());
        Assert.Equal(2, f2.GetInteger());
    }

    [Fact]
    public void TestConstructorNonInteger()
    {
        Fraction f1 = new(6, 14);
        Fraction f2 = new(3, 7);

        Assert.Equal(f2, f1);
        Assert.Equal(3, f1.GetNumerator());
        Assert.Equal(7, f1.GetDenominator());
        Assert.False(f1.IsInteger());
        Assert.False(f2.IsInteger());

        Assert.Throws<NotAnIntegerException>(() => f1.GetInteger());
        Assert.Throws<NotAnIntegerException>(() => f2.GetInteger());
    }

    [Fact]
    public void TestToString()
    {
        // arrange 
        Fraction f1 = new(2, 1);
        Fraction f2 = new(3, 4);

        // act & assert
        Assert.Equal("2", f1.ToString());
        Assert.Equal("3/4", f2.ToString());
    }

    [Fact]
    public void TestEqualNull()
    {
        // arrange 
        Fraction f1 = new(2, 1);

        // act & assert
        Assert.False(f1.Equals(null));
    }


    [Fact]
    public void TestDenominatorZero()
    {
        Assert.Throws<DenominatorIsZeroException>(() => new Fraction(2, 0));
    }


    [Fact]
    public void TestAddFraction()
    {
        // arrange 
        Fraction f1 = new(2, 6);
        Fraction f2 = new(3, 4);

        // acts
        var res = f1.Add(f2);

        // assert
        Assert.Equal(new Fraction(4 + 9, 12), res);
    }

    [Fact]
    public void TestAddFraction_2()
    {
        Fraction f1 = new(2, 100);
        Fraction f2 = new(3, 100);

        var res = f1.Add(f2);

        // 2+3 = 5 
        // 5/100 = 1/20
        Assert.Equal(new Fraction(1, 20), res);
    }

    [Fact]
    public void TestMinusFraction()
    {
       // to do 
    }

    [Fact]
    public void TestMultiplyInteger()
    {
           // to do
    }




    [Fact]
    public void TestMultiplyFraction()
    {
        Fraction f1 = new(2, 6);
        Fraction f2 = new(3, 4);

        var res = f1.Multiply(f2);

        Assert.Equal(new Fraction(2 * 3, 6 * 4), res);
    }


    [Fact]
    public void TestDivideFraction()
    {
        Fraction f1 = new(2, 6);
        Fraction f2 = new(1, 2);

        var res = f1.Divide(f2);

        Assert.Equal(res, new Fraction(4, 6));
    }

    [Fact]
    public void TestGCD()
    {
        Assert.Equal(10, Fraction.GCD(20, 10));
        Assert.Equal(10, Fraction.GCD(10, 20));

        Assert.Equal(15, Fraction.GCD(30, 15));
        Assert.Equal(15, Fraction.GCD(15, 30));

        Assert.Equal(2, Fraction.GCD(2, 4));
        Assert.Equal(2, Fraction.GCD(4, 2));

        Assert.Equal(1, Fraction.GCD(17, 10));
        Assert.Equal(1, Fraction.GCD(10, 17));

        Assert.Equal(1, Fraction.GCD(7, 13));
        Assert.Equal(1, Fraction.GCD(13, 7));
    }

    [Fact]
    public void TestGetHashCode()
    {
        Fraction f1 = new(2, 6);

        _ = Assert.Throws<NotImplementedException>(() => f1.GetHashCode());
    }

}
