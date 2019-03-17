using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject flagColor;
    private System.Random rnd = new System.Random();

    void Start ()
    {
        SpriteRenderer flagRenderer = flagColor.GetComponent<SpriteRenderer>();
        byte r = (byte)rnd.Next(0, 256);
        byte g = (byte)rnd.Next(0, 256);
        byte b = (byte)rnd.Next(0, 256);
        byte a = (byte)rnd.Next(100, 256); 
        //100 so colors dont get to light and not easy to see

        flagRenderer.color = new Color32(r, g, b, a);
    }
}
