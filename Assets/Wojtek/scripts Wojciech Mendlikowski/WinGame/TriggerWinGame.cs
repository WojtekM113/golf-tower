using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWinGame : MonoBehaviour

{
    [SerializeField] private AudioClip congratulationsAduio;

    [SerializeField] private ParticleSystem confettiParticle;
    [SerializeField] private GameObject UiButtonNextLevel;
    [SerializeField] private GameObject UiButtonStartAgain;
    private bool CanShowButton;
    
    void Start()
    {
        CanShowButton = false;
        confettiParticle.Stop();
        UiButtonNextLevel.SetActive(false);
        UiButtonStartAgain.SetActive(false);
    }

     
    void Update()
    {
        if (CanShowButton)
        {
            ActivateButtons();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CanShowButton = true;
            PlayParticle();
            PlaySound();
            ActivateButtons();
          
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

    private void ActivateButtons()
    {
        UiButtonNextLevel.SetActive(true);
        UiButtonStartAgain.SetActive(true);
    }
}
