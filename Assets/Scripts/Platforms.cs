using UnityEngine;

public class Platforms : MonoBehaviour

{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            ScoreScript.scoreValue += 1;
        }

    }
}