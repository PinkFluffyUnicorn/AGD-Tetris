using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusMoney : MonoBehaviour
{
    public MoneyHandlerScript moneyHandler;
    public int amount;
    public GameObject NotEnoughMoney;
    public Text text;
	// Use this for initialization
	void Start ()
    {
        text.text = moneyHandler.GetComponent<MoneyHandlerScript>().getMoney().ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        text.text = moneyHandler.GetComponent<MoneyHandlerScript>().getMoney().ToString();
	}

    public void OnClick()
    {
        var successfull = moneyHandler.GetComponent<MoneyHandlerScript>().subtractMoney(amount); 
        if(!successfull)
        {
            NotEnoughMoney.SetActive(true);
        }
        else
        {
            NotEnoughMoney.SetActive(false);
        }
    }
}
