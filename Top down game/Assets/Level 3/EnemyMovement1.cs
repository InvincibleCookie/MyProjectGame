using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float minY = -4.75f;
    public float maxY = 4.66f;
    public float initialSpeed = 2f;

    private float currentSpeed;
    public int direction = 1;
    private bool isPaused = false;

    private void Start()
    {
        currentSpeed = initialSpeed;
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
        Vector3 currentPosition = transform.position;

        float newY = currentPosition.y + currentSpeed * direction * Time.deltaTime;
        newY = Mathf.Clamp(newY, minY, maxY);

        transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);

        if (newY == minY || newY == maxY)
        {
            direction *= -1;
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            currentSpeed = 0f;
        }
        else
        {
            currentSpeed = initialSpeed;
        }
    }

    public void ResumeFromPause()
    {
        isPaused = false;
        currentSpeed = initialSpeed;
    }
}
