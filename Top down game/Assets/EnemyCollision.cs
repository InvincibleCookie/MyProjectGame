using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyCollis : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(-10f, 0f);
        }
    }
}
