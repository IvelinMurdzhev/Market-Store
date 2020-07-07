using System;

namespace MarketStore_Demo
{
    public class SilverCard : DiscountCard
    {
        //requirement of discount
        private readonly decimal _initialDiscount = 0.02M;
        private readonly decimal _conditionDiscount = 0.035M;

        public SilverCard(string owner,decimal turnover)
            : base (owner, turnover)
        {}

        protected override decimal DiscountRate
        {
            get
            {
                if (this.Turnover > 300M)
                    return _conditionDiscount;
                else
                    return _initialDiscount;
            }
        }

        public override void DisplayNameOfCard()
        {
            Console.WriteLine("2.Silver");
        }
    }
}
