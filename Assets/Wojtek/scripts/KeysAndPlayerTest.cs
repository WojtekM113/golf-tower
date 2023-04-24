using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeysAndPlayerTest : MonoBehaviour, ICollectableItem {
   
   
    public void Collect() {
         
    }

    private void OnTriggerEnter2D(Collider2D collision) {
       ICollectableItem collectableItem = collision.GetComponent<ICollectableItem>();
        if (collectableItem != null) { 
        
            collectableItem.Collect();
        }
    }
}
