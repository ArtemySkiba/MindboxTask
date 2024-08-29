namespace MindboxTask.Figures
{
    internal sealed class Circle : IFigure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");

            this.radius = radius;
        }

        public double CalculateArea() => Math.PI * Math.Pow(radius, 2);
    }
}
