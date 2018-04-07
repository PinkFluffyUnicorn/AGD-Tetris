using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusFiveBoosterNew : MonoBehaviour {


    public Text amountOfBooster;
    public GameObject BoosterHandler;
    private int amount = 0;
    public GameObject buyBooster; // Button der das Booster kaufen ermöglicht, macht Shop auf oder so ? 



    // Use this for initialization
    void Start ()
    {
        amount = BoosterHandler.GetComponent<BoosterHandler>().getAMountPlusFiveBooster();
        amountOfBooster.text = amount.ToString();
        if (amount < 1)
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
        amount = BoosterHandler.GetComponent<BoosterHandler>().getAMountPlusFiveBooster();
        amountOfBooster.text = amount.ToString();
        if (amount < 1)
        {
             buyBooster.SetActive(true);
        }
        else
        {
            buyBooster.SetActive(false);
        }
    }

    public void OnClick()
    {
        if(BoosterHandler.GetComponent<BoosterHandler>().subtractPlusFiveBooster(1))
        {
            amount -= 1;
            BoosterHandler.GetComponent<BoosterHandler>().subtractPlusFiveBooster(1);
        }
        else
        {

        }
    }
}
