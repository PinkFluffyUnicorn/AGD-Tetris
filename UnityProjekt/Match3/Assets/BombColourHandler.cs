using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombColourHandler : MonoBehaviour
{

    public Sprite BombBlue;
    public Sprite BombGreen;
    public Sprite BombRed;
    public Sprite BombPurple;
    public Sprite BombOrange;

	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = BombBlue;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //finalBomb = BombBlue;
        gameObject.GetComponent<SpriteRenderer>().sprite = BombBlue;
    }
}
