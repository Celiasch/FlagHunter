using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;

    void Start()
    {
        //assign boundaries values for the player moving 
        minPosLeft = -2.60f;
        maxPosRight = 2.60f;
        padding = 0.3f;

        SetupMoveBoundaries();
    }

    void Update()
    {
        Move();
    }
    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);
        transform.position = new Vector2(newPosX, transform.position.y);
    }

    private void SetupMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        minPosLeft = gameCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x + padding;
        maxPosRight = gameCamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x - padding;

    }
}