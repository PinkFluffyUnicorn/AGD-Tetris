using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterHandler : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        int PickAxeBooster = PlayerPrefs.GetInt("PickAxeBooster", 0);
        int HandBooster = PlayerPrefs.GetInt("HandBooster", 0);
        int PlusFiveBooster = PlayerPrefs.GetInt("PlusFiveBooster", 0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addPickAxeBooster(int newAmount)
    {
        int oldAmount = getAMountPickAxeBooster();
        PlayerPrefs.SetInt("PickAxeBooster", oldAmount + newAmount);
    }

    public bool subtractPickAxeBooster(int newAmount)
    {
        int oldAmount = PlayerPrefs.GetInt("PickAxeBooster", 0);
        if(oldAmount - newAmount >= 0)
        {
            PlayerPrefs.SetInt("PickAxeBooster", oldAmount - newAmount);
            return true;
        }
        else
        {
            return false;
        }

    }

    public int getAMountPickAxeBooster()
    {
        return PlayerPrefs.GetInt("PickAxeBooster", 0);
    }
}
