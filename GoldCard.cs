using System;

namespace MarketStore_Demo
{
    public class GoldCard : DiscountCard
    {
        //requirement of discount
        private readonly decimal _initialDiscount = 0.02M;
        private readonly decimal _discountRateGrow = 0.01M;
        private readonly decimal _cappingDiscount = 0.1M;

        public GoldCard(string owner, decimal turnover)
            : base(owner, turnover)
        {}

        protected override decimal DiscountRate
        {
            get
            {
                var round = Math.Round(this.Turnover / _discountRateGrow) / 100;
                var min = Math.Min(round, _cappingDiscount);
                return  Math.Max(_initialDiscount, min);
            }
        }

        public override void DisplayNameOfCard()
        {
            Console.WriteLine("3.Gold");
        }
    }
            
}
