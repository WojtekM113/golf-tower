using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWinGame : MonoBehaviour

{
    [SerializeField] private AudioClip congratulationsAduio;

    [SerializeField] private ParticleSystem confettiParticle;
    
    void Start()
    {
        confettiParticle.Stop();
    }

     
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayParticle();
            PlaySound();
        }

    }

    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(congratulationsAduio, transform.position);
    }

    private void PlayParticle()
    {
         
        confettiParticle.Play();
    }
   
}
