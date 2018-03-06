using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateCoinCount : MonoBehaviour {

    public GameObject moneyHandler;
    public Text moneyCount;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moneyCount.text = moneyHandler.GetComponent<MoneyHandlerScript>().getMoney().ToString();
    }
}
