using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the title");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the author");
        string author = Console.ReadLine();

        Console.WriteLine("Enter the number of pages");
        int pages = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the due date");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter the return date");
        DateTime returnDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter the days to read");
        int daysToRead = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the daily late feeRate");
        double lateFeeRate = double.Parse(Console.ReadLine());

        Book book = new Book(title, author, pages, dueDate, returnDate);

        Console.WriteLine("Average Pages Read Per Day : " + book.AveragePagesReadPerDay(daysToRead));
        Console.WriteLine("Late Fee : " + book.CalculateLateFee(lateFeeRate));
    }
}
