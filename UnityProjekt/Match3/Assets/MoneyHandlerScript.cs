using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyHandlerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addMoney(int money)
    {
        if (money < 0)
            return;
        PlayerPrefs.SetInt("Money", getMoney() + money);
    }

    public bool subtractMoney(int money)
    {
        int moneyLeft = getMoney() - money;
        if (money >= 0)
        {
            PlayerPrefs.SetInt("Money", moneyLeft);
            return true;
        }
        else
            return false;
        
    }

    public int getMoney()
    {
        return PlayerPrefs.GetInt("Money");
    }
}
