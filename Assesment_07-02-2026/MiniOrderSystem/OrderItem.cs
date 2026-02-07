using System;

public class OrderItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double UnitPrice { get; set; }
    public int Quantity { get; set; }

    public double Total => UnitPrice * Quantity;

    public OrderItem(int productId, string name, double unitPrice, int quantity)
    {
        ProductId = productId;
        ProductName = name;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }
}
