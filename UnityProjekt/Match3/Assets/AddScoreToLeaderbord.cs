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
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(PlayerPrefs.GetString("Username"))+ realLevelNumber + "/"+ realHighScore);//all scores are 1
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
        WWW www = new WWW(webURL + publicCode + "/quote/" + WWW.EscapeURL(PlayerPrefs.GetString("Username"))+"/3");
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            print(www.text);
            string[] enterys = www.text.Split(new[] {","}, StringSplitOptions.None);
            print(enterys.Length);
            if (enterys.Length >= 2)
                first.text = enterys[1] + " " + enterys[0];
            if (enterys.Length >= 4)
                second.text = enterys[3] + " " + enterys[2];
            if (enterys.Length >= 6)
                third.text = enterys[5] + " " + enterys[4];
        }
        else
        {
            print("Upload Error: " + www.error);
            //TODO: put my own score first
        }
            
    }
}
