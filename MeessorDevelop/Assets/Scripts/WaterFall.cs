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
        if (isOpen) return "������� [E] ����� ������ ����";
        return "������� [E] ����� ���������� ����";
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
