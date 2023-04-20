using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {

    string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == playerTag)
        {
            Debug.Log("hit!");
            Destroy(this.gameObject);
        }
    }
}

