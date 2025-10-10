using UnityEngine;

public class LightSwitch : MonoBehaviour, Interactble
{
    public Light m_Light;
    public bool isOn;

    void Start()
    {
        m_Light.enabled = isOn;
    }
    
    public string GetDescription()
    {
        if (isOn) return "������� [E] ����� ��������� <color=red>off</color> ����.";
        return "������� [E] ����� �������� <color=green>on</color> ����.";
    }

    public void Interact()
    {
        isOn = !isOn;
        m_Light.enabled = isOn;
    }
}
