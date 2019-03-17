using UnityEngine;

public class Movement : MonoBehaviour {

	void Update () {
        //make Platforms go up 
        transform.Translate(0, Time.deltaTime * 2, 0, Space.World);
    }
}
