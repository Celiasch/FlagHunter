using UnityEngine;

public class Platforms : MonoBehaviour

{

    void Update()

    {
        transform.Translate(0, Time.deltaTime * 2, 0, Space.World);

    }

}