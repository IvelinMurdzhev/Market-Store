using System;

namespace MarketStore_Demo
{
    public class BronzeCard : DiscountCard
    {
        //requirement of discount
        private readonly decimal _conditionOne = 0.0M;
        private readonly decimal _conditionTwo = 0.01M;
        private readonly decimal _conditionThree = 0.025M;

        public BronzeCard(string owner, decimal turnover)
            : base(owner, turnover)
        {}

        protected override decimal DiscountRate
        {
            get
            {
                if (this.Turnover <= 0)
                    return _conditionOne;
                else if (this.Turnover > 100M && this.Turnover < 300M)
                    return _conditionTwo;
                else
                    return _conditionThree;

            }

        }

        public override void DisplayNameOfCard()
        {
            Console.WriteLine("1.Bronze");
        }
    }
}
