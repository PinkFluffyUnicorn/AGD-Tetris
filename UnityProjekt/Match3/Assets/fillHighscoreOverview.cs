using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillHighscoreOverview : MonoBehaviour {

    public Text person1;
    public Text person2;
    public Text person3;
    public Text person4;
    public Text person5;
    public Text person6;
    public Text person7;
    public Text person8;
    public Text person9;
    public Text person10;

    public Text buttonText;//TODO: set here
    public Text descriptionText; //TODO: setHere

    public GameObject highscoreDownloader;

    // Use this for initialization
    void Start () {
        List<string> data = highscoreDownloader.GetComponent<DownloadHighscores>().getOverallHighscores();

        if (data.Count >= 1)
            person1.text = data[0];
        else
            person1.text = "---";

        if (data.Count >= 2)
            person2.text = data[1];
        else
            person2.text = "---";

        if (data.Count >= 3)
            person3.text = data[2];
        else
            person3.text = "---";

        if (data.Count >= 4)
            person4.text = data[3];
        else
            person4.text = "---";

        if (data.Count >= 5)
            person5.text = data[4];
        else
            person5.text = "---";

        if (data.Count >= 6)
            person6.text = data[5];
        else
            person6.text = "---";

        if (data.Count >= 7)
            person7.text = data[6];
        else
            person7.text = "---";

        if (data.Count >= 8)
            person8.text = data[7];
        else
            person8.text = "---";

        if (data.Count >= 9)
            person9.text = data[8];
        else
            person9.text = "---";

        if (data.Count >= 10)
            person10.text = data[9];
        else
            person10.text = "---";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
