using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Product(int id, string name, double price, int stock)
    {
        ProductId = id;
        ProductName = name;
        Price = price;
        Stock = stock;
    }
}