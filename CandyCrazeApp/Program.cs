using System;

public class Program
{
    // Method to calculate discounted price
    public Candy CalculateDiscountedPrice(Candy candy)
    {
        // Calculate total price
        double totalPrice = candy.Quantity * candy.PricePerPiece;

        // Assign discount percentage based on flavour
        if (candy.Flavour == "Strawberry")
            candy.Discount = 15;
        else if (candy.Flavour == "Lemon")
            candy.Discount = 10;
        else if (candy.Flavour == "Mint")
            candy.Discount = 5;

        // Calculate discounted price
        candy.TotalPrice = totalPrice - (totalPrice * candy.Discount / 100);

        return candy;
    }

    // Main method
    public static void Main()
    {
        Program program = new Program();
        Candy candy = new Candy();

        Console.WriteLine("Enter the flavour");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity");
        candy.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per piece");
        candy.PricePerPiece = int.Parse(Console.ReadLine());

        if (candy.ValidateCandyFlavour())
        {
            candy = program.CalculateDiscountedPrice(candy);

            Console.WriteLine("Flavour : " + candy.Flavour);
            Console.WriteLine("Quantity : " + candy.Quantity);
            Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
            Console.WriteLine("Total Price : " + (candy.Quantity * candy.PricePerPiece));
            Console.WriteLine("Discount Price : " + candy.TotalPrice);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }
}
