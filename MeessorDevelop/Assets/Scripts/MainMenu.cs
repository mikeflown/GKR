using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Game"); // в кавычках название сцены на которую осуществляется переход
    }
    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}
