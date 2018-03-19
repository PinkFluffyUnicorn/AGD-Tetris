using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadHighscores : MonoBehaviour {

    List<List<HighscoreEntery>> allHighscores; //list of lists of all highscores in a level

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
        }

        return highscoresSingleLevel;
    }

    public List<string> getOverallHighscores()
    {
        List<int> highscores = new List<int>();
        List<string> usernames = new List<string>();

        for (int i = 0; i < allHighscores.Count; i++)
        {
            for(int j = 0; j < allHighscores[i].Count; j++)
            {
                bool contained = false;
                for (int k = 0; k < usernames.Count; k++)
                {
                    if (string.Equals(usernames[k], allHighscores[i][j].username))
                    {
                        highscores[k] += allHighscores[i][j].highscore;
                        contained = true;
                    }
                        
                }
                if (!contained)
                {
                    usernames.Add(allHighscores[i][j].username);
                    highscores.Add(allHighscores[i][j].highscore);
                }
            }
        }

        for (int i = 0; i < highscores.Count; i++)
            usernames[i] = highscores[i]+ " " + usernames[i];
        listBubbleSort(usernames);
        return usernames;
    }

    static void listBubbleSort(List<string> data)
    {
        int i, j;
        int N = data.Count;

        for (j = N - 1; j > 0; j--)
        {
            for (i = 0; i < j; i++)
            {
                if (Int32.Parse(data[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]) < Int32.Parse(data[i + 1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]))
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

public struct HighscoreEntery
{
    public string username;
    public int level;
    public int highscore;
}