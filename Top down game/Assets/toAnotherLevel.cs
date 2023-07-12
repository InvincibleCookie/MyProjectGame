using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel : MonoBehaviour
{
    [SerializeField] private string sceneName; // Поле для перетаскивания сцены в инспекторе

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName); // Загружаем указанную сцену
        }
    }
}
