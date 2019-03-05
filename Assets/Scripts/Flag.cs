using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject circleColor;


    private System.Random rnd = new System.Random();


    void Start ()
    {
        SpriteRenderer circleRenderer = circleColor.GetComponent<SpriteRenderer>(); // renamed the SpriteRenderer from circRenderer (not sure if intetional)
        byte r = (byte)rnd.Next(0, 256);
        byte g = (byte)rnd.Next(0, 256);
        byte b = (byte)rnd.Next(0, 256);
        byte a = (byte)rnd.Next(0, 256); // dont if the circle in the apha channel is intentional or by mistake

        circleRenderer.color = new Color32(r, g, b, a);
    }

}
