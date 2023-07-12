using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float minY = -4.75f;  // ����������� �������� �� ��� y
    public float maxY = 4.66f;   // ������������ �������� �� ��� y
    public float speed = 2f;     // �������� �������� �����

    public int direction = 1;   // ����������� ��������: 1 - �����, -1 - ����

    private void Update()
    {
        // �������� ������� ������� �����
        Vector3 currentPosition = transform.position;

        // ��������� ����� ������� �����
        float newY = currentPosition.y + speed * direction * Time.deltaTime;
        newY = Mathf.Clamp(newY, minY, maxY);  // ������������ �������� ����� � �������� minY � maxY

        // ��������� ������� �����
        transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);

        // �������� �����������, ���� ���������� �������
        if (newY == minY || newY == maxY)
        {
            direction *= -1;
        }
    }
}
