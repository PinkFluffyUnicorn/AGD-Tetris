using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyPickAxeBooster : MonoBehaviour {

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
            BoosterHandler.GetComponent<BoosterHandler>().addPickAxeBooster(amount);
            System.Type HammerType = typeof(HammerBooster);
            Player.Instance.GainBooster(HammerType, amount);
        }
        else
        {
            notEnoughMoney.SetActive(true);
            enoughMoney.SetActive(false);
        }
    }
}
