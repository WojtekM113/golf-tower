using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField] private SceneScriptableObject scene;
    public void OnClick()
     {   string nameOfTheScene = scene.sceneName;
         SceneManager.LoadScene(nameOfTheScene);
     }

    public void OnExitToDesktopClick()
    {
        Application.Quit();
    }
}
