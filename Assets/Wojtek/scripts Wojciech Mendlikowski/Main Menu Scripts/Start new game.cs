using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startnewgame : MonoBehaviour
{
    [SerializeField] private SceneScriptableObject scene;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnStartGameButtonClick() 
    {
        SceneManager.LoadScene(scene.sceneName);
    }

}
