using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float minY = -4.75f;  // Минимальное значение по оси y
    public float maxY = 4.66f;   // Максимальное значение по оси y
    public float speed = 2f;     // Скорость движения врага

    public int direction = 1;   // Направление движения: 1 - вверх, -1 - вниз

    private void Update()
    {
        // Получаем текущую позицию врага
        Vector3 currentPosition = transform.position;

        // Вычисляем новую позицию врага
        float newY = currentPosition.y + speed * direction * Time.deltaTime;
        newY = Mathf.Clamp(newY, minY, maxY);  // Ограничиваем движение врага в пределах minY и maxY

        // Обновляем позицию врага
        transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);

        // Изменяем направление, если достигнуты границы
        if (newY == minY || newY == maxY)
        {
            direction *= -1;
        }
    }
}
