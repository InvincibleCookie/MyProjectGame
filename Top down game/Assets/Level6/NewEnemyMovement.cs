using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float minY = -4.75f;
    public float maxY = 4.66f;
    public float speed = 2f;

    public int direction = 1;

    public PlayerMovement2 playerMovement;

    private void Update()
    {
        if (playerMovement.rb.velocity.magnitude > 0)
        {
            Vector3 currentPosition = transform.position;

            float newY = currentPosition.y + speed * direction * Time.deltaTime;
            newY = Mathf.Clamp(newY, minY, maxY);

            transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);

            if (newY == minY || newY == maxY)
            {
                direction *= -1;
            }
        }
    }

    public void SetEnemyMovement(bool isMoving)
    {
    }
}
