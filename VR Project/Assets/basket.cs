using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    public AudioSource source;
    public AudioClip sfx;
    //public ParticleSystem vfx;

    public Animator bars;
    public Animator wood;

    private bool acitveBars;

    private void Start()
    {
        acitveBars = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(playSFX());
    }

    IEnumerator playSFX()
    {
        source.Play();
        //vfx.Play();
        yield return new WaitWhile(() => source.isPlaying);
    }

    public void playAnimations()
    {
       StartCoroutine(playAnimationss());
    }

    IEnumerator playAnimationss()
    {
        //activeBars = false;

        bars.SetBool("barsDown", true);
        wood.SetBool("play", true);
        yield return new WaitForSeconds(2.0f);
        bars.SetBool("barsDown", false);
        wood.SetBool("play", false);
    }
}
