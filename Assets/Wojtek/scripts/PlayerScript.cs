using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour, ICollectableItem {
   
     
    public void Collect() {
         
    }

    private void OnTriggerEnter2D(Collider2D collision) {
       ICollectableItem collectableItem = collision.GetComponent<ICollectableItem>();
        if (collectableItem != null) { 
        
            collectableItem.Collect();
        }
    }





    float speed = 10f;

    // Update is called once per frame
    void Update() {

        float horizontalInput = (Input.GetAxis("Horizontal")) * speed * Time.deltaTime;

        transform.Translate(horizontalInput, 0, 0);

    }
}
