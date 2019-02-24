using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public Text collected;

    private const string TAGPLAYER = "Player";
    private const string TAGSEA = "Sea";
    private const string TAGICE = "Ice";
    private const string TAGFLAG = "Flag";

    public SceneLoader sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == TAGPLAYER && gameObject.tag == "Flag")
        {

            Destroy(gameObject);
            sceneLoader.GoToWinScene();
        }

        else if (collision.tag == TAGPLAYER && gameObject.tag == "BadApple")
        {
            sceneLoader.GoToGameOverScene();
        }

    }

}
