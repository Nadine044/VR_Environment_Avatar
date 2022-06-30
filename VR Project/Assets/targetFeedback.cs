using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFeedback : MonoBehaviour
{
    public ParticleSystem particles;
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            particles.Play();
            audio.Play();
        }
    }
}
