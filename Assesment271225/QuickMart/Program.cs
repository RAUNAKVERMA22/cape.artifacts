using System;

namespace QuickMartApp
{
    class Program
    {
        static void Main()
        {
            QuickMartService.Run();
        }
    }

    public static class QuickMartService
    {
        static SaleTransaction? LastTransaction;
        static bool HasLastTransaction;

        public static void Run()
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Enter your option: ");
                string opt = Console.ReadLine()?.Trim() ?? "";
                Console.WriteLine();

                switch (opt)
                {
                    case "1": CreateNewTransaction(); break;
                    case "2": ViewLastTransaction(); break;
                    case "3": RecalculateProfitLoss(); break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1, 2, 3 or 4.");
                        break;
                }

                Console.WriteLine("------------------------------------------------------\n");
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
        }

        public static void CreateNewTransaction()
        {
            string invoice;
            do
            {
                Console.Write("Enter Invoice No: ");
                invoice = Console.ReadLine()?.Trim() ?? "";
            } while (invoice == "");

            Console.Write("Enter Customer Name: ");
            string customer = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(customer)) customer = "Unknown";

            Console.Write("Enter Item Name: ");
            string item = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(item)) item = "Item";

            int qty = ReadInt("Enter Quantity: ", true);
            decimal purchase = ReadDecimal("Enter Purchase Amount (total): ", true);
            decimal selling = ReadDecimal("Enter Selling Amount (total): ", false);

            LastTransaction = new SaleTransaction
            {
                InvoiceNo = invoice,
                CustomerName = customer,
                ItemName = item,
                Quantity = qty,
                PurchaseAmount = purchase,
                SellingAmount = selling
            };

            LastTransaction.Calculate();
            HasLastTransaction = true;

            Console.WriteLine("\nTransaction saved successfully.");
            PrintResult(LastTransaction);
        }

        public static void ViewLastTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            var t = LastTransaction!;
            Console.WriteLine("-------------- Last Transaction --------------");
            Console.WriteLine($"InvoiceNo: {t.InvoiceNo}");
            Console.WriteLine($"Customer: {t.CustomerName}");
            Console.WriteLine($"Item: {t.ItemName}");
            Console.WriteLine($"Quantity: {t.Quantity}");
            Console.WriteLine($"Purchase Amount: {t.PurchaseAmount:0.00}");
            Console.WriteLine($"Selling Amount: {t.SellingAmount:0.00}");
            PrintResult(t);
            Console.WriteLine("--------------------------------------------");
        }

        public static void RecalculateProfitLoss()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            LastTransaction!.Calculate();
            Console.WriteLine("Recomputed values:");
            PrintResult(LastTransaction);
        }

        static void PrintResult(SaleTransaction t)
        {
            Console.WriteLine($"Status: {t.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {t.ProfitOrLossAmount:0.00}");
            Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent:0.00}");
        }

        static int ReadInt(string prompt, bool mustBePositive)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int v) && (!mustBePositive || v > 0))
                    return v;

                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }

        static decimal ReadDecimal(string prompt, bool mustBePositive)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal v) && (!mustBePositive || v > 0))
                    return v;

                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }
    }
}
