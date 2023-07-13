using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed = 5f;
    public float radius = 5f;

    private Vector2 centerPosition;
    private float angle = 0f;

    private void Start()
    {
        centerPosition = transform.position;
    }

    private void Update()
    {
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.y + Mathf.Sin(angle) * radius;

        transform.position = new Vector2(x, y);

        angle += speed * Time.deltaTime;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }
}
