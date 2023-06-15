using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private float volume = 0.5f;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            audioSource.PlayOneShot(audioClip, volume);
        }
    }
}


 
