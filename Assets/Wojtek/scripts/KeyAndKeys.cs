using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAndKeys : MonoBehaviour, ICollectableItem
{
   
    public List<int> keys = new List<int>();
    int key = 0;    



    void Update() {
        if (keys.Count == 3)
        {
            Debug.Log("You have 3 keys");
        }
    }

    private void Keys() {
        keys.Add(key);

    }

    public void Collect() {
        Keys();
    }
}
