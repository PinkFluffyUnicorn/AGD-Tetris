using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandlerScript : MonoBehaviour {

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
            PlayerPrefs.SetInt("Event1Start", (int)System.DateTime.Now.TimeOfDay.TotalSeconds);
            PlayerPrefs.SetInt("Event1Duration", 30 * 60);
        }
        if (DaysSinceStart == 3 && PlayerPrefs.GetInt("AdvertiseEvent2", 0) == 0)
        {
            PlayerPrefs.SetInt("AdvertiseEvent2", 1);
        }
        if (DaysSinceStart == 4 && PlayerPrefs.GetInt("Event2", 0) == 0)
        {
            PlayerPrefs.SetInt("Event2", 1);
            PlayerPrefs.SetInt("Event2GoingOn", 1);
            PlayerPrefs.SetInt("Event2Start", (int)System.DateTime.Now.TimeOfDay.TotalSeconds);
            PlayerPrefs.SetInt("Event2Duration", 30 * 60);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            if ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - getStartEvent2() > getDurationEvent2())
            {
                PlayerPrefs.SetInt("Event2GoingOn", 0);
            }
        }

        if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            if ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - getStartEvent1() > getDurationEvent1())
            {
                PlayerPrefs.SetInt("Event1GoingOn", 0);
            }
        }
    }

    public int getStartEvent2()
    {
        return PlayerPrefs.GetInt("Event2Start", 0);
    }

    public int getStartEvent1()
    {
        return PlayerPrefs.GetInt("Event1Start", 0);
    }

    public int getDurationEvent1()
    {
        return PlayerPrefs.GetInt("Event1Duration", 0);
    }

    public int getDurationEvent2()
    {
        return PlayerPrefs.GetInt("Event2Duration", 0);
    }

    private int CalculateDaysSinceStart()
    {
        int currentDay = System.DateTime.Now.DayOfYear;
        
        int startDay = PlayerPrefs.GetInt("StartDay");
        return currentDay - startDay;
    }
}
