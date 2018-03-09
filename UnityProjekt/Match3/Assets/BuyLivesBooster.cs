using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyLivesBooster : MonoBehaviour {

    public GameObject moneyHandler;
    public int amount;
    public int price;
    public GameObject enoughMoney;
    public GameObject notEnoughMoney;
    public GameObject LiveHandler;

    // Use this for initialization
    void Start()
    {


    }

    public void OnClick()
    {
        if (moneyHandler.GetComponent<MoneyHandlerScript>().subtractMoney(price))
        {
            enoughMoney.SetActive(true);
            LiveHandler.GetComponent<LiveHandelerScript>().addLives(amount);
        }
        else
        {
            notEnoughMoney.SetActive(true);
        }
    }
}
