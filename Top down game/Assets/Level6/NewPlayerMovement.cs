using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public EnemyMovement2 enemyMovement;

    private Vector2 moveDirection;

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        enemyMovement.SetEnemyMovement(moveDirection.magnitude > 0);
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
