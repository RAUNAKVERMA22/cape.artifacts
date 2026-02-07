using System;
using System.Collections.Generic;

public enum OrderStatus { Pending, Paid, Failed, Cancelled }

public class Order
{
    public string? InvoiceNumber { get; set; }
    public Customer? Customer { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    public double TotalAmount { get; set; }
    public string? CouponCode { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}