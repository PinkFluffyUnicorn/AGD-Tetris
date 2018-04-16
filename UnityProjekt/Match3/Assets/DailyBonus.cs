using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyBonus : MonoBehaviour
{
    public GameObject moneyHandler;


    private int Bonus = 30;

    // Use this for initialization, calculate Bonus 0 based
    public void Start()
    {
    }

    public void OnDisable()
    {
        // hier noch den Bonus den man erhält Updaten -> Bonus
        moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(Bonus);

        //set new date at the end of function so old date is still accessible
        PlayerPrefs.SetInt("date", System.DateTime.Now.DayOfYear);

        //close pop up 
        this.enabled = false;
    }
}
