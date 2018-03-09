using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScript : MonoBehaviour {

    public GameObject AdvertiseEvent1;
    public GameObject AdvertiseEvent2;
    public GameObject Event1;
    public GameObject Event2;

	// Use this for initialization
	void Start ()
    {
        int DaysSinceStart = CalculateDaysSinceStart();
        if (DaysSinceStart == 1 )
        {
            AdvertiseEvent1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            Event1.SetActive(true);
        }
        if (DaysSinceStart == 3)
        {
            AdvertiseEvent2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            Event2.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        int DaysSinceStart = CalculateDaysSinceStart();
        if (DaysSinceStart == 1)
        {
            AdvertiseEvent1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            Event1.SetActive(true);
        }
        if (DaysSinceStart == 3)
        {
            AdvertiseEvent2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            Event2.SetActive(true);
        }
    }

    private int CalculateDaysSinceStart()
    {
        int currentDay = System.DateTime.Now.DayOfYear;
        int startDay = PlayerPrefs.GetInt("StartDay");
        return currentDay - startDay;
    }
}
