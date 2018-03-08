using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractLive : MonoBehaviour {
    public GameObject LiveHandler;
    public int amount;

	// Use this for initialization
	void Start ()
    {
       LiveHandler.GetComponent<LiveHandelerScript>().subtractLives(amount);
		
	}
	
}
