using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUsername : MonoBehaviour {

    public Text usernameToSet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        usernameToSet.text = PlayerPrefs.GetString("Username", "");//verry bodget, maybe do it in the selectUsernamePanel
	}
}
