using Tut2_s30066;
using NUnit.Framework;

namespace Tut2_s30066_Tests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);

        [Test]
        public void TestSphereCalculateArea() =>
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));

        [Test]
        public void TestSphereCalculateVolume() =>
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));

        [Test]
        public void TestCubeCalculateArea()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            IShape rectangle = new Rectangle(4, 8);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            IShape rectangle = new Rectangle(4, 8);
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }
    }
}