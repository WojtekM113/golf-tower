using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour, ICollectableItem {
    public KeyScriptableObject keyScriptableObject;
    public void OnCollected() {
        Debug.Log("hit! and destroyed");
        Destroy(this.gameObject);
        keyScriptableObject.Keys.Add(1);
         
    }
   

    public void Collect() {
        OnCollected();
        Debug.Log(keyScriptableObject.Keys.Count);
    }
    
    
 }


