using MindboxTask;

namespace MindboxTaskTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CreateNotValidCircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateCircle(0));
            Assert.ThrowsException<ArgumentException>(() => FiguresFactory.CreateCircle(-1));
        }

        [TestMethod]
        public void CreateCircleTest()
        {
            var validFigure = FiguresFactory.CreateCircle(1);
            Assert.IsInstanceOfType(validFigure, typeof(IFigure));
        }

        [TestMethod]
        public void FirstCalculateAreaOfCircleTest()
        {
            var circle = FiguresFactory.CreateCircle(1);

            Assert.AreEqual(Math.PI, circle.CalculateArea());
        }

        [TestMethod]
        public void SecondCalculateAreaOfCircleTest()
        {
            var circle = FiguresFactory.CreateCircle(1.596);

            Assert.AreEqual(8.00231507, circle.CalculateArea(),
                            0.00000001);
        }

        [TestMethod]
        public void ThirdCalculateAreaOfCircleTest()
        {
            var circle = FiguresFactory.CreateCircle(12.5);

            Assert.AreEqual(490.873852109375, circle.CalculateArea(),
                              0.0000001);
        }
    }
}