using UnityEngine;
using TMPro;

public class Curiosity : MonoBehaviour
{
    public TextMeshPro textObject;
    private EnemyInteraction enemyInteraction;

    private void Start()
    {
        enemyInteraction = FindObjectOfType<EnemyInteraction>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (enemyInteraction != null && !enemyInteraction.hasDied)
            {
                textObject.text = "Где твоё любопытство?";
            }
        }
    }
}
