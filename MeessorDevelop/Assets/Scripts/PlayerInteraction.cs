using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCam;
    public float interactionDistance = 4f;

    public GameObject interactioaUI;
    public TextMeshProUGUI interactionText;

    private void Update()
    {
        InteractionRay();
    }

   void InteractionRay()
   {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            Interactble interactble = hit.collider.GetComponent<Interactble>();

            if (interactble != null)
            {
                hitSomething = true;
                interactionText.text = interactble.GetDescription();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactble.Interact();
                }
            }
        }
        interactioaUI.SetActive(hitSomething);
   }
}
