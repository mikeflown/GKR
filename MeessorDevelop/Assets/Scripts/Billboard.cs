using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player; // Ссылка на игрока

    private void LateUpdate()
    {
        // Вычисляем направление к игроку
        Vector3 direction = player.position - transform.position;

        // Создаем поворот на основе направления
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        // Применяем поворот
        transform.rotation = lookRotation;
    }
}