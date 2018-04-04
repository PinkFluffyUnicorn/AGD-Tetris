using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusFiveBoosterNew : MonoBehaviour {


    public Text amountOfBooster;
    public GameObject BoosterHandler;
    private bool _buttonclicked = false;
    private int amount = 0;
    public GameObject buyBooster;



    // Use this for initialization
    void Start ()
    {
        amount = PlayerPrefs.GetInt("PlusFiveBooster", 0);
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
	void Update () {
		
	}
}
