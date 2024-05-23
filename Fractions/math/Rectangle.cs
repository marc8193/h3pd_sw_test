namespace techmath
{
    public class Rectangle : Shape
    {
        private readonly double length;
        private readonly double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return this.length * this.width;
        }

        public override double Perimeter()
        {
            return 2 * this.length + 2 * this.width;
        }

        public override string? ToString()
        {
            return base.ToString() + "(" + this.length + "," + this.width + ")";
        }
    }
}