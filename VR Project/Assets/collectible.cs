using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    public AudioSource source;
    public AudioClip sfx;

    private void OnTriggerEnter(Collider other)
    {
        
        StartCoroutine(playSFX());
    }

    IEnumerator playSFX()
    {
        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
        Destroy(gameObject);
    }
}
