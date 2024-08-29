using MindboxTask;

namespace MindboxTaskTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CreateNotValidTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateTriangle(0, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateTriangle(0, -1, -4));
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateTriangle(-4, -4, 5));
        }

        [TestMethod]
        public void CreateNotExistingTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateTriangle(1, 20000, 3));
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateTriangle(1, 1, 100));
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateTriangle(1000, 1, 1));
        }

        [TestMethod]
        public void CreateTriangleTypeTest()
        {
            var figure = FiguresFactory.CreateTriangle(3, 4, 6);
            Assert.IsInstanceOfType(figure, typeof(IFigure));
        }

        [TestMethod]
        public void CalculateAreaOfEqualTrianglesTest()
        {
            var firstTriangle = FiguresFactory.CreateTriangle(24, 23, 4);
            var secondTriangle = FiguresFactory.CreateTriangle(4, 23, 24);
            var thirdTriangle = FiguresFactory.CreateTriangle(24, 4, 23);

            const double actual = 45.34244700057552;

            Assert.AreEqual(actual, firstTriangle.CalculateArea());
            Assert.AreEqual(actual, secondTriangle.CalculateArea());
            Assert.AreEqual(actual, thirdTriangle.CalculateArea());
        }

        [TestMethod]
        public void CalculateAreaOfTriangleTest()
        {
            var triangle = FiguresFactory.CreateTriangle(10, 10, 4);

            Assert.AreEqual(19.595917942265423, triangle.CalculateArea());
        }

        [TestMethod]
        public void FirstCalculateAreaOfRightTriangleTest()
        {
            var triangle = FiguresFactory.CreateTriangle(3, 4, 5);

            Assert.AreEqual(6, triangle.CalculateArea());
        }

        [TestMethod]
        public void SecondCalculateAreaOfRightTriangleTest()
        {
            var triangle = FiguresFactory.CreateTriangle(43.1, 23.5, 49.0903249123);

            Assert.AreEqual(506.425, triangle.CalculateArea());
        }
    }
}