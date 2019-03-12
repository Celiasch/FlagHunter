using UnityEngine;

public class Platforms : MonoBehaviour
{
    string player = "Player";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(player))
        {
            ScoreScript.scoreValue += 1;
        }
    }
}