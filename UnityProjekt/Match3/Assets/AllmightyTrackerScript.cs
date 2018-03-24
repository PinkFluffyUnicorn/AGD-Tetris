using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AllmightyTrackerScript : MonoBehaviour {

    //the pat for match.me on android is "Dieser PC\Galaxy S6\Phone\Android\obb"


    public static AllmightyTrackerScript allmightyTracker;
	// Use this for initialization
	void Awake () {
        if(allmightyTracker == null)
        {
            DontDestroyOnLoad(gameObject);
            allmightyTracker = this;
        }
        else if(allmightyTracker != this)
        {
            Destroy(gameObject);
        }
	}

    void OnApplicationFocus(bool inFocus)
    {
        if (inFocus)
        {
            //your app is in the background, yay!!!!
            print(DateTime.Now.ToString("dd.MM.yyy HH:mm:ss") + " active");
        }
        else
        {
            //the game is active! more yay!
            print(DateTime.Now.ToString("dd.MM.yyy HH:mm:ss") + " inactive");

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
