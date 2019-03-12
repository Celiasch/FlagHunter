using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public static int scoreValue = 0;
    Text score;

	void Start () {
        score = GetComponent<Text> ();
        scoreValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Touched: " + scoreValue;
	}
}
