using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysAndPlayerTest : MonoBehaviour, Icollectable {

    public List<int> keys = new List<int>();
    int key;
    string _COLLECTABLE = "collectable";

    
    void Update() {
        if (keys.Count == 3)
        {
            Debug.Log("You have 3 keys");
        }
    }

    private void Keys() {
        keys.Add(key);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == _COLLECTABLE)
        {
            Keys();
        }
    }
}