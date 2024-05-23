namespace techmath
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return this.radius * this.radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * this.radius * Math.PI;
        }

        public override string? ToString()
        {
            return base.ToString() + "(" + this.radius + ")";
        }
    }
}