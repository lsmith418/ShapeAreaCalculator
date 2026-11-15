//Welcome to Shape Area Calculator
using System.Transactions;

Console.WriteLine("Welcome To Shape Area Calculator!");

//Press Any button to continue
Console.WriteLine("Press any button to continue...");

//Read Key
Console.ReadKey();

//Clear Console
Console.Clear();


//input char "What type of shape (R)ectangle, (T)riangel, or (C)ircle:  
//Enter the length (decimal):
//Enter the width (decimal):  
//Output: The area of this rectangle/square is (2 decimals)

Console.WriteLine("Enter 'R' for rectangle, 'S' for square, 'C' for circle, or 'T' for triangle");

//Wait for user to press a key
char shape = Console.ReadKey().KeyChar;
Console.WriteLine();

//if S,s, R, or R run square/rectangle calculation

//if t or T run triangle calculation

//if triangle
//Enter the base (decimal):  
//Enter the height (decimal):
//The area of this triangle is (2 decimals):  

switch(shape)
{
    case 's':
    case 'S':
    case 'r':
    case 'R':
        Console.WriteLine("Enter the length:   ");
        decimal length = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the width:   ");
        decimal width = decimal.Parse(Console.ReadLine()!);

//Calculate area

        decimal area = length * width;

        Console.WriteLine ($"Area is {area:F2}");
        break;

    case 't':
    case 'T':
    Console.WriteLine("Enter the baselength:  ");
   double baseLength = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter the height:  ");
    double height = double.Parse(Console.ReadLine()!);

    //Calculate Area of Triangle
   double trianglearea = 0.5 * baseLength * height;

    Console.WriteLine ($"Area is {trianglearea:F2} ");
    break;

    case 'c':
    case 'C':
    Console.WriteLine("Enter the radius:  ");
    double radius = double.Parse(Console.ReadLine()!);

    //Calculate Area of Circle
    double circlearea = Math.PI * radius * radius;

    //Print area to console
    Console.WriteLine($"Area is {circlearea:F2}");
    break;

    default:
        Console.WriteLine("Not a shape");
        break;
}
