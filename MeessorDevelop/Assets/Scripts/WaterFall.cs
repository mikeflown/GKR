using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaterFall : MonoBehaviour, Interactble
{
    public Animator m_Animator;
    public bool isOpen;
    
    void Start()
    {
        if (isOpen)
            m_Animator.SetBool("isOpen", true);
    }

    public string GetDescription()
    {
        if (isOpen) return "Нажмите [E] чтобы подать воду";
        return "Нажмите [E] чтобы остановить воду";
    }
    
    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
            m_Animator.SetBool("isOpen", true);
        else
            m_Animator.SetBool("isOpen", false);
    }
}
