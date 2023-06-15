using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonsScript : MonoBehaviour
{
    
    public  void OnNewGameButtonClick()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnLoadGameButtonClick()
    {
        Debug.Log("scene)");
    }

    public void OnExitToDesktop()
    {
        Application.Quit();
    }
}
