
namespace Module_1_Review_Exercise;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What number should be used for the radius of a circle? ");
        int radiusNum;

        while (!int.TryParse(Console.ReadLine(), out radiusNum) )
        {
            Console.Write("Invalid response - please give a valid number: ");
        }
        Console.WriteLine($"Thanks! The area of the circle equals {AreaCircle(radiusNum)}.");
        Console.WriteLine("----------");
        
        Console.Write("Please provide a number for the base of a triangle: ");
        int baseNum;

        while (!int.TryParse(Console.ReadLine(), out baseNum))
        {
            Console.Write("Invalid response - please give a valid number: ");
        }
        
        Console.Write("Now provide a number for the height of a triangle: ");
        int heightNum;

        while (!int.TryParse(Console.ReadLine(), out heightNum))
        {
            Console.Write("Invalid response - please give a valid number: ");
        }
        Console.WriteLine($"Thanks! The area of the triangle equals: {AreaTriangle(baseNum, heightNum)}");
        Console.WriteLine("----------");
        
        Console.Write("Please provide a number for the length of a rectangle: ");
        int lengthNum;

        while (!int.TryParse(Console.ReadLine(), out lengthNum))
        {
            Console.Write("Invalid response - please give a valid number: ");
        }
        
        Console.Write("Now provide a number for the width of a rectangle: ");
        int widthNum;

        while (!int.TryParse(Console.ReadLine(), out widthNum))
        {
            Console.Write("Invalid response - please give a valid number: ");
        }

        Console.WriteLine($"Thanks! The area of the rectangle equals: {AreaRectangle(lengthNum, widthNum)}");
        Console.WriteLine("----------");
        
        Console.Write("What number should be used for the side of a square? ");
        int sideNum;

        while (!int.TryParse(Console.ReadLine(), out sideNum))
        {
            Console.Write("Invalid response - please give a valid number: ");
        }
        
        Console.WriteLine($"Thanks! The area of the square equals: {AreaSquare(sideNum)}");
        Console.WriteLine("----------");
    }

    public static double AreaCircle(double radius)
    {
        var circle = Math.PI * Math.Pow(radius, 2);
        return circle;
    }

    public static double AreaTriangle(double baseLength, double height)
    {
        var triangle = baseLength * height / 2;
        return triangle;
    }

    public static double AreaRectangle(double length, double width)
    {
        var rectangle = length * width;
        return rectangle;   
    }

    public static double AreaSquare(double side)
    {
        var square = Math.Pow(side, 2);
        return square;
    }
}