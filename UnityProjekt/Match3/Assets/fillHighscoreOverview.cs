using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillHighscoreOverview : MonoBehaviour {

    public Text person1;
    public Text person2;
    public Text person3;
    public Text person4;
    public Text person5;
    public Text person6;
    public Text person7;
    public Text person8;
    public Text person9;
    public Text person10;

    public Text levelNumber1;
    public Text levelNumber2;
    public Text levelNumber3;
    public Text levelNumber4;
    public Text levelNumber5;
    public Text levelNumber6;
    public Text levelNumber7;
    public Text levelNumber8;
    public Text levelNumber9;
    public Text levelNumber10;

    int enterysInTable = 10;

    public Text buttonText;//TODO: set here
    public Text descriptionText; //TODO: setHere

    public GameObject highscoreDownloader;

    // Use this for initialization
    void Start () {
        List<string> data = highscoreDownloader.GetComponent<DownloadHighscores>().getOverallHighscores();
        bool matched = false;
        for (int i = 0; i < data.Count; i++)//somewhere in the middle
        {
            if (data[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1] == PlayerPrefs.GetString("Username"))
            {
                matched = true;
                if (i <= Mathf.FloorToInt((float)enterysInTable / 2f) || data.Count < enterysInTable)//higher
                    fillTable(data, 0);
                else if (i >= (data.Count - Mathf.FloorToInt((float)enterysInTable / 2f)))//smaller
                    fillTable(data, i + 1 - enterysInTable);
                else//in the middle
                    fillTable(data, i - Mathf.FloorToInt((float)enterysInTable / 2f));
            }
        }
        if(!matched)
            fillTable(data, 0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void fillTable(List<string> data, int startvalue)
    {
        if (data.Count >= startvalue + 1)
        {
            person1.text = data[startvalue + 0];
            levelNumber1.text = startvalue+1+"";
        }
        else
            person1.text = "---";

        if (data.Count >= startvalue + 2) { 
            person2.text = data[startvalue + 1];
            levelNumber2.text = startvalue+2 + "";
        }
        else
            person2.text = "---";

        if (data.Count >= startvalue + 3) { 
            person3.text = data[startvalue + 2];
            levelNumber3.text = startvalue + 3 + "";
        }
        else
            person3.text = "---";

        if (data.Count >= startvalue + 4)
        {
            person4.text = data[startvalue + 3];
            levelNumber4.text = startvalue + 4 + "";
        }
        else
            person4.text = "---";

        if (data.Count >= startvalue + 5)
        {
            person5.text = data[startvalue + 4];
            levelNumber5.text = startvalue + 5 + "";
        }
        else
            person5.text = "---";

        if (data.Count >= startvalue + 6) { 
            person6.text = data[startvalue + 5];
            levelNumber6.text = startvalue + 6 + "";
        }
        else
            person6.text = "---";

        if (data.Count >= startvalue + 7) { 
            person7.text = data[startvalue + 6];
            levelNumber7.text = startvalue + 7 + "";
        }
        else
            person7.text = "---";

        if (data.Count >= startvalue + 8)
        {
            person8.text = data[startvalue + 7];
            levelNumber8.text = startvalue + 8 + "";
        }
        else
            person8.text = "---";

        if (data.Count >= startvalue + 9) { 
            person9.text = data[startvalue + 8];
            levelNumber9.text = startvalue + 9 + "";
        }
        else
            person9.text = "---";

        if (data.Count >= startvalue + 10) { 
            person10.text = data[startvalue + 9];
            levelNumber10.text = startvalue + 10 + "";
        }
        else
            person10.text = "---";
    }
}
