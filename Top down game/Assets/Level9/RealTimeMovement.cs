using UnityEngine;

public class realTimeEnemyMovement : MonoBehaviour
{
    public float minX = -10.4f;
    public float maxX = 9.643f;
    public float minY = -5.373f;
    public float maxY = 5.373f;
    public float speed = 20f;

    private Vector2 direction;
    private bool isMoving = true;

    private void Start()
    {
        direction = GetRandomDirection();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMoving = !isMoving;
        }

        if (isMoving)
        {
            Vector3 currentPosition = transform.position;

            float newX = currentPosition.x + speed * direction.x * Time.deltaTime;
            float newY = currentPosition.y + speed * direction.y * Time.deltaTime;

            if (newX < minX || newX > maxX)
            {
                direction.x *= -1;
            }

            if (newY < minY || newY > maxY)
            {
                direction.y *= -1;
            }

            newX = Mathf.Clamp(newX, minX, maxX);
            newY = Mathf.Clamp(newY, minY, maxY);

            transform.position = new Vector3(newX, newY, currentPosition.z);
        }
    }

    private Vector2 GetRandomDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        return new Vector2(randomX, randomY).normalized;
    }
}
