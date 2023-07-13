using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed = 5f;
    public float radius = 5f;

    private Vector2 centerPosition;
    private float angle = 0f;

    private bool isPaused = false;
    private float initialSpeed;

    private void Start()
    {
        centerPosition = transform.position;
        initialSpeed = speed;
    }

    private void Update()
    {
        if (!isPaused)
        {
            Move();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void Move()
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

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            speed = 0f;
        }
        else
        {
            speed = initialSpeed;
        }
    }

    public void ResumeFromPause()
    {
        isPaused = false;
        speed = initialSpeed;
    }
}
