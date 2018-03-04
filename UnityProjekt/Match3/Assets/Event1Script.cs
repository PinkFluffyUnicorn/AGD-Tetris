using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event1Script : MonoBehaviour {

    private int durationOfEvent = 30; //minutes

    public void OnEnable()
    {
        //Zeit die schon am Tag rum ist in Minuten um keine Rechenfehler zu haben 
        double startTime = System.DateTime.Now.TimeOfDay.TotalMinutes;
        double endTime = startTime + durationOfEvent;

    }

    public void OnDisable()
    {
        
    }

}
