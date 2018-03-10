using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyBonus2 : MonoBehaviour {

    public Image BonusDay1Received, BonusDay2Received, BonusDay3Received, BonusDay4Received, BonusDay5Received, BonusDay6Received;
    public Image BonusDay1, BonusDay2, BonusDay3, BonusDay4, BonusDay5, BonusDay6, BonusDay7;
    // Use this for initialization
    void Start ()
    {
        //1 am ersten Tag usw.bis 6 
        int numberOfDailyBonus = PlayerPrefs.GetInt("NumberOfBonus", 0);

        // das für morgen, die noch nicht erhaltenen & die schon erhaltenen 
        List<Image> CurrentBonusList = new List<Image> { BonusDay1, BonusDay2, BonusDay3, BonusDay4, BonusDay5, BonusDay6, BonusDay7 };
        List<Image> ReceivedBonusList = new List<Image> { BonusDay1Received, BonusDay2Received, BonusDay3Received, BonusDay4Received, BonusDay5Received, BonusDay6Received };

        for (int i = 0; i < 6; i++)
        {
            if(i <= numberOfDailyBonus)
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
            if(i == numberOfDailyBonus + 1 || (numberOfDailyBonus == 6 && i == numberOfDailyBonus))
            {
                CurrentBonusList[i].enabled = true;
            }
            else
            {
                CurrentBonusList[i].enabled = false;
            }
        }

    }
}
