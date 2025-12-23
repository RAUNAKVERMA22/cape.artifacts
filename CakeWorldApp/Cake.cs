using System;

public class Cake
{
    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg { get; set; }
    public double Discount { get; set; }

    public bool CakeOrder()
    {
        if (Flavour != "Chocolate" && Flavour != "Red Velvet" && Flavour != "Vanilla")
        {
            throw new InvalidFlavourException(
                "Flavour not available. Please select the available flavor"
            );
        }

        if (QuantityInKg <= 0)
        {
            throw new Exception("Quantity must be greater than zero");
        }

        // Assign discount based on flavour
        if (Flavour == "Vanilla")
            Discount = 3;
        else if (Flavour == "Chocolate")
            Discount = 5;
        else if (Flavour == "Red Velvet")
            Discount = 10;

        return true;
    }

    public double GetDiscountAmount()
    {
        double totalPrice = QuantityInKg * PricePerKg;
        return totalPrice * Discount / 100;
    }

    public double CalculatePrice()
    {
        double totalPrice = QuantityInKg * PricePerKg;
        return totalPrice - GetDiscountAmount();
    }
}
