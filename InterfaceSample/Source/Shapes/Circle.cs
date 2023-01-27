using Enums;
using Source;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            this.radius = radius;
        }
        
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"{Color} Circle, radius: {radius} -> area: {Area()}";
        }
    }
}