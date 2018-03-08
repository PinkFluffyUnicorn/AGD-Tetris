using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyBonus : MonoBehaviour
{
    public GameObject moneyHandler;

    public Image BonusDay1Received, BonusDay2Received, BonusDay3Received, BonusDay4Received, BonusDay5Received, BonusDay6Received;
    public Image BonusDay1, BonusDay2, BonusDay3, BonusDay4, BonusDay5, BonusDay6, BonusDay7;
    private int Bonus;

    // Use this for initialization, calculate Bonus 0 based
    public void Start()
    {
        List<Image> CurrentBonusList = new List<Image> { BonusDay1, BonusDay2, BonusDay3, BonusDay4, BonusDay5, BonusDay6, BonusDay7 };
        List<Image> ReceivedBonusList = new List<Image> { BonusDay1Received, BonusDay2Received, BonusDay3Received, BonusDay4Received, BonusDay5Received, BonusDay6Received };
        List<int> BonusList = new List<int> { 5, 9, 14, 20, 27, 36, 100};

        var lastDate = PlayerPrefs.GetInt("date", 0);
        var currentDate = System.DateTime.Now.DayOfYear;
        // read out number of days user has been getting bonus in a row 
        int numberOfDailyBonus = PlayerPrefs.GetInt("NumberOfBonus", 0);


        //--------------------Update numberOfDailyBonus-----------------------
        //old numberOfDailyBonus gets stored and updated by ine if the user was there yesterday
        if (currentDate - lastDate == 1)
        {
            //moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(BonusList[numberOfDailyBonus]);
            if (numberOfDailyBonus < 6)
                numberOfDailyBonus++; // user gets the same highest bonus after 7 days of getting bonus
        }
        else if (currentDate == lastDate)
        {
            //same Day, dont receive any Bonus
        }
        else // on first days or when user has not started game yesterday
        {
            numberOfDailyBonus = 0;
        }


        //numberOfDailyBonus = 0; //for testing

        //set pictures accordingly to Bonus, 
        for (int i = 0; i < 6; i++)
        {
            if (i < numberOfDailyBonus)
            {
                ReceivedBonusList[i].enabled = true;
            }
            else
            {
                ReceivedBonusList[i].enabled = false;
            }
        }

        for (int i = 0; i < 7; i++)
        {
            if (i == numberOfDailyBonus)
            {
                CurrentBonusList[i].enabled = true;
                Bonus = BonusList[i];
            }
            else
            {
                CurrentBonusList[i].enabled = false;
            }
        }

        //update number of days user has been getting bonus in a row 
        PlayerPrefs.SetInt("NumberOfBonus", numberOfDailyBonus);
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
