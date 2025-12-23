using System;

public class Program
{
    public static void Main()
    {
        Cake cake = new Cake();

        try
        {
            Console.WriteLine("Enter the flavour");
            cake.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity in kg");
            cake.QuantityInKg = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per kg");
            cake.PricePerKg = double.Parse(Console.ReadLine());

            if (cake.CakeOrder())
            {
                Console.WriteLine("Cake order was successful");
                Console.WriteLine("Price after discount is " + cake.CalculatePrice());
            }
        }
        catch (InvalidFlavourException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

