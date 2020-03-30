using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupFruit : MonoBehaviour
{
    protected static bool isFirstPickup = true;
    protected bool triggered = false;
    protected static bool soundEffectsOn = true;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !triggered)
        {
            Pickup();
            triggered = true;
        }
    }

    public void Pickup()
    {
        if (IsFirstPickup())
        {
            StartCoroutine(ShowTutorialText());
            isFirstPickup = false;
        }

        


        if (AreSoundEffectsOn())
        {
            PlaySoundEffect();
        }

        StartCoroutine(MakeFruitDisappear());

    }

    protected virtual bool IsFirstPickup()
    {
        return isFirstPickup;
    }

    public abstract IEnumerator ShowTutorialText();

    public virtual bool AreSoundEffectsOn()
    {
        return soundEffectsOn;
    }

    public abstract void PlaySoundEffect();

    public virtual IEnumerator MakeFruitDisappear()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }


}
