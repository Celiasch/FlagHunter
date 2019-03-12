using UnityEngine;
using UnityEngine.UI;

public class Bondaries : MonoBehaviour
{
    private const string TAGPLAYER = "Player";
    private const string TAGSEA = "Sea";
    private const string TAGICE = "Ice";
    private const string TAGFLAG = "Flag";

    public SceneLoader sceneLoader;
    public Timer timer;
    public ScoreTimeData scoreTimeData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAGPLAYER && gameObject.tag == "Flag")
        {
            scoreTimeData.score = ScoreScript.scoreValue;
            scoreTimeData.timer = timer.timer;
            sceneLoader.GoToWinScene();
        }

        else if (collision.tag == TAGPLAYER && gameObject.tag == "Sea")
        {
            sceneLoader.GoToGameOverScene();
        }
        else if (collision.tag == TAGPLAYER && gameObject.tag == "Ice")
        {
            sceneLoader.GoToGameOverScene();
        }
    }
}
