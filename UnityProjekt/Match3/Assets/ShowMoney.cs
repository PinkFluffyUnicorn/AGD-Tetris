using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMoney : MonoBehaviour {

    public Text amountOfMoney;
	// Use this for initialization
	void Start () {
        amountOfMoney.text = PlayerPrefs.GetInt("Money", 0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        amountOfMoney.text = PlayerPrefs.GetInt("Money", 0).ToString();
    }
}
