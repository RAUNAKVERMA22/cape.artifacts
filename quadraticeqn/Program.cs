using System;

class Quadratic
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d > 0)
            Console.WriteLine("Two real roots");
        else if (d == 0)
            Console.WriteLine("One real root");
        else
            Console.WriteLine("No real roots");
    }
}

