using UnityEngine;

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
        //Flag Touch = Win and get values from timer and score
        if (collision.tag == TAGPLAYER && gameObject.tag == TAGFLAG)
        {
            scoreTimeData.score = ScoreScript.scoreValue;
            scoreTimeData.timer = timer.timer;
            sceneLoader.GoToWinScene();
        }
        //Sea Touch = Death
        else if (collision.tag == TAGPLAYER && gameObject.tag == TAGSEA)
        {
            sceneLoader.GoToGameOverScene();
        }
        //Ice Touch = Death
        else if (collision.tag == TAGPLAYER && gameObject.tag == TAGICE)
        {
            sceneLoader.GoToGameOverScene();
        }
    }
}
