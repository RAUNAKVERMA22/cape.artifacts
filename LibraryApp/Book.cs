using System;

public class Book
{
    public string title;
    public string author;
    public int numPages;
    public DateTime dueDate;
    public DateTime returnedDate;

    // Default Constructor
    public Book()
    {
    }

    // Parameterized Constructor
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
    }

    public double AveragePagesReadPerDay(int daysToRead)
    {
        return numPages / daysToRead;
    }

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int daysLate = (returnedDate - dueDate).Days;
        return daysLate * dailyLateFeeRate;
    }
}
