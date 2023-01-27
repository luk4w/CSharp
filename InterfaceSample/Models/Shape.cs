using Enums;

namespace Models
{
    public abstract class Shape : IShape
    {
        public Color Color { get; set; }

        public Shape(Color color) => Color = color;
        public abstract double Area();
    }
}