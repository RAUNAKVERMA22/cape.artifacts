using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		// Minimal demo: seed products, add to cart, place order with simple stock check and invoice
		var products = new Dictionary<int, Product>
		{
			{1, new Product(1, "Pen", 10.0, 100)},
			{2, new Product(2, "Notebook", 50.0, 50)},
			{3, new Product(3, "Coffee Mug", 150.0, 10)}
		};

		var customer = new Customer(101, "Alice", "alice@example.com");
		var cart = new Cart();
		cart.AddToCart(products[1], 2);
		cart.AddToCart(products[2], 1);

		Console.WriteLine($"Cart total: {cart.Total():C}");

		try
		{
			var order = PlaceOrder(customer, cart, products, couponCode: "WELCOME10");
			PrintInvoice(order);
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}

	static Order PlaceOrder(Customer customer, Cart cart, Dictionary<int, Product> products, string couponCode = null)
	{
		if (customer == null) throw new ArgumentException("Customer required");
		if (cart == null || cart.Items.Count == 0) throw new ArgumentException("Cart is empty");

		// Check stock
		foreach (var it in cart.Items)
		{
			if (!products.TryGetValue(it.ProductId, out var p)) throw new Exception($"Product {it.ProductId} not found");
			if (p.Stock < it.Quantity) throw new Exception($"Out of stock: {p.ProductName}");
		}

		// Deduct stock (atomicity not required for minimal demo)
		foreach (var it in cart.Items)
			products[it.ProductId].Stock -= it.Quantity;

		var subtotal = cart.Total();
		var total = subtotal;
		if (!string.IsNullOrWhiteSpace(couponCode) && couponCode.ToUpper() == "WELCOME10")
			total = subtotal * 0.9; // simple 10% off

		var order = new Order
		{
			InvoiceNumber = $"INV-{DateTime.UtcNow:yyyyMMddHHmmss}-{new Random().Next(1000, 9999)}",
			Customer = customer,
			Items = cart.Items.ToList(),
			TotalAmount = total,
			CouponCode = couponCode,
			Status = OrderStatus.Paid,
			CreatedAt = DateTime.UtcNow
		};

		return order;
	}

	static void PrintInvoice(Order order)
	{
		Console.WriteLine("------ INVOICE ------");
		Console.WriteLine($"Invoice: {order.InvoiceNumber}");
		Console.WriteLine($"Customer: {order.Customer.Name} ({order.Customer.CustomerId})");
		Console.WriteLine("Items:");
		foreach (var it in order.Items)
		{
			Console.WriteLine($" - {it.ProductName} x{it.Quantity} @ {it.UnitPrice:C} = {it.Total:C}");
		}
		Console.WriteLine($"Total: {order.TotalAmount:C}");
		Console.WriteLine($"Status: {order.Status}");
		Console.WriteLine("---------------------");
	}
}
