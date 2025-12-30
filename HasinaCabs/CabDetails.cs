using System;

public class CabDetails : Cab
{
    public bool ValidateBookingID()
    {
        if (BookingID.Length != 6)
            return false;

        if (!BookingID.StartsWith("AC@"))
            return false;

        string digits = BookingID.Substring(3);

        return int.TryParse(digits, out _) && digits.Length == 3;
    }

    public double CalculateFareAmount()
    {
        double pricePerKm = 0;

        if (CabType == "Hatchback")
            pricePerKm = 10;
        else if (CabType == "Sedan")
            pricePerKm = 20;
        else if (CabType == "SUV")
            pricePerKm = 30;

        double waitingCharge = Math.Sqrt(WaitingTime);
        double fare = (Distance * pricePerKm) + waitingCharge;

        return Math.Floor(fare * 100) / 100;
    }
}
