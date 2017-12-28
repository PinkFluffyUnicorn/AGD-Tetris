using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


//manager for level overview
//irgendwelche Funktionen die dann vom LevelOverviewState aufgerufen werden 
public class LevelOverviewManager : MonoBehaviour
{
    public LevelOverview levelOverview;
    public GameObject panel;

    public void ActivateLevelOverview()
    {
        StartCoroutine(ActivateLevelOverviewer());
    }


    // ich weiß nicht warum man das so macht, aber in den anderen Menü klassen wurde das auch so gemacht 
    IEnumerator ActivateLevelOverviewer() 
    {
        //müssen hier inGameUI & MainMenu auf false gesetzt werden? 
        yield return new WaitForSeconds(0.3f);
        levelOverview.gameObject.SetActive(true);
        levelOverview.LevelOverviewStartAnimation();
    }
   


}

