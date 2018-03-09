using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event1Script_topLeft : MonoBehaviour {

    public GameObject Panel;
    public GameObject Background;


	// Use this for initialization
	void Start ()
    {
		if(PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            Background.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Event1GoingOn", 0) == 1)
        {
            Panel.SetActive(true);
            Background.SetActive(true);
        }
    }
}
