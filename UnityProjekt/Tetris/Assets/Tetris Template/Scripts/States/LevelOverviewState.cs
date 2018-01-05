using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


//for the level overview, where the user can click on a level and play it 
public class LevelOverviewState : _StatesBase
{

    public override void OnActivate()
    {
        Debug.Log("<color=green>Level Overview State</color> OnActive");
        Managers.LevelOverviewer.panel.SetActive(true); //?
        Managers.LevelOverviewer.ActivateLevelOverview();
        //Managers.LevelOverviewer.L
    }

    public override void OnDeactivate()
    {
        Debug.Log("<color=red>Level Overview State</color> OnDeactivate");
        Managers.LevelOverviewer.panel.SetActive(false); //?
    }

    // muss hier vllt abgefangen werden, falls die Level übersicht größer wird, als ein Handybildschirm, 
    // dass der Nutzer iwie navigieren kann? 
    public override void OnUpdate()
    {
        if (Managers.Game.currentShape != null)
            Managers.Game.currentShape.movementController.ShapeUpdate();
        Debug.Log("<color=yellow>Level Overview State</color> OnUpdate");
    }
}

