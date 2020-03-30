using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Apple : PickupFruit
{
    public GameObject tutorialText;

    public AudioClip PickupClip;
    AudioSource audioSource;

    void Awake()
    {
        tutorialText = GameObject.FindGameObjectWithTag("PickupTutorial");
    }

    void Start()
    {
        if (tutorialText.activeSelf)
        {
            tutorialText.SetActive(false);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public override IEnumerator ShowTutorialText()
    {
        tutorialText.SetActive(true);
        yield return new WaitForSeconds(5);
        tutorialText.SetActive(false);
    }

    public override void PlaySoundEffect()
    {
        audioSource.PlayOneShot(PickupClip);
    }
}

