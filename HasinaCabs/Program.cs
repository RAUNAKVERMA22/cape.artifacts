/*
Hasina Cabs is one of the fastest-growing startups in the county. The Internet and consumer space have sparked a new market opportunity and added a touch of modern technology to the whole setup. They offer a variety of vehicles, such as hatchbacks, sedans, and SUVs. They require software to calculate the fare based on the type of vehicles.
As their software consultant, you can help her by developing a C# application
Functionalities:
In class Cab, implement the below-given properties.
    Datatype
 Property Name
     string
  string
  double
  int
   BookingID
  CabType
  Distance
  WaitingTime
In class CabDetails, implement the below-given methods and also Inherit class Cab.
  Method
 Description
   public bool ValidateBookingID()
 This method is used to validate the booking id.
Conditions :
1. Booking id Length should be 6.
2. The id should have AC before the character @
3. There should be 3 digits after the character @.
For Example : AC@123
The above conditions are passed then return true, Otherwise return false.
   public double CalculateFareAmount()
 This method is used to calculate the fare of the cab bookings based on the cab type and return the fare amount with two decimal places.
 Refer the below given procedures to calculate fare.
 Hint : Use Math.Floor
Formula :
Fare = Distance * Price per km + Waiting Charge
Waiting Charge = Square root of Waiting Time
    Cab Type
   Price per km
     Hatchback
   10
     Sedan
   20
     SUV
   30
  Note : Cab type is case sensitive.
In Program class - Main method,
1.  Get the BookingID from the user.
2.  Call the ValidateBookingID method and if it returns true, then get the CabType, Distance and WaitingTime from the user, and move on to step 3. If it returns false, then display Invalid booking id
3.  Use the values in method CalculateFareAmount and display the result as per the Sample Output.
Note:
Keep the properties, methods and classes as public.
Please read the method rules clearly.
Do not use Environment.Exit() to terminate the program.
Do not change the given code template.
Sample Input 1:
 Enter the booking id
AC@234
Enter the cab type
SUV
Enter the distance in km
30
Enter the waiting time in minutes
15
Sample Output 1:
The fare amount is 903.87
Sample Input 2:
Enter the booking id
DC@123
Sample Output 2:
Invalid booking id
Sample Input 3:
Enter the booking id
AC@123456
Sample Output 3:
Invalid booking id
*/


using System;

public class Program
{
    public static void Main()
    {
        CabDetails cab = new CabDetails();

        Console.WriteLine("Enter the booking id");
        cab.BookingID = Console.ReadLine();

        if (cab.ValidateBookingID())
        {
            Console.WriteLine("Enter the cab type");
            cab.CabType = Console.ReadLine();

            Console.WriteLine("Enter the distance in km");
            cab.Distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the waiting time in minutes");
            cab.WaitingTime = int.Parse(Console.ReadLine());

            Console.WriteLine("The fare amount is ₹ " + cab.CalculateFareAmount());
        }
        else
        {
            Console.WriteLine("Invalid booking id");
        }
    }
}
