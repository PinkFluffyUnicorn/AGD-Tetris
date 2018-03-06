﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {

    public GameObject AdvertiseEvent1;
    public GameObject AdvertiseEvent2;
    public GameObject Event1;
    public GameObject Event2;
    public GameObject AdvertiseQuestionaire;
    public GameObject Questionaire;


    // Use this for initialization
    void Start ()
    {
        //Datum des ersten tages setzen, wenn es noch nicht gesetzt ist 
        if(!PlayerPrefs.HasKey("StartDay"))
        {
            PlayerPrefs.SetInt("StartDay", System.DateTime.Now.DayOfYear);
        }

		//abfragen ob heute der Tag ist um das Event anzuzeigen 
        if(CalculateDaysSinceStart() == 1 && PlayerPrefs.GetInt("AdvertiseEvent1", 0) == 0)
        {
            AdvertiseEvent1.SetActive(true);
            PlayerPrefs.SetInt("AdvertiseEvent1", 1);
        }
        if(CalculateDaysSinceStart() == 2 && PlayerPrefs.GetInt("Event1", 0) == 0)
        {
            Event1.SetActive(true);
            PlayerPrefs.SetInt("Event1", 1);
        }
        if (CalculateDaysSinceStart() == 3 && PlayerPrefs.GetInt("AdvertiseEvent2", 0) == 0)
        {
            AdvertiseEvent2.SetActive(true);
            PlayerPrefs.SetInt("AdvertiseEvent2", 1);
        }
        if (CalculateDaysSinceStart() == 4 && PlayerPrefs.GetInt("Event2", 0) == 0)
        {
            Event2.SetActive(true);
            PlayerPrefs.SetInt("Event2", 1);
        }
        if (CalculateDaysSinceStart() == 6 && PlayerPrefs.GetInt("AdvQuestionaire", 0) == 0)
        {
            AdvertiseQuestionaire.SetActive(true);
            PlayerPrefs.SetInt("AdvQuestionaire", 1);
        }
        if (CalculateDaysSinceStart() == 7 && PlayerPrefs.GetInt("Questionaire", 0) == 0)
        {
            Questionaire.SetActive(true);
            PlayerPrefs.SetInt("Questionaire", 1);
        }
    }

    private int CalculateDaysSinceStart()
    {
        int currentDay = System.DateTime.Now.DayOfYear;
        int startDay = PlayerPrefs.GetInt("StartDay");
        return currentDay - startDay;
    }
}