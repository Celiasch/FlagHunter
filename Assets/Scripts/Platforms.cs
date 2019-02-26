using UnityEngine;

public class Platforms : MonoBehaviour

{

    void Update()

    {
        transform.Translate(0, Time.deltaTime * 1, 0, Space.World);

    }

}