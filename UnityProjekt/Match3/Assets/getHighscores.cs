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

    public Text firstNumber;
    public Text secondNumber;
    public Text thirdNumber;

    public Text levelNumber;
    public string oldLevelNumber = "";

    public GameObject highscoreHandler;

    int enterysInTable = 3;


    //Important, never delete! http://dreamlo.com/lb/AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A
    //Private Code: Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Public Code: 5a954aea39992d09e4eef691
    const string privateCode = "AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A";
    const string publicCode = "5a956d5739992d09e4ef40b0";
    const string webURL = "http://dreamlo.com/lb/";

    // Use this for initialization
    void Start()
    {
        oldLevelNumber = levelNumber.text;
    }

    void OnEnable()
    {
        //StartCoroutine(checkUsernameInOnlineDatabase()); //TODO: delete maybe
    }

    void OnDisable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (oldLevelNumber != levelNumber.text)
        {
            List<string> data = highscoreHandler.GetComponent<DownloadHighscores>().getHighscores(Int32.Parse(levelNumber.text.Substring(6)));
            bool matched = false;
            for (int i = 0; i < data.Count; i++)//somewhere in the middle
            {
                if (data[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0].Equals(PlayerPrefs.GetString("Username")))
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
            if (!matched)
                fillTable(data, 0);
        }
        oldLevelNumber = levelNumber.text;
    }

    void fillTable(List<string> data, int startvalue)
    {
        if (data.Count >= startvalue + 1)
        {
            first.text = data[startvalue + 0];
            firstNumber.text = ""+(startvalue + 1);
        }
        else
            first.text = "---";

        if (data.Count >= startvalue + 2)
        {
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
    }
}
