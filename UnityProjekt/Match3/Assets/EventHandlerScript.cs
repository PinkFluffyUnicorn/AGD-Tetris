using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandlerScript : MonoBehaviour {

    private int StartEvent1;
    private int StartEvent2;
    private int DurationEvent1 = 30 * 60; //in seconds
    private int DurationEvent2 = 30 * 60; //in minutes

    void Start()
    {
        int DaysSinceStart = CalculateDaysSinceStart();
        //abfragen ob heute der Tag ist um das Event anzuzeigen 
        if (DaysSinceStart == 1 && PlayerPrefs.GetInt("AdvertiseEvent1", 0) == 0)
        {
            PlayerPrefs.SetInt("AdvertiseEvent1", 1);
        }
        if (DaysSinceStart == 2 && PlayerPrefs.GetInt("Event1", 0) == 0)
        {
            PlayerPrefs.SetInt("Event1", 1);
            PlayerPrefs.SetInt("Event1GoingOn", 1);
            StartEvent1 = (int)System.DateTime.Now.TimeOfDay.TotalSeconds;
        }
        if (DaysSinceStart == 3 && PlayerPrefs.GetInt("AdvertiseEvent2", 0) == 0)
        {
            PlayerPrefs.SetInt("AdvertiseEvent2", 1);
        }
        if (DaysSinceStart == 4 && PlayerPrefs.GetInt("Event2", 0) == 0)
        {
            PlayerPrefs.SetInt("Event2", 1);
            PlayerPrefs.SetInt("Event2GoingOn", 1);
            StartEvent2 = (int)System.DateTime.Now.TimeOfDay.TotalSeconds; ;
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            if ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent2 > DurationEvent2)
            {
                PlayerPrefs.SetInt("Event2GoingOn", 0);
            }
        }

        if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            if ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent1 > DurationEvent1)
            {
                PlayerPrefs.SetInt("Event1GoingOn", 0);
            }
        }
    }

    public int getStartEvent2()
    {
        return StartEvent2;
    }

    public int getStartEvent1()
    {
        return StartEvent1;
    }

    public int getDurationEvent1()
    {
        return DurationEvent1;
    }

    public int getDurationEvent2()
    {
        return DurationEvent2;
    }

    private int CalculateDaysSinceStart()
    {
        int currentDay = System.DateTime.Now.DayOfYear;
        //PlayerPrefs.SetInt("StartDay", 67);
        int startDay = PlayerPrefs.GetInt("StartDay");
        return currentDay - startDay;
    }
}
