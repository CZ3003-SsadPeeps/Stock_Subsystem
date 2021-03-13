using UnityEngine;
using UnityEngine.SceneManagement;

public class StockRow : MonoBehaviour
{
    public int RowPos { get; set; }

    public void OnTradeButtonClick()
    {
        StockStore.SelectedStockPos = RowPos;
        SceneManager.LoadScene("Tesla");
    }
}
