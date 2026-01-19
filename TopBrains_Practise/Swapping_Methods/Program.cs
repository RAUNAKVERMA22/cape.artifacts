using System;

class Program
{
    
    // Swap using ref keyword
    static void SwapUsingRef(ref int firstNumber, ref int secondNumber)
    {
        int temporaryValue = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temporaryValue;
    }

    // Swap using out keyword
    static void SwapUsingOut(int firstNumber, int secondNumber, out int swappedFirst, out int swappedSecond)
    {
        swappedFirst = secondNumber;
        swappedSecond = firstNumber;
    }
    static void Main(string[] args)
    {
        int firstNumber = 10;
        int secondNumber = 20;

        Console.WriteLine("Before Swap using ref:");
        Console.WriteLine($"FirstNumber = {firstNumber}, SecondNumber = {secondNumber}");

        SwapUsingRef(ref firstNumber, ref secondNumber);

        Console.WriteLine("After Swap using ref:");
        Console.WriteLine($"FirstNumber = {firstNumber}, SecondNumber = {secondNumber}");


        int numberOne = 30;
        int numberTwo = 40;

        Console.WriteLine("Before Swap using out:");
        Console.WriteLine($"NumberOne = {numberOne}, NumberTwo = {numberTwo}");

        SwapUsingOut(numberOne, numberTwo, out numberOne, out numberTwo);

        Console.WriteLine("After Swap using out:");
        Console.WriteLine($"NumberOne = {numberOne}, NumberTwo = {numberTwo}");
    }

}