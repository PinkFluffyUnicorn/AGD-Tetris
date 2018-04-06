using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyPlusFiveBooster : MonoBehaviour {

    public GameObject moneyHandler;
    public int price;
    public int amount;
    public GameObject enoughMoney;
    public GameObject notEnoughMoney;
    public GameObject BoosterHandler;

    // Use this for initialization
    void Start()
    {


    }

    public void OnClick()
    {
        if (moneyHandler.GetComponent<MoneyHandlerScript>().subtractMoney(price))
        {
            enoughMoney.SetActive(true);
            notEnoughMoney.SetActive(false);
            BoosterHandler.GetComponent<BoosterHandler>().addPlusFiveBooster(amount);
        }
        else
        {
            notEnoughMoney.SetActive(true);
            enoughMoney.SetActive(false);
        }
    }
}
