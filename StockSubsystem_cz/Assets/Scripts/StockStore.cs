public class StockStore
{
    public static readonly Stock[] stocks = new Stock[]
    {
        new Stock("Tesla", 56),
        new Stock("NIO Inc", 20),
    };

    public static int SelectedStockPos = -1;

    public static Stock SelectedStock {
        get
        {
            return stocks[SelectedStockPos];
        }
    }
}
