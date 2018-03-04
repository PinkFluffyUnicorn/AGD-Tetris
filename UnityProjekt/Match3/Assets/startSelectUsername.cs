using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSelectUsername : MonoBehaviour
{

    public GameObject selectUsernamePanel;
    // Use this for initialization
    void Start()
    {
        //PlayerPrefs.SetString("username", "bob");
        if (PlayerPrefs.GetString("Username", "") == "")
            selectUsernamePanel.gameObject.SetActive(true);
        else
            selectUsernamePanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}