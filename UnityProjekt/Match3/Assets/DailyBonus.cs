using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyBonus : MonoBehaviour
{
    //List: which day gets which Bonus
    public bool BonusDay0 = false;
    public bool BonusDay1 = false;
    public bool BonusDay2 = false;
    public bool BonusDay3 = false;
    public bool BonusDay4 = false;
    public bool BonusDay5 = false;
    public bool BonusDay6 = false;
    public bool BonusDay7 = false;


    // Use this for initialization
    public void OnEnable()
    {
        List<bool> BonusList = new List<bool> { BonusDay0, BonusDay1, BonusDay2, BonusDay3, BonusDay4, BonusDay5, BonusDay6, BonusDay7 };
        var lastDate = PlayerPrefs.GetInt("date", 0);
        var currentDate = System.DateTime.Now.Day;
        // calculate number of days user has been getting bonus in a row 
        int numberOfDailyBonus = PlayerPrefs.GetInt("NumberOfBonus", 0);

        if (currentDate - lastDate == 1 || (currentDate == 1 && lastDate == 31))
        {
            if (numberOfDailyBonus != 10) numberOfDailyBonus++; // user gets the same highest bonus after 10 days of getting bonus
        }
        else if (currentDate == lastDate)
        {
            //same Day, dont receive any Bonus
        }
        else // on first days or when user has not started game yesterday
        {
            numberOfDailyBonus = 0;
        }
        if (numberOfDailyBonus != 10)
        {
            numberOfDailyBonus = numberOfDailyBonus + 1;
        }
        else
        {
            numberOfDailyBonus = numberOfDailyBonus;
        }



        //update number of days user has been getting bonus in a row 
        PlayerPrefs.SetInt("NumberOfBonus", numberOfDailyBonus);
    }

    public void OnDisable()
    {
        // hier noch den Bonus den man erhält Updaten


        //set new date at the end of function so old date is still accessible
        PlayerPrefs.SetInt("date", System.DateTime.Now.Day);

        //close pop up 
        this.enabled = false;
    }
}
