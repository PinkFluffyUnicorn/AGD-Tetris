using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour {
    public string ID;
    public bool trackOnStart;
    public bool trackOnDestroy;
    // Use this for initialization
    void Start()
    {
        if (trackOnStart)
            PlayerPrefs.SetInt(ID, PlayerPrefs.GetInt(ID, 0) + 1);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        if (trackOnDestroy)
            PlayerPrefs.SetInt(ID, PlayerPrefs.GetInt(ID, 0) + 1);
    }
}

