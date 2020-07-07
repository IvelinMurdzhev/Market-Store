using System;

namespace MarketStore_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bronzeCard = new BronzeCard("CustomerOne", 0);
            var silverCard = new SilverCard("CustomerTwo", 600);
            var goldCard = new GoldCard("CustomerThree", 1500);

            var bronzePurchase = 150;
            var silverPurchase = 850;
            var goldPurchase = 1300;

            bronzeCard.DataPrintINfo(bronzePurchase);
            silverCard.DataPrintINfo(silverPurchase);
            goldCard.DataPrintINfo(goldPurchase);

            Console.ReadKey();
        }
    }
}
