using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSelectUsernamePanel : MonoBehaviour {

    public GameObject selectUsernamePanel;
    // Use this for initialization
    void Start()
    {
        //PlayerPrefs.SetString("Username", "");
        if (PlayerPrefs.GetString("Username", "") == "")
            selectUsernamePanel.gameObject.SetActive(true);
        else
            selectUsernamePanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
