using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutOfMovesNew : MonoBehaviour {

    public Text amountString;
    public MoneyHandlerScript moneyHandler;
    public GameObject NotEnoughMoney;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        int amount = int.Parse(amountString.text);
        bool enoughMoney = moneyHandler.GetComponent<MoneyHandlerScript>().subtractMoney(amount);
        if(!enoughMoney)
        {
            NotEnoughMoney.SetActive(true);
        }
        else
        {
            NotEnoughMoney.SetActive(false);
        }
    }
}
