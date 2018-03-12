using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadHighscores : MonoBehaviour {

    List<List<HighscoreEntery>> allHighscores; //list of lists of all highscores in a level
    List<HighscoreEntery> allOverallHighscores; //list of the combined highscores of all Players //maybe save overall highscores in level[0]

    //Important, never delete! http://dreamlo.com/lb/AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A
    //Private Code: Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Public Code: 5a954aea39992d09e4eef691
    const string privateCode = "AeuoLJscsEaYq3tKbd2xNAHRAWjegmS0WKnD39Wdex_A";
    const string publicCode = "5a956d5739992d09e4ef40b0";
    const string webURL = "http://dreamlo.com/lb/";

    // Use this for initialization
    void Start () {
        allHighscores = new List<List<HighscoreEntery>>();
        for (int i = 0; i < 41; i++)//40 for all 40 levels
            allHighscores.Add(new List<HighscoreEntery>());

        StartCoroutine(downloadHighscores());

    }
	
	// Update is called once per frame
	void Update () {

    }
    IEnumerator downloadHighscores()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/" + WWW.EscapeURL(PlayerPrefs.GetString("Username")));
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            print(www.text);
            string[] downloads = www.text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < downloads.Length; i++)
            {
                string[] pipeCut = downloads[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                if(pipeCut.Length >= 3)
                {
                    //add highscores in allHighscores
                    HighscoreEntery entery = new HighscoreEntery();
                    string[] usernameCut = pipeCut[0].Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
                    entery.username = usernameCut[usernameCut.Length-2];
                    entery.level = Int32.Parse(usernameCut[usernameCut.Length - 1]);
                    entery.highscore = Int32.Parse(pipeCut[1]);
                    allHighscores[entery.level].Add(entery);
                }

            }

            for (int i = 0; i < allHighscores.Count; i++)
            {
                for (int j = 0; j < allHighscores[i].Count; j++)
                {
                    print(allHighscores[i][j].username + " " + allHighscores[i][j].level + " " + allHighscores[i][j].highscore + " i=" + i + " j=" + j);
                }
            }
        }
        else
        {
            print("Upload Error: " + www.error);
            //TODO: put my own score first
        }

    }

    public List<string> getHighscores(int levelNumber)
    {
        List<string> highscoresSingleLevel = new List<string>();

        foreach(HighscoreEntery h in allHighscores[levelNumber])
        {
            highscoresSingleLevel.Add(h.username + " " + h.highscore);
            print(levelNumber + h.username + " " + h.highscore);
        }

        return highscoresSingleLevel;
    }

}

public struct HighscoreEntery
{
    public string username;
    public int level;
    public int highscore;
}