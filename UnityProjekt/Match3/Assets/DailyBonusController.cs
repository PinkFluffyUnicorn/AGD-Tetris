using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyBonusController : MonoBehaviour
{

    // Use this for initialization

    public GameObject DailyBonus;

    public void Start()
    {
        int startDay = PlayerPrefs.GetInt("StartDay", 0);
        int StartDayBonus = PlayerPrefs.GetInt("StartDayBonus", 0);
        if (PlayerPrefs.GetInt("date", 0) != System.DateTime.Now.DayOfYear || (System.DateTime.Now.DayOfYear == startDay && StartDayBonus == 0)) // same day, bonus was received already 
        {
            DailyBonus.SetActive(true);
            PlayerPrefs.SetInt("StartDayBonus", 1);
        }
        else
        {
            DailyBonus.SetActive(false);
        }
    }

}
