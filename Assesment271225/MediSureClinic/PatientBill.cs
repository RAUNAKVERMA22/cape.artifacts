namespace MediSureClinicApp
{
    // Simple entity class for patient bill
    public class PatientBill
    {
        public string BillId { get; set; } = "";
        public string PatientName { get; set; } = "";
        public bool HasInsurance { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal LabCharges { get; set; }
        public decimal MedicineCharges { get; set; }

        // Calculated values
        public decimal GrossAmount { get; private set; }
        public decimal DiscountAmount { get; private set; }
        public decimal FinalPayable { get; private set; }

        // Compute amounts according to rules
        public void Calculate()
        {
            GrossAmount = ConsultationFee + LabCharges + MedicineCharges;
            if (HasInsurance)
            {
                DiscountAmount = GrossAmount * 0.10m;
            }
            else
            {
                DiscountAmount = 0m;
            }
            FinalPayable = GrossAmount - DiscountAmount;

            // Round to 2 decimals for display correctness
            GrossAmount = decimal.Round(GrossAmount, 2);
            DiscountAmount = decimal.Round(DiscountAmount, 2);
            FinalPayable = decimal.Round(FinalPayable, 2);
        }
    }
}
