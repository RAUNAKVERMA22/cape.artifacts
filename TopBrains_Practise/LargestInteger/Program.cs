using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num3: ");
        int num3 = int.Parse(Console.ReadLine());
        if(num1>num2 && num1 > num3)
        {
            Console.WriteLine("The largest integer is: ");
            Console.WriteLine(num1);
        }
        else if(num2>num1 && num2 > num3)
        {
            Console.WriteLine("The largest integer is: ");
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine("The largest integer is: ");
            Console.WriteLine(num3);
        }
    }
}