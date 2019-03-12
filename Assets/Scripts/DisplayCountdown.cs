using UnityEngine;
using UnityEngine.UI;

public class DisplayCountdown : MonoBehaviour
{
    public ScoreTimeData scoreTimeData;
    public Text textScore;
    public Text textTime;

    // Use this for initialization
    void Start()
    {
        textTime.text = FormatString(scoreTimeData.timer);
        textScore.text = "Touched Platforms: " + scoreTimeData.score.ToString();
    }

    public string FormatString(float timer)
    {
        string tmp = string.Format("{0:00}:{1:00}:{2:00}",
            Mathf.Floor(timer / 60),
            Mathf.Floor(timer) % 60,
            Mathf.Floor((timer * 100) % 100));

        return tmp;
    }
}
