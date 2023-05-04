using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeysCollectedUI : MonoBehaviour
{

    public KeyScriptableObject keyScriptableObject;

     
    public TextMeshProUGUI textElement;
    string textValue;


    // Update is called once per frame
    void Update()
    {
        int howManyKeys = keyScriptableObject.Keys.Count;
        string textValue = howManyKeys.ToString();

         textElement.text  = textValue;
    }
}
