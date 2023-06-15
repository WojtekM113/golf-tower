 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

 public class ButtonNextLevelScript : MonoBehaviour
 {

     public SceneScriptableObject scene;

     
    public void OnClick()
    {
        string nameOfTheScene = scene.sceneName;
        SceneManager.LoadScene(nameOfTheScene);
    }
 
}
