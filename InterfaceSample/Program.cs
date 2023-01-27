using Enums;
using Shapes;
using Models;
internal class Program
{
    private static void Main(string[] args)
    {
        IShape shape1 = new Circle(10, Color.Black);
        IShape shape2 = new Rect(10, 10, Color.Black);

        Console.WriteLine(shape1);
        Console.WriteLine(shape2);

        Console.ReadKey();
    }
}