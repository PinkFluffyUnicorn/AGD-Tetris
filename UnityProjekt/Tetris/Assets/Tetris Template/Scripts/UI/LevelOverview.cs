using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;


public class LevelOverview : MonoBehaviour
{
    public Text LevelOverviewText;
    public GameObject LevelButtons;

    public HorizontalLayoutGroup layout;

    void Awake()
    {
        layout = GetComponent<HorizontalLayoutGroup>();
    }

    void OnEnable()
    {
        LevelOverviewText.enabled = true;
        LevelButtons.SetActive(true);
    }

    void OnDisable()
    {
        LevelOverviewText.enabled = false;
        LevelButtons.SetActive(false);
    }

    public void DisableLevelButtons()
    {
        LevelButtons.SetActive(false);
    }

    public void LevelOverviewStartAnimation()
    {
        LevelButtons.GetComponent<RectTransform>().DOAnchorPosY(-850, 1, true);
        LevelOverviewText.GetComponent<RectTransform>().DOAnchorPosY(600, 1, true);
    }

    public void LevelOverviewEndAnimation()
    {
        LevelButtons.GetComponent<RectTransform>().DOAnchorPosY(-1450, 0.3f, true);
        LevelOverviewText.GetComponent<RectTransform>().DOAnchorPosY(1200, 0.3f, true);
    }
}

