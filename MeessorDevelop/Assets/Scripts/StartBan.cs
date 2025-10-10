using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject targetObjectTwo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            targetObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            targetObjectTwo.SetActive(false);
        }
    }
}