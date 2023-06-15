using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyCollision : MonoBehaviour, ICollectableItem
{

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip keyCollected;
    public KeyScriptableObject keyScriptableObject;
    private float volume = 0.5f;
    public void OnCollected() 
    {
        Debug.Log("hit! and destroyed");
        this.gameObject.SetActive(false);
        keyScriptableObject.Keys.Add(1);
        audioSource.PlayOneShot(keyCollected, volume);
    }



    public void Collect() {

        OnCollected();
        Debug.Log(keyScriptableObject.Keys.Count);
    }


}

