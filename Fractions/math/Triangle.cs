namespace techmath
{
    public class RightTriangle(double a, double b, double c) : Shape
    {
        private readonly double a = a;
        private readonly double b = b;
        private readonly double c = c;

        public override double Area()
        {
            return a * b / 2;
        }

        public override double Perimeter()
        {
            return a + b + c;
        }
        public override string? ToString()
        {
            return base.ToString() + $"({this.a}, {this.b}, {this.c})";
        }

    }
}
