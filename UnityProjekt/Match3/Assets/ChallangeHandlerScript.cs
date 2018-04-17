using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallangeHandlerScript : MonoBehaviour {

    public GameObject challange1DonePopUp;
    public GameObject challange2DonePopUp;
    public GameObject challange3DonePopUp;

    public Text challange1Description;
    public Text challange2Description;
    public Text challange3Description;

    public Text Challenge1reward;
    public Text Challenge2reward;
    public Text Challenge3reward;

    public Slider Challenge1Slider;
    public Slider Challenge2Slider;
    public Slider Challenge3Slider;

    //public Image challange1Image, challange2Image, challange3Image;

    public Image C1BlueToken, C1ColorBomb, C1GreenToken, C1Ingridient1Token, C1Ingridient2Token, C1OrangeToken, C1PurpleToken, C1RedToken, C1Stone1Token, C1Stone2Token, C1YellowToken, C1Coockie1Token, C1Coockie2Token, C1BombToken, C1HorizontalBombToken, C1VerticalBombToken, C1GamesWonToken, C1GamesStartedToken;
    public Image C2BlueToken, C2ColorBomb, C2GreenToken, C2Ingridient1Token, C2Ingridient2Token, C2OrangeToken, C2PurpleToken, C2RedToken, C2Stone1Token, C2Stone2Token, C2YellowToken, C2Coockie1Token, C2Coockie2Token, C2BombToken, C2HorizontalBombToken, C2VerticalBombToken, C2GamesWonToken, C2GamesStartedToken;
    public Image C3BlueToken, C3ColorBomb, C3GreenToken, C3Ingridient1Token, C3Ingridient2Token, C3OrangeToken, C3PurpleToken, C3RedToken, C3Stone1Token, C3Stone2Token, C3YellowToken, C3Coockie1Token, C3Coockie2Token, C3BombToken, C3HorizontalBombToken, C3VerticalBombToken, C3GamesWonToken, C3GamesStartedToken;

    public GameObject moneyHandler;

    public GameObject challange1Done;
    public GameObject challange2Done;
    public GameObject challange3Done;

    public GameObject allChallangesDone;

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

    Challange currentChallange1 = new Challange();
    Challange currentChallange2 = new Challange();
    Challange currentChallange3 = new Challange();

    Challange oldChallange1 = new Challange();
    Challange oldChallange2 = new Challange();
    Challange oldChallange3 = new Challange();
    // Use this for initialization
    void Start () {

        initializeCurrentChallanges();

        int today = System.DateTime.Now.DayOfYear;
        int lastDay = PlayerPrefs.GetInt("ChallangeDate", 0);

        //lastDay = 0;
        if (today != lastDay)
        {
            currentChallange1.done = 1;
            currentChallange2.done = 1;
            currentChallange3.done = 1;
            PlayerPrefs.SetInt("Challenge1.Completed", 0);
            PlayerPrefs.SetInt("Challenge2.Completed", 0);
            PlayerPrefs.SetInt("Challenge3.Completed", 0);
            PlayerPrefs.SetInt("ChallangeDate", today);
            PlayerPrefs.SetInt("allChallangesDone", 0);

            //initialize all the challanges here
            initializeNewChallanges();
            allChallanges = new List<Challange> { Challange1, Challange2, Challange3, Challange4, Challange5, Challange6, Challange7, Challange8, Challange9, Challange10, Challange11, Challange12, Challange13, Challange14, Challange15, Challange16, Challange17 };

            //fill old challanges
            initializeCurrentChallanges();
            print("Challange1: " + currentChallange1.Description + " Done: " + currentChallange1.done + " count: " + currentChallange1.count + " startValue: " + currentChallange1.startValue);

            //check if challange was complete. if so, generate a new one
            checkIfChallangeIsDone();

            //update playerPrefs
            updateCurrentChallanges();
            
        }
        else
        {
            updateChallangesDone();
        }

        //update the challanges gui
        updateChallangesGui();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
    void initializeNewChallanges()
    {
         //t1 = all normal stones (blue, orange, yellow, 
        int t1Min = 12;
        int t1Max = 36;
        int t1Multiplicator = 1;

        //t2 horizontal/vertical Bombs 
        int t2Min = 3;
        int t2Max = 16;
        int t2Multiplicator = 2;

        //t3 normale bomben
        int t3Min = 2;
        int t3Max = 12;
        int t3Multiplicator = 3;

        //t4 Coockies 1 and 2
        int t4Min = 12;
        int t4Max = 36;
        int t4Multiplicator = 1;

        //t5 ingrediant 1 and 2
        int t5Min = 3;
        int t5Max = 6;
        int t5Multiplicator = 4;

        //t6 stone 1 and 2
        int t6Min = 5;
        int t6Max = 20;
        int t6Multiplicator = 2;

        //t7 games started
        int t7Min = 3;
        int t7Max = 12;
        int t7Multiplicator = 2;

        //t8 games won
        int t8Min = 2;
        int t8Max = 5;
        int t8Multiplicator = 5;

        //t9 colorBombs
        int t9Min = 1;
        int t9Max = 4;
        int t9Multiplicator = 5;

        //t10 chocklate
        int t10Min = 12;
        int t10Max = 25;
        int t10Multiplicator = 2;

        int randMin = 0;
        int randMax = 5;


	/**
	to sort the levels, first we need to know wicht tokans can appear from wich level

	Ab Level x geschafft.
	Level0:
	ALl Normal Tokens, Games Started, Games Won

	Level 1
	Horizontal/Vertical Bombs, normal Bombs

	Level 3 
	FlowerBomb

	Level 6
	Yellow Coockies

	Level 9
	Orange Coockies

	Level 26
	Chocklate

	Level 13 //wenn Wall = Stone
	Stone1

	Level 27
	Ingrediant 1/2/3
	*/        

//Level 0 - 0 - 7
        Challange1.PlayerPrefsId = "GameWon";
        Challange1.goal = Random.Range(t8Min, t8Max);
        Challange1.count = 0;//PlayerPrefs.GetInt(Challange1.PlayerPrefsId);
        Challange1.startValue = PlayerPrefs.GetInt(Challange1.PlayerPrefsId);
        Challange1.Description = "Win " + Challange1.goal + " Games!";
        Challange1.id = 0;
        Challange1.reward = (Challange1.goal * t8Multiplicator) + Random.Range(randMin, randMax);
        Challange1.done = 0;

        Challange2.PlayerPrefsId = "GameStarted";
        Challange2.goal = Random.Range(t7Min, t7Max);
        Challange2.count = 0;//PlayerPrefs.GetInt(Challange2.PlayerPrefsId);
        Challange2.startValue = PlayerPrefs.GetInt(Challange2.PlayerPrefsId);
        Challange2.Description = "Play " + Challange2.goal + " Games!";
        Challange2.id = 1;
        Challange2.reward = (Challange2.goal * t7Multiplicator) + Random.Range(randMin, randMax);
        Challange2.done = 0;

	    Challange3.PlayerPrefsId = "BlueTokenDestroyd";
        Challange3.goal = Random.Range(t1Min, t1Max);
        Challange3.count = 0;//PlayerPrefs.GetInt(Challange3.PlayerPrefsId);
        Challange3.startValue = PlayerPrefs.GetInt(Challange3.PlayerPrefsId);
        Challange3.Description = "Destroy " + Challange3.goal + " blue Stones!";
        Challange3.id = 2;
        Challange3.reward = (Challange3.goal * t1Multiplicator) + Random.Range(randMin, randMax);
        Challange3.done = 0;

        Challange4.PlayerPrefsId = "GreenTokenDestroyd";
        Challange4.goal = Random.Range(t1Min, t1Max);
        Challange4.count = 0;//PlayerPrefs.GetInt(Challange4.PlayerPrefsId);
        Challange4.startValue = PlayerPrefs.GetInt(Challange4.PlayerPrefsId);
        Challange4.Description = "Destroy " + Challange4.goal + " green Stones!";
        Challange4.id = 3;
        Challange4.reward = (Challange4.goal * t1Multiplicator) + Random.Range(randMin, randMax);
        Challange4.done = 0;

        Challange5.PlayerPrefsId = "OrangeTokenDestroyd";
        Challange5.goal = Random.Range(t1Min, t1Max);
        Challange5.count = 0;//PlayerPrefs.GetInt(Challange5.PlayerPrefsId);
        Challange5.startValue = PlayerPrefs.GetInt(Challange5.PlayerPrefsId);
        Challange5.Description = "Destroy " + Challange5.goal + " orange Stones!";
        Challange5.id = 4;
        Challange5.reward = (Challange5.goal * t1Multiplicator) + Random.Range(randMin, randMax);
        Challange5.done = 0;

        Challange6.PlayerPrefsId = "PurpleTokenDestroyd";
        Challange6.goal = Random.Range(t1Min, t1Max);
        Challange6.count = 0;//PlayerPrefs.GetInt(Challange6.PlayerPrefsId);
        Challange6.startValue = PlayerPrefs.GetInt(Challange6.PlayerPrefsId);
        Challange6.Description = "Destroy " + Challange6.goal + " purple Stones!";
        Challange6.id = 5;
        Challange6.reward = (Challange6.goal * t1Multiplicator) + Random.Range(randMin, randMax);
        Challange6.done = 0;

        Challange7.PlayerPrefsId = "RedTokenDestroyd";
        Challange7.goal = Random.Range(t1Min, t1Max);
        Challange7.count = 0;//PlayerPrefs.GetInt(Challange7.PlayerPrefsId);
        Challange7.startValue = PlayerPrefs.GetInt(Challange7.PlayerPrefsId);
        Challange7.Description = "Destroy " + Challange7.goal + " red Stones!";
        Challange7.id = 6;
        Challange7.reward = (Challange7.goal * t1Multiplicator) + Random.Range(randMin, randMax);
        Challange7.done = 0;

        Challange8.PlayerPrefsId = "YellowTokenDestroyd";
        Challange8.goal = Random.Range(t1Min, t1Max);
        Challange8.count = 0;//PlayerPrefs.GetInt(Challange8.PlayerPrefsId);
        Challange8.startValue = PlayerPrefs.GetInt(Challange8.PlayerPrefsId);
        Challange8.Description = "Destroy " + Challange8.goal + " yellow Stones!";
        Challange8.id = 7;
        Challange8.reward = (Challange8.goal * t1Multiplicator) + Random.Range(randMin, randMax);
        Challange8.done = 0;


//Level 1
        Challange9.PlayerPrefsId = "BombDestroyd";
        Challange9.goal = Random.Range(t3Min, t3Max);
        Challange9.count = 0;//PlayerPrefs.GetInt(Challange9.PlayerPrefsId);
        Challange9.startValue = PlayerPrefs.GetInt(Challange9.PlayerPrefsId);
        Challange9.Description = "Destroy " + Challange9.goal + " Bombs!";
        Challange9.id = 8;
        Challange9.reward = (Challange9.goal * t3Multiplicator) + Random.Range(randMin, randMax);
        Challange9.done = 0;

        Challange10.PlayerPrefsId = "HorizontalBombDestroyd";
        Challange10.goal = Random.Range(t2Min, t2Max);
        Challange10.count = 0;//PlayerPrefs.GetInt(Challange10.PlayerPrefsId);
        Challange10.startValue = PlayerPrefs.GetInt(Challange10.PlayerPrefsId);
        Challange10.Description = "Destroy " + Challange10.goal + " horizontal Bombs!";
        Challange10.id = 9;
        Challange10.reward = (Challange10.goal * t2Multiplicator) + Random.Range(randMin, randMax);
        Challange10.done = 0;

        Challange11.PlayerPrefsId = "VerticalBombDestroyd";
        Challange11.goal = Random.Range(t2Min, t2Max);
        Challange11.count = 0;//PlayerPrefs.GetInt(Challange11.PlayerPrefsId);
        Challange11.startValue = PlayerPrefs.GetInt(Challange11.PlayerPrefsId);
        Challange11.Description = "Destroy " + Challange11.goal + " vertical Bombs!";
        Challange11.id = 10;
        Challange11.reward = (Challange11.goal * t2Multiplicator) + Random.Range(randMin, randMax);
        Challange11.done = 0;

//Level 3
        Challange12.PlayerPrefsId = "ColorBombDestroyd";
        Challange12.goal = Random.Range(t9Min, t9Max);
        Challange12.count = 0;//PlayerPrefs.GetInt(Challange12.PlayerPrefsId);
        Challange12.startValue = PlayerPrefs.GetInt(Challange12.PlayerPrefsId);
        Challange12.Description = "Destroy " + Challange12.goal + " color Bombs!";
        Challange12.id = 11;
        Challange12.reward = (Challange12.goal * t9Multiplicator) + Random.Range(randMin, randMax);
        Challange12.done = 0;

//Level 6
        Challange13.PlayerPrefsId = "Coockie1Destroyd";
        Challange13.goal = Random.Range(t4Min, t4Max);
        Challange13.count = 0;//PlayerPrefs.GetInt(Challange13.PlayerPrefsId);
        Challange13.startValue = PlayerPrefs.GetInt(Challange13.PlayerPrefsId);
        Challange13.Description = "Destroy " + Challange13.goal + " yellow Cookies!";
        Challange13.id = 12;
        Challange13.reward = (Challange13.goal * t4Multiplicator) + Random.Range(randMin, randMax);
        Challange13.done = 0;

//Level 9
        Challange14.PlayerPrefsId = "Coockie2Destroyd";
        Challange14.goal = Random.Range(t4Min, t4Max);
        Challange14.count = 0;//PlayerPrefs.GetInt(Challange14.PlayerPrefsId);
        Challange14.startValue = PlayerPrefs.GetInt(Challange14.PlayerPrefsId);
        Challange14.Description = "Destroy " + Challange14.goal + " orange Cookies!";
        Challange14.id = 13;
        Challange14.reward = (Challange14.goal * t4Multiplicator) + Random.Range(randMin, randMax);
        Challange14.done = 0;

//Level 13
        Challange15.PlayerPrefsId = "Stone1Destroyd";
        Challange15.goal = Random.Range(t6Min, t6Max);
        Challange15.count = 0;//PlayerPrefs.GetInt(Challange15.PlayerPrefsId);
        Challange15.startValue = PlayerPrefs.GetInt(Challange15.PlayerPrefsId);
        Challange15.Description = "Destroy " + Challange15.goal + " Stones!";
        Challange15.id = 14;
        Challange15.reward = (Challange15.goal * t6Multiplicator) + Random.Range(randMin, randMax);
        Challange15.done = 0;

////Level 26
//        Challange16.PlayerPrefsId = "ChocklateDestroyd";
//        Challange16.goal = Random.Range(t10Min, t10Max);
//        Challange16.count = 0;
//        Challange16.startValue = PlayerPrefs.GetInt(Challange16.PlayerPrefsId);
//        Challange16.Description = "Destroy " + Challange16.goal + " blue Stones!";
//        Challange16.id = 0;
//        Challange16.reward = (Challange16.goal * t10Multiplicator) + Random.Range(randMin, randMax);
//        Challange16.done = 0;

//Level 27
        Challange16.PlayerPrefsId = "Ingridient1Destroyd";
        Challange16.goal = Random.Range(t5Min, t5Max);
        Challange16.count = 0;//PlayerPrefs.GetInt(Challange16.PlayerPrefsId);
        Challange16.startValue = PlayerPrefs.GetInt(Challange16.PlayerPrefsId);
        Challange16.Description = "Destroy " + Challange16.goal + " kiwis!";
        Challange16.id = 15;
        Challange16.reward = (Challange16.goal * t5Multiplicator) + Random.Range(randMin, randMax);
        Challange16.done = 0;

        Challange17.PlayerPrefsId = "Ingridient2Destroyd";
        Challange17.goal = Random.Range(t5Min, t5Max);
        Challange17.count = 0;//PlayerPrefs.GetInt(Challange17.PlayerPrefsId);
        Challange17.startValue = PlayerPrefs.GetInt(Challange17.PlayerPrefsId);
        Challange17.Description = "Destroy " + Challange17.goal + " strawberrys!";
        Challange17.id = 16;
        Challange17.reward = (Challange17.goal * t5Multiplicator) + Random.Range(randMin, randMax);
        Challange17.done = 0;
        //max Challange = 17
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
        print("Challange1 current:" + currentChallange1.count + "start: " + currentChallange1.startValue + "goal " + currentChallange1.goal);


        currentChallange2.Description = PlayerPrefs.GetString("currentChallange2.Description");
        currentChallange2.PlayerPrefsId = PlayerPrefs.GetString("currentChallange2.PlayerPrefsId");
        currentChallange2.id = PlayerPrefs.GetInt("currentChallange2.id");
        currentChallange2.reward = PlayerPrefs.GetInt("currentChallange2.reward");
        currentChallange2.done = PlayerPrefs.GetInt("currentChallange2.done");
        currentChallange2.goal = PlayerPrefs.GetInt("currentChallange2.goal");
        currentChallange2.startValue = PlayerPrefs.GetInt("currentChallange2.startValue");
        currentChallange2.count = PlayerPrefs.GetInt(currentChallange2.PlayerPrefsId) - currentChallange2.startValue;
        print("Challange2 current:" + currentChallange2.count + "start: " + currentChallange2.startValue + "goal " + currentChallange2.goal);


        currentChallange3.Description = PlayerPrefs.GetString("currentChallange3.Description");
        currentChallange3.PlayerPrefsId = PlayerPrefs.GetString("currentChallange3.PlayerPrefsId");
        currentChallange3.id = PlayerPrefs.GetInt("currentChallange3.id");
        currentChallange3.reward = PlayerPrefs.GetInt("currentChallange3.reward");
        currentChallange3.done = PlayerPrefs.GetInt("currentChallange3.done");
        currentChallange3.goal = PlayerPrefs.GetInt("currentChallange3.goal");
        currentChallange3.startValue = PlayerPrefs.GetInt("currentChallange3.startValue");
        currentChallange3.count = PlayerPrefs.GetInt(currentChallange3.PlayerPrefsId) - currentChallange3.startValue;
        print("Challange3 current:" + currentChallange3.count + "start: "+ currentChallange3.startValue + "goal " + currentChallange3.goal);



        //testing
        //currentChallange1.done = 1;
        //currentChallange2.done = 1;
        //currentChallange3.done = 1;
    }

    void updateCurrentChallanges()
    {
        PlayerPrefs.SetInt("currentChallange1.goal", currentChallange1.goal);
        PlayerPrefs.SetString("currentChallange1.PlayerPrefsId", currentChallange1.PlayerPrefsId);
        PlayerPrefs.SetInt("currentChallange1.count", currentChallange1.count);//prev: currentChallange1.count
        PlayerPrefs.SetString("currentChallange1.Description", currentChallange1.Description);
        PlayerPrefs.SetInt("currentChallange1.id", currentChallange1.id);
        PlayerPrefs.SetInt("currentChallange1.reward", currentChallange1.reward);
        PlayerPrefs.SetInt("currentChallange1.done", currentChallange1.done);
        PlayerPrefs.SetInt("currentChallange1.startValue", currentChallange1.startValue);

        PlayerPrefs.SetInt("currentChallange2.goal", currentChallange2.goal);
        PlayerPrefs.SetInt("currentChallange2.count", currentChallange2.count);
        PlayerPrefs.SetString("currentChallange2.Description", currentChallange2.Description);
        PlayerPrefs.SetString("currentChallange2.PlayerPrefsId", currentChallange2.PlayerPrefsId);
        PlayerPrefs.SetInt("currentChallange2.id", currentChallange2.id);
        PlayerPrefs.SetInt("currentChallange2.reward", currentChallange2.reward);
        PlayerPrefs.SetInt("currentChallange2.done", currentChallange2.done);
        PlayerPrefs.SetInt("currentChallange2.startValue", currentChallange2.startValue);

        PlayerPrefs.SetInt("currentChallange3.goal", currentChallange3.goal);
        PlayerPrefs.SetInt("currentChallange3.count", currentChallange3.count);
        PlayerPrefs.SetString("currentChallange3.Description", currentChallange3.Description);
        PlayerPrefs.SetString("currentChallange3.PlayerPrefsId", currentChallange3.PlayerPrefsId);
        PlayerPrefs.SetInt("currentChallange3.id", currentChallange3.id);
        PlayerPrefs.SetInt("currentChallange3.reward", currentChallange3.reward);
        PlayerPrefs.SetInt("currentChallange3.done", currentChallange3.done);
        PlayerPrefs.SetInt("currentChallange3.startValue", currentChallange3.startValue);
    }
    void checkIfChallangeIsDone()
    {

        //currentChallange1
        if(currentChallange1.done == 1)
        {
            //generate a new Challange
            currentChallange1 = allChallanges[generateNewChallangeId()];

            AllmightyTrackerScript.allmightyTracker.writeToFile("doneChallange"); //in das script das eine aufgabe abgeschlossen wurde
        }
        if(currentChallange1.done == 0 && currentChallange1.goal <= currentChallange1.count )
        {
            print(currentChallange1.done == 0 && currentChallange1.goal <= currentChallange1.count);
            print(currentChallange1.done + currentChallange1.goal + currentChallange1.count);
            //open popup for the player
            challange1DonePopUp.SetActive(true);
            //give the player his reward
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange1.reward);
            //store old Challenge to show in Pop Up
            storeOldChallange(currentChallange1, 1);
            oldChallange1 = currentChallange1;
            PlayerPrefs.SetInt("Challenge1.Completed", 1);
            //generate new Challange
            currentChallange1 = allChallanges[generateNewChallangeId()];//TODO vielleicht erst in der runde danach abschließen
            AllmightyTrackerScript.allmightyTracker.writeToFile("doneChallange"); //in das script das eine aufgabe abgeschlossen wurde
        }

        //currentChallange2
        if (currentChallange2.done == 1)
        {
            //generate a new Challange
            currentChallange2 = allChallanges[generateNewChallangeId()];
            AllmightyTrackerScript.allmightyTracker.writeToFile("doneChallange"); //in das script das eine aufgabe abgeschlossen wurde
        }
        if (currentChallange2.done == 0 && currentChallange2.goal <= currentChallange2.count)
        {
            //open popup for the player
            challange1DonePopUp.SetActive(true);
            //give the player his reward
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange2.reward);
            //store old Challange for Pop UP
            storeOldChallange(currentChallange2, 2);
            oldChallange2 = currentChallange2;
            PlayerPrefs.SetInt("Challenge2.Completed", 1);
            //generate new Challange
            currentChallange2 = allChallanges[generateNewChallangeId()];
            AllmightyTrackerScript.allmightyTracker.writeToFile("doneChallange"); //in das script das eine aufgabe abgeschlossen wurde
        }

        //currentChallange3
        if (currentChallange3.done == 1)
        {
            //generate a new Challange
            currentChallange3 = allChallanges[generateNewChallangeId()];
            AllmightyTrackerScript.allmightyTracker.writeToFile("doneChallange"); //in das script das eine aufgabe abgeschlossen wurde
        }
        if (currentChallange3.done == 0 && currentChallange3.goal <= currentChallange3.count )
        {
            //open popup for the player
            challange1DonePopUp.SetActive(true);
            //give the player his reward
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange3.reward);
            //store old Challange for Pop UP
            storeOldChallange(currentChallange1, 1);
            oldChallange3 = currentChallange3;
            PlayerPrefs.SetInt("Challenge3.Completed", 1);
            //generate new Challange
            currentChallange3 = allChallanges[generateNewChallangeId()];
            AllmightyTrackerScript.allmightyTracker.writeToFile("doneChallange"); //in das script das eine aufgabe abgeschlossen wurde
        }
    }

    int generateNewChallangeId()
    {
        int rand;
        if (PlayerPrefs.GetInt("highestLevel") < 1)
            rand = Random.Range(0, 7);
        else if (PlayerPrefs.GetInt("highestLevel") <= 1)
            rand = Random.Range(0, 10);
        else if (PlayerPrefs.GetInt("highestLevel") <= 3)
            rand = Random.Range(0, 11);
        else if (PlayerPrefs.GetInt("highestLevel") <= 6)
            rand = Random.Range(0, 12);
        else if (PlayerPrefs.GetInt("highestLevel") <= 9)
            rand = Random.Range(0, 13);
        else if (PlayerPrefs.GetInt("highestLevel") <= 13)
            rand = Random.Range(0, 14);
        else if (PlayerPrefs.GetInt("highestLevel") <= 26)
            rand = Random.Range(0, 15);
        else if (PlayerPrefs.GetInt("highestLevel") <= 27)
            rand = Random.Range(0, allChallanges.Count - 1);
        else
            rand = Random.Range(0, 7);
        while (rand == currentChallange1.id || rand == currentChallange2.id || rand == currentChallange3.id)
        {
            if(PlayerPrefs.GetInt("highestLevel") < 1)
                rand = Random.Range(0, 7);
            else if (PlayerPrefs.GetInt("highestLevel") <= 1)
                rand = Random.Range(0, 10);
            else if (PlayerPrefs.GetInt("highestLevel") <= 3)
                rand = Random.Range(0, 11);
            else if (PlayerPrefs.GetInt("highestLevel") <= 6)
                rand = Random.Range(0, 12);
            else if (PlayerPrefs.GetInt("highestLevel") <= 9)
                rand = Random.Range(0, 13);
            else if (PlayerPrefs.GetInt("highestLevel") <= 13)
                rand = Random.Range(0, 14);
            else if (PlayerPrefs.GetInt("highestLevel") <= 26)
                rand = Random.Range(0, 15);
            else if (PlayerPrefs.GetInt("highestLevel") <= 27)
                rand = Random.Range(0, allChallanges.Count - 1);
            else
                rand = Random.Range(0, 7); 
        }
        return rand;
    }

    void updateChallangesGui()
    {
        List<Image> Challenge1Bilder = new List<Image>{ C1BlueToken, C1ColorBomb, C1GreenToken, C1Ingridient1Token, C1Ingridient2Token, C1OrangeToken, C1PurpleToken, C1RedToken, C1Stone1Token, C1Stone2Token, C1YellowToken, C1Coockie1Token, C1Coockie2Token, C1BombToken, C1HorizontalBombToken, C1VerticalBombToken, C1GamesWonToken, C1GamesStartedToken };
        List<Image> Challenge2Bilder = new List<Image> { C2BlueToken, C2ColorBomb, C2GreenToken, C2Ingridient1Token, C2Ingridient2Token, C2OrangeToken, C2PurpleToken, C2RedToken, C2Stone1Token, C2Stone2Token, C2YellowToken, C2Coockie1Token, C2Coockie2Token, C2BombToken, C2HorizontalBombToken, C2VerticalBombToken, C2GamesWonToken, C2GamesStartedToken };
        List<Image> Challenge3Bilder = new List<Image> { C3BlueToken, C3ColorBomb, C3GreenToken, C3Ingridient1Token, C3Ingridient2Token, C3OrangeToken, C3PurpleToken, C3RedToken, C3Stone1Token, C3Stone2Token, C3YellowToken, C3Coockie1Token, C3Coockie2Token, C3BombToken, C3HorizontalBombToken, C3VerticalBombToken, C3GamesWonToken, C3GamesStartedToken };
        //alle Bilder auf nicht angezeigt setzen, damit später nur die richtigen aktiviert werden 
        for(int i = 0; i < Challenge1Bilder.Count ; i++)
        {
            Challenge1Bilder[i].enabled = false;
        }
        for (int i = 0; i < Challenge2Bilder.Count; i++)
        {
            Challenge2Bilder[i].enabled = false;
        }
        for (int i = 0; i < Challenge3Bilder.Count; i++)
        {
            Challenge3Bilder[i].enabled = false;
        }

        

        challange1Description.text = currentChallange1.Description;
        Challenge1reward.text = currentChallange1.reward.ToString();
        Challenge1Slider.value = (float)currentChallange1.count / (float)currentChallange1.goal;
        if(currentChallange1.done == 1)
        {
            challange1Done.SetActive(true);
        }
        else
        {
            challange1Done.SetActive(false);
        }
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
        Challenge2reward.text = currentChallange2.reward.ToString();
        Challenge2Slider.value = (float)currentChallange2.count / (float)currentChallange2.goal;
        if (currentChallange2.done == 1)
        {
            challange2Done.SetActive(true);
        }
        else
        {
            challange2Done.SetActive(false);
        }
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
        Challenge3reward.text = currentChallange3.reward.ToString();
        Challenge3Slider.value = (float)currentChallange3.count / (float)currentChallange3.goal;
        if (currentChallange3.done == 1)
        {
            challange3Done.SetActive(true);
        }
        else
        {
            challange3Done.SetActive(false);
        }
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
        if(PlayerPrefs.GetInt("allChallangesDone", 0) == 1)
        {
            allChallangesDone.SetActive(true);
        }
        else
        {
            allChallangesDone.SetActive(false);
        }
    }

    // 
    private void updateChallangesDone()
    {
        if(currentChallange1.count >= currentChallange1.goal && PlayerPrefs.GetInt("currentChallange1.done", 1) == 0)
        {
            currentChallange1.done = 1;
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange1.reward);
            challange1DonePopUp.SetActive(true);
            PlayerPrefs.SetInt("currentChallange1.done", 1);
            if (currentChallange2.done == 1 && currentChallange3.done == 1)
            {
                PlayerPrefs.SetInt("allChallangesDone", 1);
            }
           
        }
        if (currentChallange2.count >= currentChallange2.goal && PlayerPrefs.GetInt("currentChallange2.done", 1) == 0)
        {
            currentChallange2.done = 1;
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange2.reward);
            challange2DonePopUp.SetActive(true);
            PlayerPrefs.SetInt("currentChallange2.done", 1);
            if (currentChallange1.done == 1 && currentChallange3.done == 1)
            {
                PlayerPrefs.SetInt("allChallangesDone", 1);
            }
        }
        if (currentChallange3.count >= currentChallange3.goal && PlayerPrefs.GetInt("currentChallange3.done", 1) == 0)
        {
            currentChallange3.done = 1;
            moneyHandler.GetComponent<MoneyHandlerScript>().addMoney(currentChallange3.reward);
            challange3DonePopUp.SetActive(true);
            PlayerPrefs.SetInt("currentChallange3.done", 1);
            if (currentChallange2.done == 1 && currentChallange1.done == 1)
            {
                PlayerPrefs.SetInt("allChallangesDone", 1);
            }
        }
    }

    private void storeOldChallange(Challange currentChallange, int index)
    {
        PlayerPrefs.SetInt("oldChallange"+index+".goal", currentChallange.goal);
        PlayerPrefs.SetInt("oldChallange" + index + ".count", currentChallange.count);
        PlayerPrefs.SetString("oldChallange" + index + ".Description", currentChallange.Description);
        PlayerPrefs.SetString("oldChallange" + index + ".PlayerPrefsId", currentChallange.PlayerPrefsId);
        PlayerPrefs.SetInt("oldChallange" + index + ".id", currentChallange.id);
        PlayerPrefs.SetInt("oldChallange" + index + ".reward", currentChallange.reward);
        PlayerPrefs.SetInt("oldChallange" + index + ".done", currentChallange.done);
    }

    public Challange getCurrentChallenge1()
    {
        return currentChallange1;
    }

    public Challange getCurrentChallenge2()
    {
        return currentChallange2;
    }

    public Challange getCurrentChallenge3()
    {
        return currentChallange3;
    }

    public Challange getOldChallange1()
    {
        return oldChallange1;
    }

    public Challange getOldChallange2()
    {
        return oldChallange2;
    }

    public Challange getOldChallange3()
    {
        return oldChallange3;
    }


}

public struct Challange
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
