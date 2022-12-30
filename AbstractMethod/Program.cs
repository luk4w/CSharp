using AbstractMethod.Entities;
using AbstractMethod.Entities.Enums;

namespace AbstractMethod
{
    internal class Program
    {
        public static Color RequestColor()
        {
            Console.Write("Color (Black/BLue/Red): ");
            return Enum.Parse<Color>(Console.ReadLine());
        }

        private static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char choise = char.Parse(Console.ReadLine());
                Color color;
                
                switch (choise)
                {
                    case 'r':
                        color = RequestColor();
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine());
                        shapes.Add(new Rectangle(width, height, color));
                        break;
                    case 'c':
                        color = RequestColor();
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        shapes.Add(new Circle(radius, color));
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        i--;
                        break;
                }  
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

            Console.ReadKey();
        }
    }
}