using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour, ICollectableItem {
    public void OnCollected() {
        Debug.Log("hit! and destroyed");
        Destroy(this.gameObject);

    }
       
    public void Collect() {
 
        OnCollected();
    }
 }


