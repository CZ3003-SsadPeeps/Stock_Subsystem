using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsManager : MonoBehaviour
{
    public RectTransform NewsDisplayed;
    public string newscontent;
    public RectTransform BackGround;
    // Start is called before the first frame update
    void Start()
    {
        //to wake up the newsdisplayed obj and assign the string to it
        BackGround = transform.Find("BackGround").GetComponent<RectTransform>();
        NewsDisplayed = BackGround.Find("NewsDisplayed").GetComponent<RectTransform>();
        newscontent = "TSLA CARS ARE LITERALLY ON FIRE!.";
        DisplayNews(newscontent);

    }

    //code to display news
    public void DisplayNews(string newscontent)
    {
        RectTransform Newsdisplayed = Instantiate(NewsDisplayed);
        Newsdisplayed.gameObject.SetActive(true);
        Newsdisplayed.transform.SetParent(BackGround.transform, false);
        Newsdisplayed.anchoredPosition = new Vector2(109f, 0f);
        Newsdisplayed.GetComponent<Text>().text = newscontent;
    }

    // used to retrieve the news needed from the databse
    // public string  RetrieveNews(){}

    //used to change the stock pricing becasue of the news, use FluctuationRate for this 
    //void ChangeStockPricing(FluctuationRate){}
}
