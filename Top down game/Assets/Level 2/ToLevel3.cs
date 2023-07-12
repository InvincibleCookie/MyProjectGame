using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
