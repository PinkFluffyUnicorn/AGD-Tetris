using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyChallenge : MonoBehaviour {


    public GameObject challange1Done;
    public GameObject challange2Done;
    public GameObject challange3Done;

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

    public GameObject ChallengeHandler;

    public GameObject ButtonGetReward;

    Challange currentChallange1 = new Challange();
    Challange currentChallange2 = new Challange();
    Challange currentChallange3 = new Challange();

    Challange oldChallange1 = new Challange();
    Challange oldChallange2 = new Challange();
    Challange oldChallange3 = new Challange();

    // Use this for initialization
    void Start ()
    {
        var Challenges = ChallengeHandler.GetComponent<ChallangeHandlerScript>();

        currentChallange1 = Challenges.getCurrentChallenge1();
        currentChallange2 = Challenges.getCurrentChallenge2();
        currentChallange3 = Challenges.getCurrentChallenge3();

        oldChallange1 = Challenges.getOldChallange1();
        oldChallange2 = Challenges.getOldChallange2();
        oldChallange3 = Challenges.getOldChallange3();

        List<Image> Challenge1Bilder = new List<Image> { C1BlueToken, C1ColorBomb, C1GreenToken, C1Ingridient1Token, C1Ingridient2Token, C1OrangeToken, C1PurpleToken, C1RedToken, C1Stone1Token, C1Stone2Token, C1YellowToken, C1Coockie1Token, C1Coockie2Token, C1BombToken, C1HorizontalBombToken, C1VerticalBombToken, C1GamesWonToken, C1GamesStartedToken };
        List<Image> Challenge2Bilder = new List<Image> { C2BlueToken, C2ColorBomb, C2GreenToken, C2Ingridient1Token, C2Ingridient2Token, C2OrangeToken, C2PurpleToken, C2RedToken, C2Stone1Token, C2Stone2Token, C2YellowToken, C2Coockie1Token, C2Coockie2Token, C2BombToken, C2HorizontalBombToken, C2VerticalBombToken, C2GamesWonToken, C2GamesStartedToken };
        List<Image> Challenge3Bilder = new List<Image> { C3BlueToken, C3ColorBomb, C3GreenToken, C3Ingridient1Token, C3Ingridient2Token, C3OrangeToken, C3PurpleToken, C3RedToken, C3Stone1Token, C3Stone2Token, C3YellowToken, C3Coockie1Token, C3Coockie2Token, C3BombToken, C3HorizontalBombToken, C3VerticalBombToken, C3GamesWonToken, C3GamesStartedToken };
        //alle Bilder auf nicht angezeigt setzen, damit später nur die richtigen aktiviert werden 
        for (int i = 0; i < Challenge1Bilder.Count; i++)
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


        if (PlayerPrefs.GetInt("Challenge1.Completed", 0) == 1)// neue Challange 1
        {
            challange1Description.text = oldChallange1.Description;
            Challenge1reward.text = oldChallange1.reward.ToString();
            Challenge1Slider.value = oldChallange1.count / oldChallange1.goal;
            challange1Done.SetActive(true);
            switch (oldChallange1.PlayerPrefsId)
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
        }
        else
        {
            challange1Description.text = currentChallange1.Description;
            Challenge1reward.text = currentChallange1.reward.ToString();
            Challenge1Slider.value = currentChallange1.count / currentChallange1.goal;
            challange1Done.SetActive(false);
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
        }


        if (PlayerPrefs.GetInt("Challenge2.Completed", 0) == 1)
        {
            challange2Description.text = oldChallange2.Description;
            Challenge2reward.text = oldChallange2.reward.ToString();
            Challenge2Slider.value = oldChallange2.count / oldChallange2.goal;
            challange2Done.SetActive(true);
            switch (oldChallange2.PlayerPrefsId)
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
        }
        else
        {
            challange2Description.text = currentChallange2.Description;
            Challenge2reward.text = currentChallange2.reward.ToString();
            Challenge2Slider.value = currentChallange2.count / currentChallange2.goal;
            challange2Done.SetActive(false);
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
        }
        if (PlayerPrefs.GetInt("Challenge3.Completed", 0) == 1)
        {
            challange3Description.text = oldChallange3.Description;
            Challenge3reward.text = oldChallange3.reward.ToString();
            Challenge3Slider.value = oldChallange3.count / oldChallange3.goal;
            challange3Done.SetActive(true);
            switch (oldChallange3.PlayerPrefsId)
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
        else
        {
            challange3Description.text = currentChallange3.Description;
            Challenge3reward.text = currentChallange3.reward.ToString();
            Challenge3Slider.value = currentChallange3.count / currentChallange3.goal;
            challange3Done.SetActive(false);
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
        if (PlayerPrefs.GetInt("Challenge1.Completed", 0) == 1 || PlayerPrefs.GetInt("Challenge2.Completed", 0) == 1 || PlayerPrefs.GetInt("Challenge3.Completed", 0) == 1)
        {
            ButtonGetReward.SetActive(true);
        }
        else
        {
            ButtonGetReward.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update ()
    {

        List<Image> Challenge1Bilder = new List<Image> { C1BlueToken, C1ColorBomb, C1GreenToken, C1Ingridient1Token, C1Ingridient2Token, C1OrangeToken, C1PurpleToken, C1RedToken, C1Stone1Token, C1Stone2Token, C1YellowToken, C1Coockie1Token, C1Coockie2Token, C1BombToken, C1HorizontalBombToken, C1VerticalBombToken, C1GamesWonToken, C1GamesStartedToken };
        List<Image> Challenge2Bilder = new List<Image> { C2BlueToken, C2ColorBomb, C2GreenToken, C2Ingridient1Token, C2Ingridient2Token, C2OrangeToken, C2PurpleToken, C2RedToken, C2Stone1Token, C2Stone2Token, C2YellowToken, C2Coockie1Token, C2Coockie2Token, C2BombToken, C2HorizontalBombToken, C2VerticalBombToken, C2GamesWonToken, C2GamesStartedToken };
        List<Image> Challenge3Bilder = new List<Image> { C3BlueToken, C3ColorBomb, C3GreenToken, C3Ingridient1Token, C3Ingridient2Token, C3OrangeToken, C3PurpleToken, C3RedToken, C3Stone1Token, C3Stone2Token, C3YellowToken, C3Coockie1Token, C3Coockie2Token, C3BombToken, C3HorizontalBombToken, C3VerticalBombToken, C3GamesWonToken, C3GamesStartedToken };
        //alle Bilder auf nicht angezeigt setzen, damit später nur die richtigen aktiviert werden 
        for (int i = 0; i < Challenge1Bilder.Count; i++)
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

        if (PlayerPrefs.GetInt("Challenge1.Completed", 0) == 1)// neue Challange 1
        {
            challange1Description.text = oldChallange1.Description;
            Challenge1reward.text = oldChallange1.reward.ToString();
            Challenge1Slider.value = oldChallange1.count / oldChallange1.goal;
            challange1Done.SetActive(true);
            switch (oldChallange1.PlayerPrefsId)
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
        }
        else
        {
            challange1Description.text = currentChallange1.Description;
            Challenge1reward.text = currentChallange1.reward.ToString();
            Challenge1Slider.value = currentChallange1.count / currentChallange1.goal;
            challange1Done.SetActive(false);
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
        }


        if (PlayerPrefs.GetInt("Challenge2.Completed", 0) == 1)
        {
            challange2Description.text = oldChallange2.Description;
            Challenge2reward.text = oldChallange2.reward.ToString();
            Challenge2Slider.value = oldChallange2.count / oldChallange2.goal;
            challange2Done.SetActive(true);
            switch (oldChallange2.PlayerPrefsId)
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
        }
        else
        {
            challange2Description.text = currentChallange2.Description;
            Challenge2reward.text = currentChallange2.reward.ToString();
            Challenge2Slider.value = currentChallange2.count / currentChallange2.goal;
            challange2Done.SetActive(false);
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
        }
        if (PlayerPrefs.GetInt("Challenge3.Completed", 0) == 1)
        {
            challange3Description.text = oldChallange3.Description;
            Challenge3reward.text = oldChallange3.reward.ToString();
            Challenge3Slider.value = oldChallange3.count / oldChallange3.goal;
            challange3Done.SetActive(true);
            switch (oldChallange3.PlayerPrefsId)
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
        else
        {
            challange3Description.text = currentChallange3.Description;
            Challenge3reward.text = currentChallange3.reward.ToString();
            Challenge3Slider.value = currentChallange3.count / currentChallange3.goal;
            challange3Done.SetActive(false);
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

        if (PlayerPrefs.GetInt("Challenge1.Completed", 0) == 1 || PlayerPrefs.GetInt("Challenge2.Completed", 0) == 1 || PlayerPrefs.GetInt("Challenge3.Completed", 0) == 1)
        {
            ButtonGetReward.SetActive(true);
        }
        else
        {
            ButtonGetReward.SetActive(false);
        }
    }

    public void ButtonGetRewardOnClick()
    {
        PlayerPrefs.SetInt("Challenge1.Completed", 0);
        PlayerPrefs.SetInt("Challenge2.Completed", 0);
        PlayerPrefs.SetInt("Challenge3.Completed", 0);
    }

    
}
