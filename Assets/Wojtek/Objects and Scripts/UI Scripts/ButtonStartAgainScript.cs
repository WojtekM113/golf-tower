using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartAgainScript : MonoBehaviour
{
    public SceneScriptableObject scene;
    public void OnClick()
    {
        string nameOfTheScene = scene.sceneName;
        SceneManager.LoadScene(nameOfTheScene);
    }
}
