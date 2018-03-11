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
        int DurationEvent2 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent2();

        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            int time = DurationEvent2 - ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent2);
            float hoursHelp = ((time / 60) / 60);
            int hours = Mathf.FloorToInt(hoursHelp);
            int seconds = time % 60;
            int minutes = (int)(hoursHelp - (float)hours) * 60;
            if (hours == 0)
            {
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
                if(minutes < 10)
                {
                    if (seconds < 10)
                    {
                        timer.text = hours+":0"+minutes + ":0" + seconds;
                    }
                    else
                    {
                        timer.text = hours+":0"+minutes + ":" + seconds;
                    }
                }
                else
                {
                    if (seconds < 10)
                    {
                        timer.text = hours+":"+minutes + ":0" + seconds;
                    }
                    else
                    {
                        timer.text = hours+":"+minutes + ":" + seconds;
                    }
                }
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
        int DurationEvent2 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent2();
        
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            int time = DurationEvent2 - ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent2);
            float hoursHelp = ((time / 60) / 60);
            int hours = Mathf.FloorToInt(hoursHelp);
            int seconds = time % 60;
            int minutes = (int)(hoursHelp - (float)hours) * 60;
            if (hours == 0)
            {
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
                if (minutes < 10)
                {
                    if (seconds < 10)
                    {
                        timer.text = hours + ":0" + minutes + ":0" + seconds;
                    }
                    else
                    {
                        timer.text = hours + ":0" + minutes + ":" + seconds;
                    }
                }
                else
                {
                    if (seconds < 10)
                    {
                        timer.text = hours + ":" + minutes + ":0" + seconds;
                    }
                    else
                    {
                        timer.text = hours + ":" + minutes + ":" + seconds;
                    }
                }
            }
        }
        else
        {
            Panel.SetActive(false);
        }
    }
}
