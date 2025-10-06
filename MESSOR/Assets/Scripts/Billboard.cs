using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player; // ������ �� ������

    private void LateUpdate()
    {
        // ��������� ����������� � ������
        Vector3 direction = player.position - transform.position;

        // ������� ������� �� ������ �����������
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        // ��������� �������
        transform.rotation = lookRotation;
    }
}