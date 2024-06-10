using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfoView : MonoBehaviour
{
    public int currentInfo;
    public TMPro.TextMeshProUGUI title;
    public TMPro.TextMeshProUGUI infoText;
    public GameObject nextButton;
    public GameObject previousButton;
    public GameObject infoPanel;
    public Info[] info;

    private void Start()
    {
        ShowInfo();
    }

    public void ShowInfo()
    {
        title.text = info[currentInfo].title;
        infoText.text = info[currentInfo].info;
        nextButton.SetActive(currentInfo < info.Length);
        previousButton.SetActive(currentInfo > 0);


    }

    public void NextInfo()
    {
        currentInfo++;

        if (currentInfo >= info.Length)
        {
            Skip();
            return;
        }

        ShowInfo();
    }

    public void PreviousInfo()
    {
        currentInfo--;
        ShowInfo();
    }

    public void Skip()
    {
        infoPanel.SetActive(false);
        PlayerPrefs.SetInt("hasOpened", 1);
        currentInfo = 0;
        ShowInfo();
    }

}

[Serializable]
public class Info
{
    public string title;
    [TextArea(3, 10)]
    public string info;
}
