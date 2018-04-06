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
        return PlayerPrefs.GetInt("HandBooster", 0);
    }


    public void addHandBooster(int newAmount)
    {
        int oldAmount = getAMountHandBooster();
        PlayerPrefs.SetInt("HandBooster", oldAmount + newAmount);
    }

    public bool subtractHandBooster(int newAmount)
    {
        int oldAmount = PlayerPrefs.GetInt("HandBooster", 0);
        if (oldAmount - newAmount >= 0)
        {
            PlayerPrefs.SetInt("HandBooster", oldAmount - newAmount);
            return true;
        }
        else
        {
            return false;
        }

    }

    public int getAMountHandBooster()
    {
        return PlayerPrefs.GetInt("HandBooster", 0);
    }




    public bool subtractPlusFiveBooster(int newAmount)
    {
        int oldAmount = PlayerPrefs.GetInt("PlusFiveBooster", 0);
        if (oldAmount - newAmount >= 0)
        {
            PlayerPrefs.SetInt("PlusFiveBooster", oldAmount - newAmount);
            return true;
        }
        else
        {
            return false;
        }

    }

    public void addPlusFiveBooster(int newAmount)
    {
        int oldAmount = getAMountPlusFiveBooster();
        PlayerPrefs.SetInt("PlusFiveBooster", oldAmount + newAmount);
    }

    public int getAMountPlusFiveBooster()
    {
        return PlayerPrefs.GetInt("PlusFiveBooster", 0);
    }
}
