using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //PlayerPrefs.DeleteAll();
        if(PlayerPrefs.GetInt("FirstLogin", 1) == 1)
        {
            PlayerPrefs.SetInt("Money", 10);
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

            PlayerPrefs.SetInt("FirstLogIn", 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
