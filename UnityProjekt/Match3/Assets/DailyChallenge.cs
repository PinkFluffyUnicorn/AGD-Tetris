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

    public GameObject moneyHandler;
    public GameObject ChallengeHandler;

    // Use this for initialization
    void Start ()
    {
        var Challenges = ChallengeHandler.GetComponent<ChallangeHandlerScript>();



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



        //TODO: hier die Progressbar für alle hinzufügen
        //TODO: den Reward in der Gui setzen
        print("hi");
        challange1Description.text = Challenges.challange1Description.text;
        Challenge1reward.text = Challenges.Challenge1reward.text;
        Challenge1Slider.value = Challenges.Challenge1Slider.value;

        if(Challenge1Slider.value == 1)
        {
            challange1Done.SetActive(true);
        }
        else
        {
            challange1Done.SetActive(false);
        }

        C1BlueToken.enabled = Challenges.C1BlueToken.enabled;
        C1ColorBomb.enabled = Challenges.C1ColorBomb.enabled;
        C1GreenToken.enabled = Challenges.C1GreenToken.enabled;
        C1Ingridient1Token.enabled = Challenges.C1Ingridient1Token.enabled;
        C1Ingridient2Token.enabled = Challenges.C1Ingridient2Token.enabled;
        C1OrangeToken.enabled = Challenges.C1OrangeToken.enabled;
        C1PurpleToken.enabled = Challenges.C1PurpleToken.enabled;
        C1RedToken.enabled = Challenges.C1RedToken.enabled;
        C1Stone1Token.enabled = Challenges.C1Stone1Token.enabled;
        C1Stone2Token.enabled = Challenges.C1Stone2Token.enabled;
        C1YellowToken.enabled = Challenges.C1YellowToken.enabled;
        C1Coockie1Token.enabled = Challenges.C1Coockie1Token.enabled;
        C1Coockie2Token.enabled = Challenges.C1Coockie2Token.enabled;
        C1BombToken.enabled = Challenges.C1BombToken.enabled;
        C1HorizontalBombToken.enabled = Challenges.C1HorizontalBombToken.enabled;
        C1VerticalBombToken.enabled = Challenges.C1VerticalBombToken.enabled;
        C1GamesWonToken.enabled = Challenges.C1GamesWonToken.enabled;
        C1GamesStartedToken.enabled = Challenges.C1GamesStartedToken.enabled;

        challange2Description.text = Challenges.challange2Description.text;
        Challenge2reward.text = Challenges.Challenge2reward.text;
        Challenge2Slider.value = Challenges.Challenge2Slider.value;
        if (Challenge2Slider.value == 1)
        {
            challange2Done.SetActive(true);
        }
        else
        {
            challange2Done.SetActive(false);
        }

        C2BlueToken.enabled = Challenges.C2BlueToken.enabled;
        C2ColorBomb.enabled = Challenges.C2ColorBomb.enabled;
        C2GreenToken.enabled = Challenges.C2GreenToken.enabled;
        C2Ingridient1Token.enabled = Challenges.C2Ingridient1Token.enabled;
        C2Ingridient2Token.enabled = Challenges.C2Ingridient2Token.enabled;
        C2OrangeToken.enabled = Challenges.C2OrangeToken.enabled;
        C2PurpleToken.enabled = Challenges.C2PurpleToken.enabled;
        C2RedToken.enabled = Challenges.C2RedToken.enabled;
        C2Stone1Token.enabled = Challenges.C2Stone1Token.enabled;
        C2Stone2Token.enabled = Challenges.C2Stone2Token.enabled;
        C2YellowToken.enabled = Challenges.C2YellowToken.enabled;
        C2Coockie1Token.enabled = Challenges.C2Coockie1Token.enabled;
        C2Coockie2Token.enabled = Challenges.C2Coockie2Token.enabled;
        C2BombToken.enabled = Challenges.C2BombToken.enabled;
        C2HorizontalBombToken.enabled = Challenges.C2HorizontalBombToken.enabled;
        C2VerticalBombToken.enabled = Challenges.C2VerticalBombToken.enabled;
        C2GamesWonToken.enabled = Challenges.C2GamesWonToken.enabled;
        C2GamesStartedToken.enabled = Challenges.C2GamesStartedToken.enabled;


        challange3Description.text = Challenges.challange3Description.text;
        Challenge3reward.text = Challenges.Challenge3reward.text;
        Challenge3Slider.value = Challenges.Challenge3Slider.value;

        if (Challenge3Slider.value == 1)
        {
            challange3Done.SetActive(true);
        }
        else
        {
            challange3Done.SetActive(false);
        }

        C3BlueToken.enabled = Challenges.C3BlueToken.enabled;
        C3ColorBomb.enabled = Challenges.C3ColorBomb.enabled;
        C3GreenToken.enabled = Challenges.C3GreenToken.enabled;
        C3Ingridient1Token.enabled = Challenges.C3Ingridient1Token.enabled;
        C3Ingridient2Token.enabled = Challenges.C3Ingridient2Token.enabled;
        C3OrangeToken.enabled = Challenges.C3OrangeToken.enabled;
        C3PurpleToken.enabled = Challenges.C3PurpleToken.enabled;
        C3RedToken.enabled = Challenges.C3RedToken.enabled;
        C3Stone1Token.enabled = Challenges.C3Stone1Token.enabled;
        C3Stone2Token.enabled = Challenges.C3Stone2Token.enabled;
        C3YellowToken.enabled = Challenges.C3YellowToken.enabled;
        C3Coockie1Token.enabled = Challenges.C3Coockie1Token.enabled;
        C3Coockie2Token.enabled = Challenges.C3Coockie2Token.enabled;
        C3BombToken.enabled = Challenges.C3BombToken.enabled;
        C3HorizontalBombToken.enabled = Challenges.C3HorizontalBombToken.enabled;
        C3VerticalBombToken.enabled = Challenges.C3VerticalBombToken.enabled;
        C3GamesWonToken.enabled = Challenges.C3GamesWonToken.enabled;
        C3GamesStartedToken.enabled = Challenges.C3GamesStartedToken.enabled;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
