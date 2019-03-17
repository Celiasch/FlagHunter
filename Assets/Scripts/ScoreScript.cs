using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public static int scoreValue = 0;
    Text score;

	void Start () {
        score = GetComponent<Text> ();
        //reset score to 0
        scoreValue = 0;
	}
	
	void Update () {
        //Display Score Text on Game Screen
        score.text = "Touched: " + scoreValue;
	}
}
