using UnityEngine;

public class EnemyCollis2 : MonoBehaviour
{
    private Vector2 enemyStartPosition;
    private realTimeTimer RealtimerController;

    private void Start()
    {
        enemyStartPosition = transform.position;
        RealtimerController = FindObjectOfType<realTimeTimer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(-10f, 0f);
            ResetEnemiesPosition();
            ResetTimer();
        }
    }

    private void ResetEnemiesPosition()
    {
        EnemyCollis2[] enemies = FindObjectsOfType<EnemyCollis2>();
        foreach (EnemyCollis2 enemy in enemies)
        {
            enemy.transform.position = enemy.enemyStartPosition;
        }
    }

    private void ResetTimer()
    {
        if (RealtimerController != null)
        {
            RealtimerController.ResetTimer();
        }
    }
}
