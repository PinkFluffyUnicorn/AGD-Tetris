using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerBoosterNew : MonoBehaviour
{

    public Text amountOfHammers;
    public GameObject BoosterHandler;
    private bool _buttonclicked = false;
    private int amount = 0;
     public GameObject buyBooster;

    

	// Use this for initialization
	void Start ()
    {
        amount = BoosterHandler.GetComponent<BoosterHandler>().getAMountPickAxeBooster();
        amountOfHammers.text = amount.ToString();
        if(amount < 1)
        {
             buyBooster.SetActive(true);
        }
        else
        {
             buyBooster.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        amount = PlayerPrefs.GetInt("PickAxeBooster", 0);
        amountOfHammers.text = amount.ToString();
        if (_buttonclicked)
        {
            //abfragen ob eingelöst, dann Summe abziehen und _buttonclicked auf false setzen 
            if(1 == 1)
            {
                _buttonclicked = false;
                amount -= 1;
                PlayerPrefs.SetInt("PickAxeBooster", amount);
            }
        }
		
	}

    public void OnClick() // click auf den Booster Button 
    {
        if (amount > 0)
        {
            if (!_buttonclicked) // Button wird zum ersten Mal angeklickt, hier muss irgendwie festgestellt werden, ob der Booster eingelöst wurde
                                 // ansonten würde beim nächsten Klick der else Teil ausgeführt 
            {

            }
            else // Booster wurde nicht eingelöst
            {
                _buttonclicked = false;
            }
        }
        else
        {
            //wenn wir nicht genug Booster haben soll der Shop aufgehen und nicht der Button angewendet werden 
        }
    }
}
