using System;
using System.Collections.Generic;
using static test.Delegates;

namespace test
{
    internal class Events
    {
        public delegate void StockPriceChangeHandler(Stock stock, double oldPrice);

        public class Stock
        {
            public event StockPriceChangeHandler OnPriceChange;

            private int ID { get; }
            public string Name { get; }
            public double Price { set; get; }

            public Stock(int id, string name, double price)
            {
                ID = id;
                Name = name;
                Price = price;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{ID}, {Name}, {Price}");
            }

            public void ChangePriceBy(double percent)
            {
                double PriceBeforeChange = this.Price;
                this.Price += this.Price * percent;

                if (OnPriceChange != null) //make sure there is subscriber 
                {
                    OnPriceChange(this, PriceBeforeChange); //fire the event if there is subscriber 
                }

                //note:
                //the subscriber is the Program
                //the publisher is the Stock Class
            }

        }

        public static List<Stock> FillListWithStocks()
        {
            List<Stock> stocks = new List<Stock>()
            {
                new Stock(1, "Amazon", 3200.50),
                new Stock(2, "Apple", 145.30),
                new Stock(3, "Microsoft", 285.20),
                new Stock(4, "Google", 2750.10),
                new Stock(5, "Tesla", 780.25),
                new Stock(6, "Facebook", 365.75),
                new Stock(7, "Nvidia", 220.50),
                new Stock(8, "Netflix", 595.90),
                new Stock(9, "Intel", 55.30),
                new Stock(10, "AMD", 108.50),
                new Stock(11, "Adobe", 665.80),
                new Stock(12, "Cisco", 55.20),
                new Stock(13, "IBM", 145.10),
                new Stock(14, "Salesforce", 260.00),
                new Stock(15, "PayPal", 250.70),
                new Stock(16, "Alibaba", 180.40),
                new Stock(17, "Shopify", 1480.50),
                new Stock(18, "Square", 245.20),
                new Stock(19, "Snapchat", 70.15),
                new Stock(20, "Uber", 45.20)
            };
            return stocks;
        }

    }
}
