using System;

namespace MediSureClinicApp
{
    class Program
    {
        static void Main()
        {
            BillingService.Run();
        }
    }

    public static class BillingService
    {
        private static PatientBill? LastBill;

        public static void Run()
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Enter your option: ");
                string? opt = Console.ReadLine()?.Trim();
                Console.WriteLine();

                switch (opt)
                {
                    case "1":
                        CreateNewBill();
                        break;
                    case "2":
                        ViewLastBill();
                        break;
                    case "3":
                        ClearLastBill();
                        break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1, 2, 3 or 4.");
                        break;
                }

                Console.WriteLine("------------------------------------------------------------\n");
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
        }

        public static void CreateNewBill()
        {
            string id;
            do
            {
                Console.Write("Enter Bill Id: ");
                id = Console.ReadLine()?.Trim() ?? "";
            } while (id == "");

            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(name)) name = "Unknown";

            bool insurance = ReadYesNo("Is the patient insured? (Y/N): ");

            decimal consult = ReadDecimal("Enter Consultation Fee: ", true);
            decimal lab = ReadDecimal("Enter Lab Charges: ");
            decimal meds = ReadDecimal("Enter Medicine Charges: ");

            LastBill = new PatientBill
            {
                BillId = id,
                PatientName = name,
                HasInsurance = insurance,
                ConsultationFee = consult,
                LabCharges = lab,
                MedicineCharges = meds
            };

            LastBill.Calculate();

            Console.WriteLine("\nBill created successfully.");
            PrintBill(LastBill);
        }

        static decimal ReadDecimal(string prompt, bool mustBePositive = false)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal val) &&
                    (!mustBePositive || val > 0))
                    return val;

                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }

        static bool ReadYesNo(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? ans = Console.ReadLine()?.Trim().ToUpper();
                if (ans == "Y") return true;
                if (ans == "N") return false;
                Console.WriteLine("Please enter Y or N.");
            }
        }

        public static void ViewLastBill()
        {
            if (LastBill == null)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            Console.WriteLine("----------- Last Bill -----------");
            PrintBill(LastBill);
            Console.WriteLine("--------------------------------");
        }

        static void PrintBill(PatientBill b)
        {
            Console.WriteLine("BillId: " + b.BillId);
            Console.WriteLine("Patient: " + b.PatientName);
            Console.WriteLine("Insured: " + (b.HasInsurance ? "Yes" : "No"));
            Console.WriteLine("Consultation Fee: " + b.ConsultationFee.ToString("0.00"));
            Console.WriteLine("Lab Charges: " + b.LabCharges.ToString("0.00"));
            Console.WriteLine("Medicine Charges: " + b.MedicineCharges.ToString("0.00"));
            Console.WriteLine("Gross Amount: " + b.GrossAmount.ToString("0.00"));
            Console.WriteLine("Discount Amount: " + b.DiscountAmount.ToString("0.00"));
            Console.WriteLine("Final Payable: " + b.FinalPayable.ToString("0.00"));
        }

        public static void ClearLastBill()
        {
            LastBill = null;
            Console.WriteLine("Last bill cleared.");
        }
    }
}
