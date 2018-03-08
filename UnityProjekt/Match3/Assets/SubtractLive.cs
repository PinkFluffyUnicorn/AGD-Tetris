using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractLive : MonoBehaviour {
    public GameObject LiveHandler;
    public int amount;
    public bool enoughLives;

	// Use this for initialization
	void Start ()
    {
       enoughLives =  LiveHandler.GetComponent<LiveHandelerScript>().subtractLives(amount);
		
	}
	
}
