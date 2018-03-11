using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event1Script_topLeft : MonoBehaviour {

    public GameObject Panel;
    public GameObject Background;
    public GameObject EventHandler;
    public Text timer;


	// Use this for initialization
	void Start ()
    {
        int StartEvent1 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent1();
        int DurationEvent1 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent1();

        if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            Background.SetActive(true);
            int time = DurationEvent1 - ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent1);
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
            Background.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
        //if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        if(1 ==1)
        {
            int StartEvent1 = EventHandler.GetComponent<EventHandlerScript>().getStartEvent1();
            int DurationEvent1 = EventHandler.GetComponent<EventHandlerScript>().getDurationEvent1();
            Panel.SetActive(true);
            Background.SetActive(true);
            int time = DurationEvent1 - ((int)System.DateTime.Now.TimeOfDay.TotalSeconds - StartEvent1);
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
            Background.SetActive(false);
        }
    }
}
