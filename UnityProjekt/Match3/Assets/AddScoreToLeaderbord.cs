using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class AddScoreToLeaderbord : MonoBehaviour {

    public Text levelNumber;
    public Text highscore;

    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public Text firstNumber;
    public Text secondNumber;
    public Text thirdNumber;
    public Text fourthNumber;


    public GameObject highscoreHandler;
    int enterysInTable = 4;

    static int usernameAt = 0;
    static int dataAt = 1;

    //Important, never delete! http://dreamlo.com/lb/AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A
    //Private Code: Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Public Code: 5a954aea39992d09e4eef691
    const string privateCode = "AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A";
    const string publicCode = "5a956d5739992d09e4ef40b0";
    const string webURL = "http://dreamlo.com/lb/";

    // Use this for initialization
    void Start () {
        AllmightyTrackerScript.allmightyTracker.writeToFile("game won " + levelNumber.text); //in das script das ein spiel gewonnen wurde
        List<string> data = highscoreHandler.GetComponent<DownloadHighscores>().getHighscores(Int32.Parse(levelNumber.text.Substring(6)));
        bool includet = false;
        for (int i = 0; i < data.Count; i++)//somewhere in the middle
        {
            if (data[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[usernameAt].Equals(PlayerPrefs.GetString("Username"))) {
                includet = true;
                if(Int32.Parse(data[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[dataAt]) < Int32.Parse(highscore.text))
                {
                    AllmightyTrackerScript.allmightyTracker.writeToFile("new highscore "+ levelNumber.text); //in das script das einneuer highscore erreicht wurde
                    data[i] = (PlayerPrefs.GetString("Username") + " " + highscore.text);
                    print(PlayerPrefs.GetString("Username") + " " + highscore.text);
                    listBubbleSort(data);
                    StartCoroutine(uploadUsernameToOnlineDatabase());
                    break;
                }
            }
        }

        if (!includet)
        {
            data.Add(PlayerPrefs.GetString("Username") + " " + highscore.text);
            listBubbleSort(data);
            StartCoroutine(uploadUsernameToOnlineDatabase());
        }

        for (int i = 0; i < data.Count; i++)//somewhere in the middle
        {
            if (data[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[usernameAt].Equals(PlayerPrefs.GetString("Username")))
            {
                if (i <= Mathf.FloorToInt((float)enterysInTable / 2f) || data.Count < enterysInTable)//higher
                    fillTable(data, 0);
                else if (i >= (data.Count - Mathf.FloorToInt((float)enterysInTable / 2f)))//smaller
                    fillTable(data, i + 1 - enterysInTable);
                else//in the middle
                    fillTable(data, i - Mathf.FloorToInt((float)enterysInTable / 2f));
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator uploadUsernameToOnlineDatabase()
    {
        string realLevelNumber = levelNumber.text;
        realLevelNumber = realLevelNumber.Substring(6);
        string realHighScore = highscore.text;
        realHighScore = realHighScore.Replace(" ", "");
        //TODO: just replace the highscore when its actually higher
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(PlayerPrefs.GetString("Username")) + "_"+ realLevelNumber+ "/" + realHighScore);//all scores are 1
        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            print(www.error);
            //TODO: what error messages can occure? what if the user is offline?
        }
        else
        {
            //StartCoroutine(checkUsernameInOnlineDatabase());
        }
    }

    void fillTable(List<string> data, int startvalue)
    {
        if (data.Count >= startvalue + 1)
        {
            first.text = data[startvalue + 0];
            firstNumber.text = "" + (startvalue + 1);
        }
        else
            first.text = "---";

        if (data.Count >= startvalue + 2)
        {
            print(data[startvalue + 1]);
            print(startvalue + 2);
            second.text = data[startvalue + 1];
            secondNumber.text = "" + (startvalue + 2);
        }
        else
            second.text = "---";

        if (data.Count >= startvalue + 3)
        {
            third.text = data[startvalue + 2];
            thirdNumber.text = "" + (startvalue + 3);
        }
        else
            third.text = "---";
        if (data.Count >= startvalue + 4)
        {
            fourth.text = data[startvalue + 3];
            fourthNumber.text = "" + (startvalue + 4);
        }
        else
            fourth.text = "---";
    }

    static void listBubbleSort(List<string> data)
    {
        int i, j;
        int N = data.Count;

        for (j = N - 1; j > 0; j--)
        {
            for (i = 0; i < j; i++)
            {
                print(i + 1 + " "+ data.Count + " "+ data[i + 1]);
                print(data[i + 1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
                if (Int32.Parse(data[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[dataAt]) < Int32.Parse(data[i + 1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[dataAt]))
                    exchange(data, i, i + 1);
            }
        }
    }

    static void exchange(List<string> data, int m, int n)
    {
        string temporary;

        temporary = data[m];
        data[m] = data[n];
        data[n] = temporary;
    }
}
