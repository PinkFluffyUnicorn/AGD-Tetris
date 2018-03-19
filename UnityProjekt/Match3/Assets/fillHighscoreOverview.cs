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

    public Text buttonText;//TODO: set here
    public Text descriptionText; //TODO: setHere

    public GameObject highscoreDownloader;

    // Use this for initialization
    void Start () {
        List<string> data = highscoreDownloader.GetComponent<DownloadHighscores>().getOverallHighscores();

        for (int i = 0; i < data.Count; i++)//somewhere in the middle
        {
            if (data[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1] == PlayerPrefs.GetString("Username"))
            {
                if (i < (float)data.Count / 2f)
                    fillTable(data, 0);
                else if (i > (float)data.Count / 2f)
                    fillTable(data, data.Count - 1);
                else
                    fillTable(data, i - (int)((float)data.Count / 2f));
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void fillTable(List<string> data, int startvalue)
    {
        if (data.Count >= startvalue + 1)
            person1.text = data[startvalue + 0];
        else
            person1.text = "---";

        if (data.Count >= startvalue + 2)
            person2.text = data[startvalue + 1];
        else
            person2.text = "---";

        if (data.Count >= startvalue + 3)
            person3.text = data[startvalue + 2];
        else
            person3.text = "---";

        if (data.Count >= startvalue + 4)
            person4.text = data[startvalue + 3];
        else
            person4.text = "---";

        if (data.Count >= startvalue + 5)
            person5.text = data[startvalue + 4];
        else
            person5.text = "---";

        if (data.Count >= startvalue + 6)
            person6.text = data[startvalue + 5];
        else
            person6.text = "---";

        if (data.Count >= startvalue + 7)
            person7.text = data[startvalue + 6];
        else
            person7.text = "---";

        if (data.Count >= startvalue + 8)
            person8.text = data[startvalue + 7];
        else
            person8.text = "---";

        if (data.Count >= startvalue + 9)
            person9.text = data[startvalue + 8];
        else
            person9.text = "---";

        if (data.Count >= startvalue + 10)
            person10.text = data[startvalue + 9];
        else
            person10.text = "---";
    }
}
