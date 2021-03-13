using System.Collections.Generic;

public class Stock
{
    static readonly System.Random random = new System.Random();
    
    
    public string Name { get; }
    public List<int> StockPriceHistory { get; } = new List<int>(10);

    // class in charge of the stock name and price list, edit this with db
    public Stock(string name, int priceHistory)
    {
        Name = name;

        for (int i = 1; i < 10; i++)
        {
            StockPriceHistory.Add(random.Next(priceHistory - 15, priceHistory + 16));
        }
        StockPriceHistory.Add(priceHistory);
    }
}
