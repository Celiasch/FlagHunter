using UnityEngine;

public class Movement : MonoBehaviour {

	void Update () {
        transform.Translate(0, Time.deltaTime * 2, 0, Space.World);
    }
}
