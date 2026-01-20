using System;
using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public static EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if(balance < amount)
        {
            throw new InsufficientWalletBalanceException(); 
        }
        else
        {
            EcommerceShop shop = new EcommerceShop();
            shop.UserName = name;
            shop.WalletBalance = balance;
            shop.TotalPurchasedAmount = amount;
            return shop;
        }
    }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("............Enter user details................");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter wallet balance:");
                double balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter amount to purchase:");
                double amount =  Convert.ToDouble(Console.ReadLine());

                EcommerceShop result = MakePayment(name,balance,amount);
                if(result != null)
                {
                    Console.WriteLine("Payment successful");
                }
            }
            catch(InsufficientWalletBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
}
