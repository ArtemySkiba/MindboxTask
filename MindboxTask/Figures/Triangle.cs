namespace MindboxTask.Figures
{
    internal sealed class Triangle : IFigure
    {
        private readonly double biggestSide;
        private readonly double firstSide;
        private readonly double secondSide;

        public Triangle(double sideA, double sideB, double sideC, double precision = 0.0000000001)
        {
            validateTriangle(sideA, sideB, sideC);

            List<double> orderedSides = new[] { sideA, sideB, sideC }.OrderByDescending(s => s).ToList();

            biggestSide = orderedSides[0];
            firstSide = orderedSides[1];
            secondSide = orderedSides[2];
        }

        public double CalculateArea()
        {
            if (isRightTriangle)
                return firstSide * secondSide / 2;

            double semiperimeter = (firstSide + secondSide + biggestSide) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - biggestSide));
        }

        private void validateTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("All sides must be more than zero");

            if (sideA + sideB >= sideC)
                if (sideB + sideC >= sideA)
                    if (sideA + sideC >= sideB)
                        return;

            throw new ArgumentException("Triangle with set sides is not exists");
        }

        private bool isRightTriangle
        {
            get
            {
                double squareOfHypotenuse = Math.Pow(biggestSide, 2);
                double sumOfSquaresOfLegs = Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2);

                return Math.Abs(squareOfHypotenuse - sumOfSquaresOfLegs) <= 0.000001;
            }
        }
    }
}
