using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFeedback : MonoBehaviour
{
    public ParticleSystem particles;
    public AudioSource audio;
    public AudioSource fireworks1;
    public AudioSource fireworks2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            particles.Play();
            audio.Play();
            fireworks1.Play();
            fireworks2.Play();
        }
    }
}
