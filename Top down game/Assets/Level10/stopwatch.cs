using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public TextMeshPro timerText;
    public float targetTime;
    private float elapsedTime;
    private bool isRunning;
    private bool isPaused;
    private EnemyCollis2[] enemies;

    private void Start()
    {
        isRunning = true;
        isPaused = false;
        enemies = FindObjectsOfType<EnemyCollis2>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (!isPaused)
            {
                isRunning = true;
            }
        }

        if (isRunning && !isPaused)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();

            if (elapsedTime >= targetTime)
            {
                ActivateActions();
            }
        }
    }

    private void UpdateTimerUI()
    {
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 1000f) % 1000f);

        timerText.text = string.Format("{0:00}:{1:000}", seconds, milliseconds);
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        elapsedTime = 0f;
        UpdateTimerUI();
    }

    private void ActivateActions()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = new Vector2(-10f, 0f);
        }

        foreach (EnemyCollis2 enemy in enemies)
        {
            enemy.ResetEnemiesPosition();
        }

        ResetTimer();
    }
}
