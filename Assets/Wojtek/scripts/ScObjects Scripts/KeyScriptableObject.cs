using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Key",menuName = "ScriptableObjects/KeyScriptableObject", order = 1)]
public class KeyScriptableObject : ScriptableObject  
{
    public List<int> Keys = new List<int>();
     
  
}
