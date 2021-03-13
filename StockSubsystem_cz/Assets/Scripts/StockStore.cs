public class StockStore
{

    //initializes the list of stocks and stores here 
    public static readonly Stock[] stocks = new Stock[]
    {
        new Stock("Tesla", 56),
        new Stock("NIO Inc", 20),
        new Stock("GME", 50),
        new Stock("AMC",20),
    };

    // initializes the stock pointer to -1
    public static int SelectedStockPos = -1;

    // throws the stock obj to window to display when selected
    public static Stock SelectedStock {
        get
        {
            return stocks[SelectedStockPos];
        }
    }
}
