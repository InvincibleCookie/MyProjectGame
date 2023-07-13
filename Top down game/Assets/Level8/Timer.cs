using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timerDuration = 10f;
    public string nextSceneName;
    public TextMeshPro timerText;

    private float timer;
    private bool isPlayerMoving;
    private PlayerMovement2 playerMovement;

    private void Start()
    {
        timer = timerDuration;
        playerMovement = FindObjectOfType<PlayerMovement2>();
    }

    private void Update()
    {
        isPlayerMoving = IsPlayerMoving();

        if (isPlayerMoving)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                LoadNextScene();
            }
        }
        UpdateTimerText();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    private bool IsPlayerMoving()
    {
        if (playerMovement && playerMovement.rb.velocity.magnitude > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
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
