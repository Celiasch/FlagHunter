using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCountdown : MonoBehaviour
{

    public ScoreTimeData scoreTimeData;
    public Text textScore;
    public Text textTime;

    // Use this for initialization
    void Start()
    {
        textTime.text = scoreTimeData.timer.ToString() + " sec";
        textScore.text = "Touched Platforms: " + scoreTimeData.score.ToString();
    }
    void Update()
    {

        textTime.text = string.Format("{0:00}:{1:00}.{2:00}");
    }
}
