using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour  {

   
    void Update() {
 
      
    }

    public KeyScriptableObject keyScriptableObject;
    public void Start() {
        keyScriptableObject.Keys.Clear();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<ICollectableItem>()!= null) { 
             other.GetComponent<ICollectableItem>().Collect();

        }
    }

    
    }


 
