using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleMoney : MonoBehaviour {

	// Use this for initialization
    //every time the game ist started the Player gets 1000 money on the old system 

	void Update ()
    {
        int money = Player.Instance.HardCurrency;
        if (money < 5000)
        {
            Player.Instance.GainCurrency(10000);
        }
		
	}

}
