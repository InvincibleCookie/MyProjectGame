using UnityEngine;

public class EnemyCollis : MonoBehaviour
{
    private Vector2 enemyStartPosition;
    private Timer timerController;
    private realTimeTimer RealtimerController;

    private void Start()
    {
        enemyStartPosition = transform.position;
        timerController = FindObjectOfType<Timer>();
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
        EnemyCollis[] enemies = FindObjectsOfType<EnemyCollis>();
        foreach (EnemyCollis enemy in enemies)
        {
            enemy.transform.position = enemy.enemyStartPosition;
        }
    }

    private void ResetTimer()
    {
        if (timerController != null)
        {
            timerController.ResetTimer();
            RealtimerController.ResetTimer();
        }
    }
}
