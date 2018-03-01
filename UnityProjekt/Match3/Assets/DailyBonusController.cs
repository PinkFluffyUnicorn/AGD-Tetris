using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyBonusController : MonoBehaviour
{

    // Use this for initialization

    public GameObject DailyBonus;

    public void Start()
    {
        //if(PlayerPrefs.GetInt("date", 0) == System.DateTime.Now.Day)
        //{
        //    //dont do anything
        //}
        //else
        //{
        //    DailyBonus.SetActive(true);
        //}
        DailyBonus.SetActive(true);
    }

}
