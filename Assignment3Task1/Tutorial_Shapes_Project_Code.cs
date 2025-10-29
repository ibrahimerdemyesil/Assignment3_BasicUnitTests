namespace Tut2_s30066
{
    public interface IShape
    {
        double CalculateArea();
        double CalculateVolume();
    }

    public class Cube(double side) : IShape
    {
        private readonly double side = side;

        public double CalculateArea() => 6 * Math.Pow(side, 2);
        public double CalculateVolume() => Math.Pow(side, 3);
    }

    public class Rectangle(double length, double width) : IShape
    {
        private readonly double length = length;
        private readonly double width = width;

        public double CalculateArea() => length * width;
        public double CalculateVolume() => 0; // 2D shape
    }

    public class Cylinder(double radius, double height) : IShape
    {
        private readonly double radius = radius;
        private readonly double height = height;

        public double CalculateArea() => 2 * Math.PI * radius * (radius + height);
        public double CalculateVolume() => Math.PI * Math.Pow(radius, 2) * height;
    }

    public class Sphere(double radius) : IShape
    {
        private readonly double radius = radius;

        public double CalculateArea() => 4 * Math.PI * Math.Pow(radius, 2);
        public double CalculateVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}