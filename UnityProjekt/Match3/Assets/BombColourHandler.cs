using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombColourHandler : MonoBehaviour
{

    public Sprite Bombcolour;
    bool bomb = false;

	// Use this for initialization
	void Start ()
    {
        BombAction[] allChildren = GetComponentsInChildren<BombAction>();
      
            if(allChildren.Length > 0 )
            {
                bomb = true;
            }

        if(bomb)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Bombcolour;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (bomb)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Bombcolour;
        }
    }

    void OnDestroy()
    {
        if (bomb)
        {
            PlayerPrefs.SetInt("BombDestroyd", PlayerPrefs.GetInt("BombDestroyd", 0) + 1);
        }
    }
}
