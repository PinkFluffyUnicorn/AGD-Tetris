using System.Collections;
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
        if(CalculateDaysSinceStart() == 1)
        {
            AdvertiseEvent1.SetActive(true);
        }
        if(CalculateDaysSinceStart() == 2)
        {
            Event1.SetActive(true);
        }
        if (CalculateDaysSinceStart() == 3)
        {
            AdvertiseEvent2.SetActive(true);
        }
        if (CalculateDaysSinceStart() == 4)
        {
            Event2.SetActive(true);
        }
        if (CalculateDaysSinceStart() == 6)
        {
            AdvertiseQuestionaire.SetActive(true);
        }
        if (CalculateDaysSinceStart() == 7)
        {
            Questionaire.SetActive(true);
        }
    }

    private int CalculateDaysSinceStart()
    {
        int currentDay = System.DateTime.Now.DayOfYear;
        int startDay = PlayerPrefs.GetInt("StartDay");
        return currentDay - startDay;
    }
}
