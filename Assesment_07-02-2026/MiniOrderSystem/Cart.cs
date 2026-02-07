using System;
using System.Collections.Generic;
using System.Linq;

public class Cart
{
    private readonly List<OrderItem> _items = new List<OrderItem>();

    public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

    public void AddToCart(Product product, int quantity)
    {
        if (product == null) throw new ArgumentException("Product cannot be null", nameof(product));
        if (quantity <= 0) throw new ArgumentException("Quantity must be at least 1", nameof(quantity));

        var existing = _items.Find(i => i.ProductId == product.ProductId);
        if (existing != null)
        {
            existing.Quantity += quantity;
        }
        else
        {
            _items.Add(new OrderItem(product.ProductId, product.ProductName, product.Price, quantity));
        }
    }

    public double Total() => _items.Sum(i => i.Total);

    public void Clear() => _items.Clear();
}
