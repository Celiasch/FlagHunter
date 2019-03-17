using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text watch;
    public float timer;
    private int interval = 10;

    void Start()
    {
        watch = gameObject.GetComponent<Text>();
        watch.text = "00:00:00";
    }

    void Update()
    {
        timer += Time.deltaTime;

        //format timer 
        watch.text = string.Format("{0:00}:{1:00}.{2:00}",
            Mathf.Floor(timer / 60),
            Mathf.Floor(timer) % 60,
            Mathf.Floor((timer * 100) % 100));

        if (timer > interval)
        {
            GlobalVariables.speed = GlobalVariables.speed + 1f;
            interval = interval + 10;
        }
    }
}
