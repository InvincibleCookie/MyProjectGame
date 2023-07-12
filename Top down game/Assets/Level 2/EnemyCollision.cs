using UnityEngine;
using TMPro;

public class EnemyInteraction : MonoBehaviour
{
    public TextMeshPro textObject;
    public bool hasDied = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(-10f, 0f);
            textObject.text = "Я тебя предупреждал";
            hasDied = true;
        }
    }
}
