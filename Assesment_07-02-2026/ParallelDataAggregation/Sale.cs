using System;

public class Sale
{
    public string Region { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public Sale(string region, string category, decimal amount, DateTime date)
    {
        Region = region;
        Category = category;
        Amount = amount;
        Date = date;
    }
}