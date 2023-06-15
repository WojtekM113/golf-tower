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
    [SerializeField] private GameObject UiButtonMainMenu;
    private bool CanShowButton;
    private int i = 0;
    
    void Start()
    {
        Time.timeScale = 1;
        CanShowButton = false;
        confettiParticle.Stop();
        UiButtonNextLevel.SetActive(false);
        UiButtonStartAgain.SetActive(false);
        UiButtonMainMenu.SetActive(false);
    }

     
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && i == 0)
        {
            i = 1;
            UiButtonMainMenu.SetActive(true);
            UiButtonStartAgain.SetActive(true);
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && i == 1)
        {
            i = 0; 
            UiButtonMainMenu.SetActive(false);
            UiButtonStartAgain.SetActive(false);
            Time.timeScale = 1;
        }

      
            
            
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
        UiButtonMainMenu.SetActive(true);
    }
}
