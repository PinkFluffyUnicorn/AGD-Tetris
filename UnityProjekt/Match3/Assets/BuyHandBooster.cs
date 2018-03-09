﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyHandBooster : MonoBehaviour {

    public GameObject moneyHandler;
    public int amount;
    public int price;
    public GameObject enoughMoney;
    public GameObject notEnoughMoney;

    // Use this for initialization
    void Start()
    {


    }

    public void OnClick()
    {
        if (moneyHandler.GetComponent<MoneyHandlerScript>().subtractMoney(price))
        {
            enoughMoney.SetActive(true);
        }
        else
        {
            notEnoughMoney.SetActive(true);
        }
    }
}
