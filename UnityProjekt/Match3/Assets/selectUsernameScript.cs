using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectUsernameScript : MonoBehaviour {

    public Text inputText;
    public Text outputText;
    public GameObject popupToClose;

    //Important, never delete! http://dreamlo.com/lb/Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Private Code: Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg
    //Public Code: 5a954aea39992d09e4eef691
    const string privateCode = "Qn3LrCq6SEamAobzoPhYkw2thZBJFFN0qsFOVnZjZtdg";
    const string publicCode = "5a954aea39992d09e4eef691";
    const string webURL = "http://dreamlo.com/lb/";

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void selectPressed()
    {
        StartCoroutine(checkUsernameInOnlineDatabase(inputText.text)); //TODO: check if username vontains any _
    }
    IEnumerator uploadUsernameToOnlineDatabase(string username)
    {
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/1");//all scores are 1
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            PlayerPrefs.SetString("Username", username);
            popupToClose.SetActive(false);
        }
        else
            print("Upload Error: " + www.error);
    }

    IEnumerator checkUsernameInOnlineDatabase(string username)
    {
        WWW www = new WWW(webURL + publicCode + "/pipe-get/" + WWW.EscapeURL(username));
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            if (string.IsNullOrEmpty(www.text))
            {
                StartCoroutine(uploadUsernameToOnlineDatabase(username));
            }
            else
                outputText.text = "The Username " + username + " is already Taken!";
        }
        else
            print("Upload Error: " + www.error);
    }
}

public struct Highscore
{
    public string username;
    public int score;

    public Highscore(string _username, int _score)
    {
        username = _username;
        score = _score;
    }
}
