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

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        int howManyKeys = keyScriptableObject.Keys.Count;
        string textValue = howManyKeys.ToString();

         textElement.text  = textValue;
    }
}
