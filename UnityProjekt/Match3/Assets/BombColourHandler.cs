using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombColourHandler : MonoBehaviour
{

    public Sprite Bombcolour;
    bool bomb = false;
    bool horizontalBomb = false;
    bool verticalBomb = false;

    // Use this for initialization
    void Start()
    {
        //bomb
        BombAction[] bombs = GetComponentsInChildren<BombAction>();

        if (bombs.Length > 0)
        {
            bomb = true;
        }

        if (bomb)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Bombcolour;
        }

        //horizontal & vertical bomb set in update
    }

    // Update is called once per frame
    void Update ()
    {
        if (bomb)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Bombcolour;
        }

        if (!horizontalBomb && !verticalBomb)
        {
            Transform[] transform = GetComponentsInChildren<Transform>();

            foreach (Transform child in transform)
            {
                if (child.name.Contains("line"))
                {
                    var spriteName = gameObject.GetComponent<SpriteRenderer>().sprite.name;
                    if (spriteName.Contains("_v_") && !verticalBomb)
                    {
                        verticalBomb = true;
                    }
                    if (spriteName.Contains("_h_") && !horizontalBomb)
                    {
                        horizontalBomb = true;
                    }
                }
            }
        }
    }

    void OnDestroy()
    {
        if (bomb)
        {
            PlayerPrefs.SetInt("BombDestroyd", PlayerPrefs.GetInt("BombDestroyd", 0) + 1);
        }

        if(horizontalBomb)
        {
            PlayerPrefs.SetInt("HorizontalBombDestroyd", PlayerPrefs.GetInt("HorizontalBombDestroyd", 0) + 1);
        }

        if(verticalBomb)
        {
            PlayerPrefs.SetInt("VerticalBombDestroyd", PlayerPrefs.GetInt("VerticalBombDestroyd", 0) + 1);
        }
    }
}
