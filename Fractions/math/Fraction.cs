namespace techmath;

public class NotAnIntegerException : Exception { }
public class DenominatorIsZeroException : Exception { }

public class Fraction
{
    private readonly int numerator;
    private readonly int denominator;

    public Fraction(int a, int b)
    {
        var common = GCD(a, b);

        this.numerator = a / common;
        this.denominator = b / common;

        if (this.denominator == 0)
            throw new DenominatorIsZeroException();

        if (this.denominator < 0)
        {
            this.numerator = -this.numerator;
            this.denominator = -this.denominator;
        }
    }

    public int GetDenominator()
    {
        return this.denominator;
    }

    public int GetNumerator()
    {
        return this.numerator;
    }

    public override string ToString()
    {
        if (this.denominator == 1)
            return this.numerator + "";
        else
            return this.numerator + "/" + this.denominator;
    }

    public bool IsInteger()
    {
        return (this.denominator == 1);
    }

    public int GetInteger()
    {
        if (IsInteger())
            return this.numerator;
        else
            throw new NotAnIntegerException();
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        Fraction? other = (Fraction)obj;

        return this.denominator == other.GetDenominator()
                    && this.numerator == other.GetNumerator();
    }


    public Fraction Add(Fraction f)
    {
        int newnum = this.numerator * f.denominator + this.denominator * f.numerator;
        int newden = this.denominator * f.denominator;

        return new Fraction(newnum, newden);
        //  return new Fraction(3, 42);
    }

    public Fraction Minus(Fraction f)
    {
        return this.Add(new Fraction(-f.GetNumerator(), f.GetDenominator()));
    }


    public Fraction Multiply(int f)
    {
        return new Fraction(f * this.numerator, this.denominator);
    }

    public Fraction Multiply(Fraction f)
    {
        return new Fraction(
            f.GetNumerator() * this.numerator,
            f.GetDenominator() * this.denominator
        );
    }

    public Fraction Divide(Fraction f)
    {
        return new Fraction(
            f.GetDenominator() * this.numerator,
            f.GetNumerator() * this.denominator
        );
    }

    public static int GCD(int m, int n)
    {
        if (m < 0)
            return -GCD(-m, n);

        if (n > m)
            return GCD(n, m);
        if (n == 0)
            return m;
        else
            return GCD(n, m % n);
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}