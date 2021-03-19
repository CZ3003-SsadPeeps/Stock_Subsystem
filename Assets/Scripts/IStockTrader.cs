using System.Collections.Generic;

public interface IStockTrader
{
    List<PlayerStock> GetPlayerStocks(string playerName);

    void SellAllStocks(Player[] players);
}
