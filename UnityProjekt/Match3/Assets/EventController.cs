using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {

    public GameObject AdvertiseEvent1;
    public GameObject AdvertiseEvent2;
    public GameObject Event1;
    public GameObject Event2;
    public GameObject EventHandler;


    // Use this for initialization
    void Start ()
    {
        int StartEvent2 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent2();
        int StartEvent1 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent1();
        int DurationEvent2 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent2();
        int DurationEvent1 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent1();

        //abfragen ob heute der Tag ist um das Event anzuzeigen 
        if (CalculateDaysSinceStart() == 1 && PlayerPrefs.GetInt("AdvertiseEvent1", 0) == 1)
        {
            AdvertiseEvent1.SetActive(true);
            PlayerPrefs.SetInt("AdvertiseEvent1", 2);
        }
        if(CalculateDaysSinceStart() == 2 && PlayerPrefs.GetInt("Event1", 0) == 1)
        {
            Event1.SetActive(true);
            PlayerPrefs.SetInt("AdvertiseEvent1", 2);
        }
        if (CalculateDaysSinceStart() == 3 && PlayerPrefs.GetInt("AdvertiseEvent2", 0) == 1)
        {
            AdvertiseEvent2.SetActive(true);
            PlayerPrefs.SetInt("AdvertiseEvent1", 2);
        }
        if (CalculateDaysSinceStart() == 4 && PlayerPrefs.GetInt("Event2", 0) == 1)
        {
            Event2.SetActive(true);
            PlayerPrefs.SetInt("AdvertiseEvent1", 2);
        }
    }

    private int CalculateDaysSinceStart()
    {
        int currentDay = System.DateTime.Now.DayOfYear;
        int startDay = PlayerPrefs.GetInt("StartDay");
        return currentDay - startDay;
    }
}
