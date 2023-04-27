using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour  {

     
    float speed = 10f;
    void Update() {

        float horizontalInput = (Input.GetAxis("Horizontal")) * speed * Time.deltaTime;
        transform.Translate(horizontalInput, 0, 0);
        
      
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


 
