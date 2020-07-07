using System;
using System.Globalization;

namespace MarketStore_Demo
{
    public abstract class DiscountCard
    {
        public DiscountCard(string owner, decimal turnover)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            
        }
        protected string Owner { get; set; }
        protected decimal  Turnover { get; set; }
        protected abstract decimal DiscountRate { get; }
        public abstract void DisplayNameOfCard();

        protected decimal CalculateDiscountSize(decimal valueOfPurchase)
        {
            if(valueOfPurchase <= 0)
                throw new InvalidOperationException("The purchase must have a price!");
            else
                return valueOfPurchase * this.DiscountRate;
        }

        public void DataPrintINfo(decimal valueOfPurchase)
        {
            var discount = CalculateDiscountSize(valueOfPurchase);
            var totalPurchase = valueOfPurchase - discount;
            var culture = new CultureInfo("en-US");

            DisplayNameOfCard();
            Console.WriteLine($"  a. Mock data: turnover $" + Turnover + ", purchase value $" + valueOfPurchase);
            Console.WriteLine($"  b. Output:");
            Console.WriteLine($"  Purchase value: {valueOfPurchase.ToString("C2", culture)}");
            Console.WriteLine($"  Discount rate: {DiscountRate.ToString("P1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"  Discount: {discount.ToString("C2", culture)}");
            Console.WriteLine($"  Total: {totalPurchase.ToString("C2", culture)}");
        }
    }
}
