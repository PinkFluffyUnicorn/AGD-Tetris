using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateLives : MonoBehaviour {

    public Text Timer;
    public Text numberOfLives;
    public GameObject LiveHandler;

	// Use this for initialization
	void Start ()
    {
        Timer.text = LiveHandler.GetComponent<LiveHandelerScript>().getTimer();
        numberOfLives.text = LiveHandler.GetComponent<LiveHandelerScript>().getLives().ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Timer.text = LiveHandler.GetComponent<LiveHandelerScript>().getTimer();
        numberOfLives.text = LiveHandler.GetComponent<LiveHandelerScript>().getLives().ToString();
    }
}
