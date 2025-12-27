namespace QuickMartApp
{
    public class SaleTransaction
    {
        public string InvoiceNo { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string ItemName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal SellingAmount { get; set; }

        public string ProfitOrLossStatus { get; private set; } = "";
        public decimal ProfitOrLossAmount { get; private set; }
        public decimal ProfitMarginPercent { get; private set; }

        public void Calculate()
        {
            if (SellingAmount > PurchaseAmount)
            {
                ProfitOrLossStatus = "PROFIT";
                ProfitOrLossAmount = SellingAmount - PurchaseAmount;
            }
            else if (SellingAmount < PurchaseAmount)
            {
                ProfitOrLossStatus = "LOSS";
                ProfitOrLossAmount = PurchaseAmount - SellingAmount;
            }
            else
            {
                ProfitOrLossStatus = "BREAK-EVEN";
                ProfitOrLossAmount = 0m;
            }

            ProfitOrLossAmount = decimal.Round(ProfitOrLossAmount, 2);
            ProfitMarginPercent = PurchaseAmount > 0
                ? decimal.Round((ProfitOrLossAmount / PurchaseAmount) * 100, 2)
                : 0m;
        }
    }
}
