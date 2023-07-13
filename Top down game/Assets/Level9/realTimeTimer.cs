using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class realTimeTimer : MonoBehaviour
{
    public float timerDuration = 10f;
    public string nextSceneName;
    public TextMeshPro timerText;

    private float timer;
    private bool timerRunning = true;
    private PlayerMovement2 playerMovement;

    private void Start()
    {
        timer = timerDuration;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            timerRunning = !timerRunning;
        }

        if (timerRunning)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                LoadNextScene();
            }

            UpdateTimerText();
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    private void UpdateTimerText()
    {
        if (timerText != null)
        {
            timerText.text = timer.ToString("F2");
        }
    }

    public void ResetTimer()
    {
        timer = timerDuration;
    }
}
