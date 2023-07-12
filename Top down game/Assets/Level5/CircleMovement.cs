using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed = 5f; // Скорость движения объекта врага
    public float radius = 5f; // Радиус круга

    private Vector2 centerPosition; // Позиция центра круга
    private float angle = 0f; // Угол для определения позиции на круге

    private void Start()
    {
        centerPosition = transform.position; // Устанавливаем центр круга как начальную позицию объекта врага
    }

    private void Update()
    {
        // Вычисляем новую позицию на круге с помощью тригонометрии
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.y + Mathf.Sin(angle) * radius;

        // Устанавливаем новую позицию объекта врага
        transform.position = new Vector2(x, y);

        // Увеличиваем угол для следующего кадра
        angle += speed * Time.deltaTime;

        // Если угол стал больше 360 градусов, сбрасываем его до 0
        if (angle >= 360f)
        {
            angle = 0f;
        }
    }
}
