﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallangeHandlerScript : MonoBehaviour {

    public GameObject challange1Done;
    public GameObject challange2Done;
    public GameObject challange3Done;

    public Text challange1Description;
    public Text challange2Description;
    public Text challange3Description;

    //public Image challange1Image, challange2Image, challange3Image;

    public Image C1BlueToken, C1ColorBomb, C1GreenToken, C1Ingridient1Token, C1Ingridient2Token, C1OrangeToken, C1PurpleToken, C1RedToken, C1Stone1Token, C1Stone2Token, C1YellowToken, C1Coockie1Token, C1Coockie2Token, C1BombToken, C1HorizontalBombToken, C1VerticalBombToken, C1GamesWonToken, C1GamesStartedToken;
    public Image C2BlueToken, C2ColorBomb, C2GreenToken, C2Ingridient1Token, C2Ingridient2Token, C2OrangeToken, C2PurpleToken, C2RedToken, C2Stone1Token, C2Stone2Token, C2YellowToken, C2Coockie1Token, C2Coockie2Token, C2BombToken, C2HorizontalBombToken, C2VerticalBombToken, C2GamesWonToken, C2GamesStartedToken;
    public Image C3BlueToken, C3ColorBomb, C3GreenToken, C3Ingridient1Token, C3Ingridient2Token, C3OrangeToken, C3PurpleToken, C3RedToken, C3Stone1Token, C3Stone2Token, C3YellowToken, C3Coockie1Token, C3Coockie2Token, C3BombToken, C3HorizontalBombToken, C3VerticalBombToken, C3GamesWonToken, C3GamesStartedToken;

    public GameObject moneyHandler;

    List<Challange> allChallanges;

    Challange Challange1 = new Challange();
    Challange Challange2 = new Challange();
    Challange Challange3 = new Challange();
    Challange Challange4 = new Challange();
    Challange Challange5 = new Challange();
    Challange Challange6 = new Challange();
    Challange Challange7 = new Challange();
    Challange Challange8 = new Challange();
    Challange Challange9 = new Challange();
    Challange Challange10 = new Challange();
    Challange Challange11 = new Challange();
    Challange Challange12 = new Challange();
    Challange Challange13 = new Challange();
    Challange Challange14 = new Challange();
    Challange Challange15 = new Challange();
    Challange Challange16 = new Challange();
    Challange Challange17 = new Challange();
    Challange Challange18 = new Challange();

    Challange currentChallange1 = new Challange();
    Challange currentChallange2 = new Challange();
    Challange currentChallange3 = new Challange();
    // Use this for initialization
    void Start () {

        //initialize all the challanges here
        print("initializeNewChallanges");
        initializeNewChallanges();
        allChallanges = new List<Challange> { Challange1, Challange2, Challange3, Challange4, Challange5, Challange6, Challange7, Challange8, Challange9, Challange10, Challange11, Challange12, Challange13, Challange14, Challange15, Challange16, Challange17, Challange18 };

        print("initializeCurrentChallanges");
        //fill old challanges
        initializeCurrentChallanges();
        print("Challange1: "+currentChallange1.Description + " Done: " +currentChallange1.done+" count: "+currentChallange1.count+" startValue: "+currentChallange1.startValue);

        print("checkIfChallangeIsDone");
        //check if challange was complete. if so, generate a new one
        checkIfChallangeIsDone();
        print("updatePlayerPrefs");
        //update playerPrefs
        updateCurrentChallanges();
        print("updateGui");
        //update the challanges gui
        updateChallangesGui();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
    void initializeNewChallanges()
    {
        //TODO: randomize goal and reward
        Challange1.PlayerPrefsId = "BlueTokenDestroyd";
        Challange1.goal = 1;
        Challange1.count = 0;
        Challange1.startValue = PlayerPrefs.GetInt(Challange1.PlayerPrefsId);
        Challange1.Description = "Destroy " + Challange1.goal + " blue Stones!";
        Challange1.id = 0;
        Challange1.reward = 1;
        Challange1.done = 0;

        Challange3.PlayerPrefsId = "ColorBombDestroyd";
        Challange3.goal = 1;
        Challange3.count = 0;
        Challange3.startValue = PlayerPrefs.GetInt(Challange3.PlayerPrefsId);
        Challange3.Description = "Destroy " + Challange3.goal + " color Bombs!";
        Challange3.id = 2;
        Challange3.reward = 1;
        Challange3.done = 0;

        Challange4.PlayerPrefsId = "GreenTokenDestroyd";
        Challange4.goal = 1;
        Challange4.count = 0;
        Challange4.startValue = PlayerPrefs.GetInt(Challange4.PlayerPrefsId);
        Challange4.Description = "Destroy " + Challange4.goal + " green Stones!";
        Challange4.id = 3;
        Challange4.reward = 1;
        Challange4.done = 0;

        Challange5.PlayerPrefsId = "Ingridient1Destroyd";
        Challange5.goal = 1;
        Challange5.count = 0;
        Challange5.startValue = PlayerPrefs.GetInt(Challange5.PlayerPrefsId);
        Challange5.Description = "Destroy " + Challange5.goal + " kiwis!";
        Challange5.id = 4;
        Challange5.reward = 1;
        Challange5.done = 0;

        Challange6.PlayerPrefsId = "Ingridient2Destroyd";
        Challange6.goal = 1;
        Challange6.count = 0;
        Challange6.startValue = PlayerPrefs.GetInt(Challange6.PlayerPrefsId);
        Challange6.Description = "Destroy " + Challange6.goal + " strawberrys!";
        Challange6.id = 5;
        Challange6.reward = 1;
        Challange6.done = 0;

        Challange7.PlayerPrefsId = "OrangeTokenDestroyd";
        Challange7.goal = 1;
        Challange7.count = 0;
        Challange7.startValue = PlayerPrefs.GetInt(Challange7.PlayerPrefsId);
        Challange7.Description = "Destroy " + Challange7.goal + " orange Stones!";
        Challange7.id = 6;
        Challange7.reward = 1;
        Challange7.done = 0;

        Challange8.PlayerPrefsId = "PurpleTokenDestroyd";
        Challange8.goal = 1;
        Challange8.count = 0;
        Challange8.startValue = PlayerPrefs.GetInt(Challange8.PlayerPrefsId);
        Challange8.Description = "Destroy " + Challange8.goal + " purple Stones!";
        Challange8.id = 7;
        Challange8.reward = 1;
        Challange8.done = 0;

        Challange9.PlayerPrefsId = "RedTokenDestroyd";
        Challange9.goal = 1;
        Challange9.count = 0;
        Challange9.startValue = PlayerPrefs.GetInt(Challange9.PlayerPrefsId);
        Challange9.Description = "Destroy " + Challange9.goal + " red Stones!";
        Challange9.id = 8;
        Challange9.reward = 1;
        Challange9.done = 0;

        Challange10.PlayerPrefsId = "Stone1Destroyd";
        Challange10.goal = 1;
        Challange10.count = 0;
        Challange10.startValue = PlayerPrefs.GetInt(Challange10.PlayerPrefsId);
        Challange10.Description = "Destroy " + Challange10.goal + " Stones!";
        Challange10.id = 9;
        Challange10.reward = 1;
        Challange10.done = 0;

        Challange11.PlayerPrefsId = "YellowTokenDestroyd";
        Challange11.goal = 1;
        Challange11.count = 0;
        Challange11.startValue = PlayerPrefs.GetInt(Challange11.PlayerPrefsId);
        Challange11.Description = "Destroy " + Challange11.goal + " yellow Stones!";
        Challange11.id = 10;
        Challange11.reward = 1;
        Challange11.done = 0;

        Challange12.PlayerPrefsId = "Coockie1Destroyd";
        Challange12.goal = 1;
        Challange12.count = 0;
        Challange12.startValue = PlayerPrefs.GetInt(Challange12.PlayerPrefsId);
        Challange12.Description = "Destroy " + Challange12.goal + " yellow Coockies!";
        Challange12.id = 11;
        Challange12.reward = 1;
        Challange12.done = 0;

        Challange13.PlayerPrefsId = "Coockie2Destroyd";
        Challange13.goal = 1;
        Challange13.count = 0;
        Challange13.startValue = PlayerPrefs.GetInt(Challange13.PlayerPrefsId);
        Challange13.Description = "Destroy " + Challange13.goal + " orange Coockies!";
        Challange13.id = 12;
        Challange13.reward = 1;
        Challange13.done = 0;

        Challange14.PlayerPrefsId = "BombDestroyd";
        Challange14.goal = 1;
        Challange14.count = 0;
        Challange14.startValue = PlayerPrefs.GetInt(Challange14.PlayerPrefsId);
        Challange14.Description = "Destroy " + Challange14.goal + " Bombs!";
        Challange14.id = 13;
        Challange14.reward = 1;
        Challange14.done = 0;

        Challange15.PlayerPrefsId = "HorizontalBombDestroyd";
        Challange15.goal = 1;
        Challange15.count = 0;
        Challange15.startValue = PlayerPrefs.GetInt(Challange15.PlayerPrefsId);
        Challange15.Description = "Destroy " + Challange15.goal + " horizontal Bombs!";
        Challange15.id = 14;
        Challange15.reward = 1;
        Challange15.done = 0;

        Challange16.PlayerPrefsId = "VerticalBombDestroyd";
        Challange16.goal = 1;
        Challange16.count = 0;
        Challange16.startValue = PlayerPrefs.GetInt(Challange16.PlayerPrefsId);
        Challange16.Description = "Destroy " + Challange16.goal + " vertical Bombs!";
        Challange16.id = 15;
        Challange16.reward = 1;
        Challange16.done = 0;

        Challange17.PlayerPrefsId = "GameWon";
        Challange17.goal = 1;
        Challange17.count = 0;
        Challange17.startValue = PlayerPrefs.GetInt(Challange17.PlayerPrefsId);
        Challange17.Description = "Win " + Challange17.goal + " Games!";
        Challange17.id = 16;
        Challange17.reward = 1;
        Challange17.done = 0;

        Challange18.PlayerPrefsId = "GameStarted";
        Challange18.goal = 1;
        Challange18.count = 0;
        Challange18.startValue = PlayerPrefs.GetInt(Challange18.PlayerPrefsId);
        Challange18.Description = "Play " + Challange18.goal + " Games!";
        Challange18.id = 17;
        Challange18.reward = 1;
        Challange18.done = 0;
    }

    void initializeCurrentChallanges()
    {
        currentChallange1.Description = PlayerPrefs.GetString("currentChallange1.Description");
        currentChallange1.PlayerPrefsId = PlayerPrefs.GetString("currentChallange1.PlayerPrefsId");
        currentChallange1.id = PlayerPrefs.GetInt("currentChallange1.id");
        currentChallange1.reward = PlayerPrefs.GetInt("currentChallange1.reward");
        currentChallange1.done = PlayerPrefs.GetInt("currentChallange1.done");
        currentChallange1.goal = PlayerPrefs.GetInt("currentChallange1.goal");
        currentChallange1.startValue = PlayerPrefs.GetInt("currentChallange1.startValue");
        currentChallange1.count = PlayerPrefs.GetInt(currentChallange1.PlayerPrefsId) - currentChallange1.startValue;

        currentChallange2.Description = PlayerPrefs.GetString("currentChallange2.Description");
        currentChallange2.PlayerPrefsId = PlayerPrefs.GetString("currentChallange2.PlayerPrefsId");
        currentChallange2.id = PlayerPrefs.GetInt("currentChallange2.id");
        currentChallange2.reward = PlayerPrefs.GetInt("currentChallange2.reward");
        currentChallange2.done = PlayerPrefs.GetInt("currentChallange2.done");
        currentChallange2.goal = PlayerPrefs.GetInt("currentChallange2.goal");
        currentChallange2.startValue = PlayerPrefs.GetInt("currentChallange2.startValue");
        currentChallange2.count = PlayerPrefs.GetInt(currentChallange2.PlayerPrefsId) - currentChallange2.startValue;

        currentChallange3.Description = PlayerPrefs.GetString("currentChallange3.Description");
        currentChallange3.PlayerPrefsId = PlayerPrefs.GetString("currentChallange3.PlayerPrefsId");
        currentChallange3.id = PlayerPrefs.GetInt("currentChallange3.id");
        currentChallange3.reward = PlayerPrefs.GetInt("currentChallange3.reward");
        currentChallange3.done = PlayerPrefs.GetInt("currentChallange3.done");
        currentChallange3.goal = PlayerPrefs.GetInt("currentChallange3.goal");
        currentChallange3.startValue = PlayerPrefs.GetInt("currentChallange3.startValue");
        currentChallange3.count = PlayerPrefs.GetInt(currentChallange3.PlayerPrefsId) - currentChallange3.startValue;
    }
    void updateCurrentChallanges()
    {
        PlayerPrefs.SetInt("currentChallange1.goal", currentChallange1.goal);
        PlayerPrefs.SetInt("currentChallange1.count", currentChallange1.count);
        PlayerPrefs.SetString("currentChallange1.Description", currentChallange1.Description);
        PlayerPrefs.SetString("currentChallange1.PlayerPrefsId", currentChallange1.PlayerPrefsId);
        PlayerPrefs.SetInt("currentChallange1.id", currentChallange1.id);
        PlayerPrefs.SetInt("currentChallange1.reward", currentChallange1.reward);
        PlayerPrefs.SetInt("currentChallange1.done", currentChallange1.done);

        PlayerPrefs.SetInt("currentChallange2.goal", currentChallange2.goal);
        PlayerPrefs.SetInt("currentChallange2.count", currentChallange2.count);
        PlayerPrefs.SetString("currentChallange2.Description", currentChallange2.Description);
        PlayerPrefs.SetString("currentChallange2.PlayerPrefsId", currentChallange2.PlayerPrefsId);
        PlayerPrefs.SetInt("currentChallange2.id", currentChallange2.id);
        PlayerPrefs.SetInt("currentChallange2.reward", currentChallange2.reward);
        PlayerPrefs.SetInt("currentChallange2.done", currentChallange2.done);

        PlayerPrefs.SetInt("currentChallange3.goal", currentChallange3.goal);
        PlayerPrefs.SetInt("currentChallange3.count", currentChallange3.count);
        PlayerPrefs.SetString("currentChallange3.Description", currentChallange3.Description);
        PlayerPrefs.SetString("currentChallange3.PlayerPrefsId", currentChallange3.PlayerPrefsId);
        PlayerPrefs.SetInt("currentChallange3.id", currentChallange3.id);
        PlayerPrefs.SetInt("currentChallange3.reward", currentChallange3.reward);
        PlayerPrefs.SetInt("currentChallange3.done", currentChallange3.done);
    }
    void checkIfChallangeIsDone()
    {
        //currentChallange1
        if(currentChallange1.done == 1)
        {
            //generate a new Challange
            currentChallange1 = allChallanges[generateNewChallangeId()];
        }
        if(currentChallange1.done == 0 && currentChallange1.goal <= currentChallange1.count)
        {
            //open popup for the player
            challange1Done.SetActive(true);
            //give the player his reward
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange1.reward);
            //generate new Challange
            currentChallange1 = allChallanges[generateNewChallangeId()];
        }

        //currentChallange2
        if (currentChallange2.done == 1)
        {
            //generate a new Challange
            currentChallange2 = allChallanges[generateNewChallangeId()];
        }
        if (currentChallange2.done == 0 && currentChallange2.goal <= currentChallange2.count)
        {
            //open popup for the player
            challange1Done.SetActive(true);
            //give the player his reward
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange2.reward);
            //generate new Challange
            currentChallange2 = allChallanges[generateNewChallangeId()];
        }

        //currentChallange3
        if (currentChallange3.done == 1)
        {
            //generate a new Challange
            currentChallange3 = allChallanges[generateNewChallangeId()];
        }
        if (currentChallange3.done == 0 && currentChallange3.goal <= currentChallange3.count)
        {
            //open popup for the player
            challange1Done.SetActive(true);
            //give the player his reward
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange3.reward);
            //generate new Challange
            currentChallange3 = allChallanges[generateNewChallangeId()];
        }
    }
    int generateNewChallangeId()
    {
        int rand = Random.Range(0, allChallanges.Count - 1);
        while(rand == currentChallange1.id || rand == currentChallange2.id || rand == currentChallange3.id)
        {
            rand = Random.Range(0, allChallanges.Count - 1);
        }
        return rand;
    }
    void updateChallangesGui()
    {
        //TODO: hier die Progressbar für alle hinzufügen
        //TODO: den Reward in der Gui setzen
        print("hi");
        challange1Description.text = currentChallange1.Description;
        switch (currentChallange1.PlayerPrefsId)
        {
            case "BlueTokenDestroyd": C1BlueToken.enabled = true; break;
            case "ColorBombDestroyd": C1ColorBomb.enabled = true; ; break;
            case "GreenTokenDestroyd": C1GreenToken.enabled = true; break;
            case "Ingridient1Destroyd": C1Ingridient1Token.enabled = true; break;
            case "Ingridient2Destroyd": C1Ingridient2Token.enabled = true; break;
            case "OrangeTokenDestroyd": C1OrangeToken.enabled = true; break;
            case "PurpleTokenDestroyd": C1PurpleToken.enabled = true; break;
            case "RedTokenDestroyd": C1RedToken.enabled = true; break;
            case "Stone1Destroyd": C1Stone1Token.enabled = true; break;
            case "Stone2Destroyd": C1Stone2Token.enabled = true; break;
            case "YellowTokenDestroyd": C1YellowToken.enabled = true; break;
            case "Coockie1Destroyd": C1Coockie1Token.enabled = true; break;
            case "Coockie2Destroyd": C1Coockie2Token.enabled = true; break;
            case "BombDestroyd": C1BombToken.enabled = true; break;
            case "HorizontalBombDestroyd": C1HorizontalBombToken.enabled = true; break;
            case "VerticalBombDestroyd": C1VerticalBombToken.enabled = true; break;
            case "GameWon": C1GamesWonToken.enabled = true; break;
            case "GameStarted": C1GamesStartedToken.enabled = true; break;
        }
        challange2Description.text = currentChallange2.Description;
        switch (currentChallange2.PlayerPrefsId)
        {
            case "BlueTokenDestroyd": C2BlueToken.enabled = true; break;
            case "ColorBombDestroyd": C2ColorBomb.enabled = true; break;
            case "GreenTokenDestroyd": C2GreenToken.enabled = true; break;
            case "Ingridient1Destroyd": C2Ingridient1Token.enabled = true; break;
            case "Ingridient2Destroyd": C2Ingridient2Token.enabled = true; break;
            case "OrangeTokenDestroyd": C2OrangeToken.enabled = true; break;
            case "PurpleTokenDestroyd": C2PurpleToken.enabled = true; break;
            case "RedTokenDestroyd": C2RedToken.enabled = true; break;
            case "Stone1Destroyd": C2Stone1Token.enabled = true; break;
            case "Stone2Destroyd": C2Stone2Token.enabled = true; break;
            case "YellowTokenDestroyd": C2YellowToken.enabled = true; break;
            case "Coockie1Destroyd": C2Coockie1Token.enabled = true; break;
            case "Coockie2Destroyd": C2Coockie2Token.enabled = true; break;
            case "BombDestroyd": C2BombToken.enabled = true; break;
            case "HorizontalBombDestroyd": C2HorizontalBombToken.enabled = true; break;
            case "VerticalBombDestroyd": C2VerticalBombToken.enabled = true; break;
            case "GameWon": C2GamesWonToken.enabled = true; break;
            case "GameStarted": C2GamesStartedToken.enabled = true; break;
        }
        challange3Description.text = currentChallange3.Description;
        switch (currentChallange3.PlayerPrefsId)
        {
            case "BlueTokenDestroyd": C3BlueToken.enabled = true; break;
            case "ColorBombDestroyd": C3ColorBomb.enabled = true; break;
            case "GreenTokenDestroyd": C3GreenToken.enabled = true; break;
            case "Ingridient1Destroyd": C3Ingridient1Token.enabled = true; break;
            case "Ingridient2Destroyd": C3Ingridient2Token.enabled = true; break;
            case "OrangeTokenDestroyd": C3OrangeToken.enabled = true; break;
            case "PurpleTokenDestroyd": C3PurpleToken.enabled = true; break;
            case "RedTokenDestroyd": C3RedToken.enabled = true; break;
            case "Stone1Destroyd": C3Stone1Token.enabled = true; break;
            case "Stone2Destroyd": C3Stone2Token.enabled = true; break;
            case "YellowTokenDestroyd": C3YellowToken.enabled = true; break;
            case "Coockie1Destroyd": C3Coockie1Token.enabled = true; break;
            case "Coockie2Destroyd": C3Coockie2Token.enabled = true; break;
            case "BombDestroyd": C3BombToken.enabled = true; break;
            case "HorizontalBombDestroyd": C3HorizontalBombToken.enabled = true; break;
            case "VerticalBombDestroyd": C3VerticalBombToken.enabled = true; break;
            case "GameWon": C3GamesWonToken.enabled = true; break;
            case "GameStarted": C3GamesStartedToken.enabled = true; break;
        }

    }
}

struct Challange
{
    public string Description;
    public string PlayerPrefsId;
    public int id; //index if allChallanges list
    public int count;
    public int startValue;
    public int goal;
    public int reward;
    public int done; //0 = false, 1 = true
}
