// The core part of the system.
// Contains:
//      - few custom exception classes
//      - the main class QuadraticFormula

using System;

namespace techmath
{
    [Serializable]
    public class NegativeDException : Exception
    {
        public NegativeDException() : base("D is negative") { }
    }

    [Serializable]
    public class ZeroAException : Exception
    {
        public ZeroAException() : base("A is zero") { }
    }

    public class QuadraticFormula
    {
        private int a;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value == 0)
                    throw new ZeroAException();
                else
                    a = value;
            }
        }

        public int B { get; set; }
        public int C { get; set; }

        public QuadraticFormula()
        {
            A = 1;
            B = 1;
            C = 1;
        }

        public QuadraticFormula(int _a, int _b, int _c)
        {
            A = _a;
            B = _b;
            C = _c;
        }

        public double getD()
        {
            return B * B - 4 * A * C;
        }

        public double getSqrtD()
        {
           if (getD() < 0)
                throw new NegativeDException();

            return Math.Sqrt(getD());
        }

        public double getS()
        {
            return -B / (2 * A);
        }

        public double getT()
        {
            return -getD() / (4 * A);
        }

        public double getX1()
        {
            if (getD() < 0)
                throw new NegativeDException();
            return (-B + getSqrtD()) / (2 * A);
        }

        public double getX2()
        {
            if (getD() < 0)
                throw new NegativeDException();
            return (-B - getSqrtD()) / (2 * A);
        }
    }
}