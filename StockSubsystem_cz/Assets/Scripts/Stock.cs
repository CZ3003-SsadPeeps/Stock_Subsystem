using System.Collections.Generic;

public class Stock
{
    static readonly System.Random random = new System.Random();

    public string Name { get; }
    public List<int> StockPriceHistory { get; } = new List<int>(10);

    public Stock(string name, int priceHistory)
    {
        Name = name;

        for (int i = 0; i < 9; i++)
        {
            StockPriceHistory.Add(random.Next(priceHistory - 15, priceHistory + 16));
        }
        StockPriceHistory.Add(priceHistory);
    }
}
