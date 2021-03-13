using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EditQuantity : MonoBehaviour
{

    public class Stocks
    {
        public string Name;
        public double Price;
        public Stocks(string name, double price)
        {
            Name = name;
            Price = price;
        }
        // Other properties, methods, events...
    }

    public Text stockName;
    public Text stockPrice;
    public int quantity;
    public Text quantityText;
    public double amount;
    public Text amountText;

    Stocks tesla = new Stocks("Tesla Motor", 621.44f);

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        stockName.text = tesla.Name.ToString();
        stockPrice.text = tesla.Price.ToString();
        quantityText.text = quantity.ToString();
        amountText.text = amount.ToString();
    }

    public void addQuantity()
    {
        quantity++;
        amount += tesla.Price;
    }

    public void minusQuantity()
    {
        if (quantity > 0) 
        { 
            quantity--;
            amount -= tesla.Price;
        }
    }

}
