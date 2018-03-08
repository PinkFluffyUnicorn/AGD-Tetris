using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckLives : MonoBehaviour {

    public GameObject LiveHandler;
    public int amount;
    private bool enoughLives;
    public Button startButton;
    public GameObject PopUp;


    // Use this for initialization
    void Start ()
    {
        enoughLives = LiveHandler.GetComponent<LiveHandelerScript>().getLives() >= amount;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(!enoughLives)
        {
            startButton.enabled = false;
            PopUp.SetActive(true);
        }
        
	}


  
}
