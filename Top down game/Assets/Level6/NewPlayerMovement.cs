using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;
    public EnemyMovement2 enemyMovement;
    public bool isPaused = false;

    void Update()
    {
        if (!isPaused)
        {
            ProcessInputs();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void FixedUpdate()
    {
        if (!isPaused)
        {
            Move();
        }
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

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            rb.velocity = Vector2.zero;
        }

    }
    public void ResumeFromPause()
    {
        isPaused = false;
    }

}
