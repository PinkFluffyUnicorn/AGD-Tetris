using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event1Script : MonoBehaviour {

    public void OnEnable()
    {
        PlayerPrefs.SetInt("Event1GoingOn", 1);
    }

    public void OnDisable()
    {
        
    }

}
