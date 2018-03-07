using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;


public class getHighscores : MonoBehaviour
{

    public Text first;
    public Text second;
    public Text third;

    public Text levelNumber;


    //Important, never delete! http://dreamlo.com/lb/AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A
    //Private Code: Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Public Code: 5a954aea39992d09e4eef691
    const string privateCode = "AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A";
    const string publicCode = "5a956d5739992d09e4ef40b0";
    const string webURL = "http://dreamlo.com/lb/";

    // Use this for initialization
    void Start()
    {

    }

    void OnEnable()
    {
        StartCoroutine(checkUsernameInOnlineDatabase());
    }

    void OnDisable()
    {
        first.text = "---";
        second.text = "---";
        third.text = "---";
    }

    // Update is called once per frame
    void Update()
    {

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
                    results.Add(pipeCut[1] + " " + pipeCut[0].Remove(pipeCut[0].Length - 1, 1));
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
