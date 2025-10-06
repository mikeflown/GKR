using UnityEngine;
using DialogueEditor;

public class TeleportManager : MonoBehaviour
{
    public Transform teleport; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleport.transform.position;
        }
    }
}