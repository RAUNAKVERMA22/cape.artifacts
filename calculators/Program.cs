using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter operator (+ - * /): ");
        char op = Console.ReadLine()[0];

        switch (op)
        {
            case '+':
                Console.WriteLine("Result = " + (a + b));
                break;

            case '-':
                Console.WriteLine("Result = " + (a - b));
                break;

            case '*':
                Console.WriteLine("Result = " + (a * b));
                break;

            case '/':
                if (b != 0)
                    Console.WriteLine("Result = " + (a / b));
                else
                    Console.WriteLine("Division by zero not allowed");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
