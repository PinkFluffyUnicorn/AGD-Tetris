using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveHandelerScript : MonoBehaviour {
    //private int timer = 0; // so viele Minuten bis zum neuen automatischen Leben
    private int nextLiveIn = 0; // um diese Uhrzeit in Sekunden gibt es ein neues Leben 
    private string timerOutput;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        int Lives = PlayerPrefs.GetInt("Lives", 0);
		if(Lives != 5)
        {
            int currentTime = Mathf.FloorToInt((float)System.DateTime.Now.TimeOfDay.TotalSeconds);
            if(currentTime >= nextLiveIn)
            {
                PlayerPrefs.SetInt("Lives", Lives + 1);
                if(Lives + 1 == 5)
                {
                    timerOutput = "Full";
                }
                else
                {
                    nextLiveIn = currentTime + (30 * 60 - currentTime - nextLiveIn); // nächstes Leben in einer halben Stunde
                }
            }
            else
            {
                timerOutput = calculateTime(nextLiveIn - currentTime);
            }
        }
        else
        {
            timerOutput = "Full";
        }
	}


    public void addLives(int amount)
    {
        int currentLives = PlayerPrefs.GetInt("Lives", 0);
        currentLives += amount; 
        if(amount > 5)
        {
            amount = 5;
            timerOutput = "Full";
        }
        else
        {
            int currentTime = Mathf.FloorToInt((float)System.DateTime.Now.TimeOfDay.TotalSeconds);
            nextLiveIn = currentTime + 30 * 60; //halbe Stunde
            timerOutput = calculateTime(nextLiveIn - currentTime);
        }
        PlayerPrefs.SetInt("Lives", amount);
        
    }

    public bool subtractLives(int amount)
    {
        int currentLives = PlayerPrefs.GetInt("Lives", 0);
        if (currentLives - amount < 0) return false;
        else
        {
            PlayerPrefs.SetInt("Lives", currentLives - amount);
            int currentTime = Mathf.FloorToInt((float)System.DateTime.Now.TimeOfDay.TotalSeconds);
            nextLiveIn = currentTime + 30 * 60; //halbe Stunde
            return true;
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
        return minutes + ":" + seconds;
    }

    public string getTimer()
    {
        return timerOutput;
    }
}
