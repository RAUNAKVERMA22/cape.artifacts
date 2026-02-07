using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }

    public Customer(int id, string name, string? email = null)
    {
        CustomerId = id;
        Name = name;
        Email = email;
    }
}