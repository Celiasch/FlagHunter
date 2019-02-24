using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void GotoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToWinOverScene()
    {
        SceneManager.LoadScene("WinScene");
    }
    public void GoToGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}