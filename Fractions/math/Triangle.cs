namespace techmath
{

    // maybe we should add other triangles later
    public abstract class Triangle : Shape
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    };


    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double c) : base(a, b, c)
        {

        }

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