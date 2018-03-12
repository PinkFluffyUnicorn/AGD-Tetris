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


    //Important, never delete! http://dreamlo.com/lb/AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A
    //Private Code: Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Public Code: 5a954aea39992d09e4eef691
    const string privateCode = "AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A";
    const string publicCode = "5a956d5739992d09e4ef40b0";
    const string webURL = "http://dreamlo.com/lb/";

    // Use this for initialization
    void Start () {
        StartCoroutine(uploadUsernameToOnlineDatabase());
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
            StartCoroutine(checkUsernameInOnlineDatabase());
        }
    }

    IEnumerator checkUsernameInOnlineDatabase()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/" + WWW.EscapeURL(PlayerPrefs.GetString("Username")));
        yield return www;

        string realLevelNumber = levelNumber.text;
        realLevelNumber = realLevelNumber.Substring(6);

        if (string.IsNullOrEmpty(www.error))
        {
            print(www.text);
            string[] downloads = www.text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> results = new List<string>();
            for (int i = 0; i < downloads.Length; i++)
            {
                string[] pipeCut = downloads[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                if (realLevelNumber == pipeCut[0].Substring(Math.Max(0, pipeCut[0].Length - 1)))
                    results.Add(pipeCut[1] + " " + pipeCut[0].Remove(pipeCut[0].Length - 1, 1));//TODO: change to split at _
            }
            if (results.Count >= 1)
                first.text = results[0];
            if (results.Count >= 2)
                second.text = results[1];
            if (results.Count >= 3)
                third.text = results[2];

        }
        else
        {
            print("Upload Error: " + www.error);
            //TODO: put my own score first
        }

    }
}
