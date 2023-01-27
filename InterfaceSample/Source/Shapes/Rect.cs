using Enums;
using Source;
namespace Shapes
{
    public class Rect : Shape
    {
        private double width { get; set; }
        private double height { get; set; }

        public Rect(double width, double height, Color color) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return $"{Color} Rect, witdh: {width}, height: {height} -> area: {Area()}";
        }
    }
}