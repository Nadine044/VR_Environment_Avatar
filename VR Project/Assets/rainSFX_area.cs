using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainSFX_area : MonoBehaviour
{
    public GameObject trigger;
    public AudioSource clip;
    public AudioSource indoorRain;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Main Camera")
        {
            trigger.SetActive(true);
            clip.Pause();
            indoorRain.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Main Camera")
        {
            clip.Play();
            indoorRain.Pause();
        }
    }
}
