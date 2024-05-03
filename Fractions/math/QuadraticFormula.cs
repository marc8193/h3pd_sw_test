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

        public double GetD()
        {
            return B * B - 4 * A * C;
        }

        public double GetSqrtD()
        {
            if (GetD() < 0)
                throw new NegativeDException();

            return Math.Sqrt(GetD());
        }

        public double GetS()
        {
            return -B / (2 * A);
        }

        public double GetT()
        {
            return -GetD() / (4 * A);
        }

        public double GetX1()
        {
            if (GetD() < 0)
                throw new NegativeDException();
            return (-B + GetSqrtD()) / (2 * A);
        }

        public double GetX2()
        {
            if (GetD() < 0)
                throw new NegativeDException();
            return (-B - GetSqrtD()) / (2 * A);
        }
    }
}