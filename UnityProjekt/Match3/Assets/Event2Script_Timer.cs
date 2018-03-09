using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event2Script_Timer : MonoBehaviour {

    public GameObject Panel;
    public Text timer;
    public GameObject EventHandler;

	// Use this for initialization
	void Start ()
    {
        int StartEvent2 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent2();
        int StartEvent1 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent1();
        int DurationEvent2 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent2();
        int DurationEvent1 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent1();
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            int time = DurationEvent2 - ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent2);
            int seconds = time % 60;
            int minutes = time / 60;
            if(seconds < 10)
            {
                timer.text = minutes + ":0" + seconds;
            }
            else
            {
                timer.text = minutes + ":" + seconds;
            }
        }
        else
        {
            Panel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        int StartEvent2 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent2();
        int StartEvent1 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent1();
        int DurationEvent2 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent2();
        int DurationEvent1 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent1();
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            int time = DurationEvent2 - ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent2);
            int seconds = time % 60;
            int minutes = time / 60;
            if (seconds < 10)
            {
                timer.text = minutes + ":0" + seconds;
            }
            else
            {
                timer.text = minutes + ":" + seconds;
            }
        }
        else
        {
            Panel.SetActive(false);
        }
    }
}
