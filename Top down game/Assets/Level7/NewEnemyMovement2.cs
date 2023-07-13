using UnityEngine;

public class EnemyMovement3 : MonoBehaviour
{
    public float minX = -11f;
    public float maxX = 11f;
    public float minY = -4.75f;
    public float maxY = 4.66f;
    public float speed = 2f;

    private Vector2 direction;
    private PlayerMovement2 playerMovement;

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement2>();
        direction = GetRandomDirection();
    }

    private void Update()
    {
        if (playerMovement && playerMovement.rb.velocity.magnitude > 0)
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
