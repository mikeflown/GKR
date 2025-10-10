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
        if (isOn) return "Нажмите [E] чтобы выключить <color=red>off</color> свет.";
        return "Нажмите [E] чтобы включить <color=green>on</color> свет.";
    }

    public void Interact()
    {
        isOn = !isOn;
        m_Light.enabled = isOn;
    }
}
