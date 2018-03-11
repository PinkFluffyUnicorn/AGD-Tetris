using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandlerScript : MonoBehaviour {

    void Start()
    {
        int DaysSinceStart = CalculateDaysSinceStart();
        int DurationEvent1 = 3* 60 * 60;
        int DurationEvent2 = 3 * 60 * 60;
        //abfragen ob heute der Tag ist um das Event anzuzeigen 
        if (DaysSinceStart == 1 && PlayerPrefs.GetInt("AdvertiseEvent1", 0) == 0)
        {
            PlayerPrefs.SetInt("AdvertiseEvent1", 1);
        }
        if (DaysSinceStart == 2 && PlayerPrefs.GetInt("Event1", 0) == 0)
        {
            PlayerPrefs.SetInt("Event1", 1);
            PlayerPrefs.SetInt("Event1GoingOn", 1);
            int start = (int)System.DateTime.Now.TimeOfDay.TotalSeconds;
            PlayerPrefs.SetInt("Event1Start", start);
            if(start + DurationEvent1 > 24 * 60 * 60)// falls das Event länger als bis Mitternacht gehen würde, so kürzen dass es nur bis Mitternacht geht 
            {
                DurationEvent1 = (24 * 60 * 60) - start - 1;
            }
            PlayerPrefs.SetInt("Event1Duration", DurationEvent1);            
        }
        if (DaysSinceStart == 3 && PlayerPrefs.GetInt("AdvertiseEvent2", 0) == 0)
        {
            PlayerPrefs.SetInt("AdvertiseEvent2", 1);
        }
        if (DaysSinceStart == 4 && PlayerPrefs.GetInt("Event2", 0) == 0)
        {
            PlayerPrefs.SetInt("Event2", 1);
            PlayerPrefs.SetInt("Event2GoingOn", 1);
            int start = (int)System.DateTime.Now.TimeOfDay.TotalSeconds;
            PlayerPrefs.SetInt("Event2Start", start);
            if (start + DurationEvent2 > 24 * 60 * 60)// falls das Event länger als bis Mitternacht gehen würde, so kürzen dass es nur bis Mitternacht geht 
            {
                DurationEvent2 = (24 * 60 * 60) - start - 1;
            }
            PlayerPrefs.SetInt("Event2Duration", DurationEvent2);
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
