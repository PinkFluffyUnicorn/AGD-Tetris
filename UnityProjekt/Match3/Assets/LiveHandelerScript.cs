using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveHandelerScript : MonoBehaviour {

    private int nextLiveIn = 0;
    private string timerOutput;
    private int timeToNextLive = 20; //Minuten bis zum nächsten Leben 
    public GameObject NotificationHandler;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            PlayerPrefs.SetInt("Lives", 5);
            PlayerPrefs.SetInt("NextLifeIn", 0);
        }
        else
        {
            nextLiveIn = PlayerPrefs.GetInt("NextLifeIn", 0); // um diese Uhrzeit in Sekunden gibt es ein neues Leben 
                                                              // hier noch aufrechnen dass die Zeit auch während Abwesenheit weiter gezählt wird 
            int today = System.DateTime.Now.DayOfYear;
            int lastDay = PlayerPrefs.GetInt("LastLifeDate", 0);
            if (lastDay < today)
            {
                addLives(5);
            }
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            //PlayerPrefs.SetInt("Lives", 5);
            timerOutput = "Full";
        }
        else
        {
            int Lives = PlayerPrefs.GetInt("Lives", 0);
            if (Lives < 5)
            {
                int today = System.DateTime.Now.DayOfYear;
                int lastDay = PlayerPrefs.GetInt("LastLifeDate", 0);
                if (lastDay < today)
                {
                    addLives(5);
                }
                else
                {
                    int currentTime = Mathf.FloorToInt((float)System.DateTime.Now.TimeOfDay.TotalSeconds);
                    if (currentTime >= nextLiveIn)
                    {
                        Lives += 1;
                        PlayerPrefs.SetInt("Lives", Lives);
                        if (Lives == 5)
                        {
                            timerOutput = "Full";
                        }
                        else
                        {
                            nextLiveIn = currentTime + (timeToNextLive * 60 - (currentTime - nextLiveIn)); // nächstes Leben in einer halben Stunde
                            PlayerPrefs.SetInt("NextLifeIn", nextLiveIn);
                        }
                    }
                    else
                    {
                        timerOutput = calculateTime(nextLiveIn - currentTime);
                    }
                }
            }
            else
            {
                timerOutput = "Full";
            }
        }
	}


    public void addLives(int amount)
    {
        int currentLives = PlayerPrefs.GetInt("Lives", 0);
        int newLives = currentLives +  amount; 
        if(newLives >= 5)
        {
            newLives = 5;
            timerOutput = "Full";
        }
        else
        {
            int currentTime = Mathf.FloorToInt((float)System.DateTime.Now.TimeOfDay.TotalSeconds);
            if (nextLiveIn < currentTime) // Timer nu updaten wenn nicht schon ein Leben runtergezählt wird 
            {
                nextLiveIn = currentTime + timeToNextLive * 60; //halbe Stunde
                timerOutput = calculateTime(nextLiveIn - currentTime);
                PlayerPrefs.SetInt("NextLifeIn", nextLiveIn);
            }
        }
        PlayerPrefs.SetInt("LastLifeDate", System.DateTime.Now.DayOfYear);
        PlayerPrefs.SetInt("Lives", newLives); 
    }

    public bool subtractLives(int amount)
    {
        if (PlayerPrefs.GetInt("Event2GoingOn", 0) == 1)
        {
            return true;
        }
        else
        {
            int currentLives = PlayerPrefs.GetInt("Lives", 0);
            if (currentLives - amount < 0) return false;
            else
            {
                PlayerPrefs.SetInt("Lives", currentLives - amount);
                int currentTime = Mathf.FloorToInt((float)System.DateTime.Now.TimeOfDay.TotalSeconds);
                nextLiveIn = currentTime + timeToNextLive * 60; //halbe Stunde
                PlayerPrefs.SetInt("NextLifeIn", nextLiveIn);
                if(currentLives - amount < 3)
                {
                    PlayerPrefs.SetInt("NotifLives", 1);
                }
                return true;
            }
        }
    }
    public int getLives()
    {
        return PlayerPrefs.GetInt("Lives", 0);
    }

    private string calculateTime(int time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = time % 60;
        if (seconds < 10)
        {
            return minutes + ":0" + seconds;
        }
        return minutes + ":" + seconds;
    }

    public string getTimer()
    {
        return timerOutput;
    }
}
