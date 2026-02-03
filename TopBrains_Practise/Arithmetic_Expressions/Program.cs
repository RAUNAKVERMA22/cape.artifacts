using System;

class Program
{
    static string Evaluate(string expression)
    {
        // 1. Invalid expression
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
            return "Error:InvalidExpression";

        string aStr = parts[0];
        string op = parts[1];
        string bStr = parts[2];

        // 2. Unknown operator
        if (op != "+" && op != "-" && op != "*" && op != "/")
            return "Error:UnknownOperator";

        // 3. Invalid number
        int a, b;
        if (!int.TryParse(aStr, out a) || !int.TryParse(bStr, out b))
            return "Error:InvalidNumber";

        // 4. Divide by zero
        if (op == "/" && b == 0)
            return "Error:DivideByZero";

        // 5. Evaluate
        int result = 0;
        switch (op)
        {
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result = a * b;
                break;
            case "/":
                result = a / b;   // integer division
                break;
        }

        return result.ToString();
    }

    static void Main()
    {
        string expression = Console.ReadLine();
        Console.WriteLine(Evaluate(expression));
    }
}
