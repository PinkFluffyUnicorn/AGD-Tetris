using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //PlayerPrefs.DeleteAll();
        int FirstLogin = PlayerPrefs.GetInt("FirstLogin", 1);
        if (FirstLogin == 1)
        {
            PlayerPrefs.SetInt("Money", 100);
            PlayerPrefs.SetInt("BlueTokenDestroyd", 0);
            PlayerPrefs.SetInt("ChocklateDestroyd", 0);
            PlayerPrefs.SetInt("ColorBombDestroyd", 0);
            PlayerPrefs.SetInt("GreenTokenDestroyd", 0);
            PlayerPrefs.SetInt("Ingridient1Destroyd", 0);
            PlayerPrefs.SetInt("Ingridient2Destroyd", 0);
            PlayerPrefs.SetInt("OrangeTokenDestroyd", 0);
            PlayerPrefs.SetInt("PurpleTokenDestroyd", 0);
            PlayerPrefs.SetInt("RedTokenDestroyd", 0);
            PlayerPrefs.SetInt("Stone2Destroyd", 0);
            PlayerPrefs.SetInt("YellowTokenDestroyd", 0);

            PlayerPrefs.SetInt("Coockie1Destroyd", 0);
            PlayerPrefs.SetInt("Coockie2Destroyd", 0);

            PlayerPrefs.SetInt("BombDestroyd", 0);
            PlayerPrefs.SetInt("HorizontalBombDestroyd", 0);
            PlayerPrefs.SetInt("VerticalBombDestroyd", 0);

            PlayerPrefs.SetInt("GameWon", 0);
            PlayerPrefs.SetInt("GameLost", 0);
            PlayerPrefs.SetInt("GameStarted", 0);


            PlayerPrefs.SetInt("currentChallange1.goal", 0);
            PlayerPrefs.SetInt("currentChallange1.count", 0);
            PlayerPrefs.SetString("currentChallange1.Description", "");
            PlayerPrefs.SetString("currentChallange1.PlayerPrefsId", "");
            PlayerPrefs.SetInt("currentChallange1.id", 0);
            PlayerPrefs.SetInt("currentChallange1.reward", 0);
            PlayerPrefs.SetInt("currentChallange1.done", 1);
            PlayerPrefs.SetInt("currentChallange1.startValue", 0);

            PlayerPrefs.SetInt("currentChallange2.goal", 0);
            PlayerPrefs.SetInt("currentChallange2.count", 0);
            PlayerPrefs.SetString("currentChallange2.Description", "");
            PlayerPrefs.SetString("currentChallange2.PlayerPrefsId", "");
            PlayerPrefs.SetInt("currentChallange2.id", 0);
            PlayerPrefs.SetInt("currentChallange2.reward", 0);
            PlayerPrefs.SetInt("currentChallange2.done", 1);
            PlayerPrefs.SetInt("currentChallange2.startValue", 0);

            PlayerPrefs.SetInt("currentChallange3.goal", 0);
            PlayerPrefs.SetInt("currentChallange3.count", 0);
            PlayerPrefs.SetString("currentChallange3.Description", "");
            PlayerPrefs.SetString("currentChallange3.PlayerPrefsId", "");
            PlayerPrefs.SetInt("currentChallange3.id", 0);
            PlayerPrefs.SetInt("currentChallange3.reward", 0);
            PlayerPrefs.SetInt("currentChallange3.done", 1);
            PlayerPrefs.SetInt("currentChallange3.startValue", 0);

            PlayerPrefs.SetInt("oldChallange1.goal", 0);
            PlayerPrefs.SetInt("oldChallange1.count", 0);
            PlayerPrefs.SetString("oldChallange1.Description", "");
            PlayerPrefs.SetString("oldChallange1.PlayerPrefsId", "");
            PlayerPrefs.SetInt("oldChallange1.id", 0);
            PlayerPrefs.SetInt("oldChallange1.reward", 0);
            PlayerPrefs.SetInt("oldChallange1.done", 1);
            PlayerPrefs.SetInt("oldChallange1.startValue", 0);

            PlayerPrefs.SetInt("oldChallange2.goal", 0);
            PlayerPrefs.SetInt("oldChallange2.count", 0);
            PlayerPrefs.SetString("oldChallange2.Description", "");
            PlayerPrefs.SetString("oldChallange2.PlayerPrefsId", "");
            PlayerPrefs.SetInt("oldChallange2.id", 0);
            PlayerPrefs.SetInt("oldChallange2.reward", 0);
            PlayerPrefs.SetInt("oldChallange2.done", 1);
            PlayerPrefs.SetInt("oldChallange2.startValue", 0);

            PlayerPrefs.SetInt("oldChallange3.goal", 0);
            PlayerPrefs.SetInt("oldChallange3.count", 0);
            PlayerPrefs.SetString("oldChallange3.Description", "");
            PlayerPrefs.SetString("oldChallange3.PlayerPrefsId", "");
            PlayerPrefs.SetInt("oldChallange3.id", 0);
            PlayerPrefs.SetInt("oldChallange3.reward", 0);
            PlayerPrefs.SetInt("oldChallange3.done", 1);
            PlayerPrefs.SetInt("oldChallange3.startValue", 0);

            //Challenge done 
            PlayerPrefs.SetInt("Challenge1.Completed", 0);// only 1 when an old Challenge is completed and has to be shown in POP UP 
            PlayerPrefs.SetInt("Challenge2.Completed", 0);
            PlayerPrefs.SetInt("Challenge3.Completed", 0);
            PlayerPrefs.SetInt("allChallangesDone", 0);

            //Only new Challanges when a new Day starts 
            PlayerPrefs.SetInt("ChallangeDate", 0);


            //Daily Bonus 
            PlayerPrefs.SetInt("NumberOfBonus", 0);
            PlayerPrefs.SetInt("date", System.DateTime.Now.DayOfYear);
            PlayerPrefs.SetInt("StartDayBonus", 0);

            //Events 
            PlayerPrefs.SetInt("StartDay", System.DateTime.Now.DayOfYear);
            PlayerPrefs.SetInt("AdvertiseEvent1", 0);
            PlayerPrefs.SetInt("AdvertiseEvent2", 0);
            PlayerPrefs.SetInt("Event1", 0);
            PlayerPrefs.SetInt("Event2", 0);
            PlayerPrefs.SetInt("Event1GoingOn", 0);
            PlayerPrefs.SetInt("Event2GoingOn", 0);
            PlayerPrefs.SetInt("Event2Start", 0);
            PlayerPrefs.SetInt("Event2Duration", 0);
            PlayerPrefs.SetInt("Event1Start", 0);
            PlayerPrefs.SetInt("Event1Duration", 0);

            //Lives
            PlayerPrefs.SetInt("Lives", 5);
            PlayerPrefs.SetInt("NextLifeIn", 0);
            PlayerPrefs.SetInt("LastLifeDate", System.DateTime.Now.DayOfYear);

            //Booster
            PlayerPrefs.SetInt("PickAxeBooster", 3);
            PlayerPrefs.SetInt("HandBooster", 3);
            PlayerPrefs.SetInt("PlusFiveBooster", 3);

            //Notifications
            PlayerPrefs.SetInt("NotifDaily", System.DateTime.Now.DayOfYear);
            PlayerPrefs.SetInt("NotifLives", 0); //set to one if Lives were less than three, only if it gets full & was 1 send notification

            PlayerPrefs.SetInt("highestLevel", 0);

            PlayerPrefs.SetInt("FirstLogin", 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
