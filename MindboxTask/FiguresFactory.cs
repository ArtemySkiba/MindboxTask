using MindboxTask.Figures;

namespace MindboxTask
{
    public static class FiguresFactory
    {
        public static IFigure CreateCircle(double radius) => new Circle(radius);

        public static IFigure CreateTriangle(double sideA, double sideB, double sideC) => new Triangle(sideA, sideB, sideC);
    }
}
