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

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;

    private Vector3 initial_pos1;
    private Vector3 initial_pos2;
    private Vector3 initial_pos3;
    private Vector3 initial_pos4;

    private void Start()
    {
        initial_pos1 = ball1.transform.position;
        initial_pos2 = ball2.transform.position;
        initial_pos3 = ball3.transform.position;
        initial_pos4 = ball4.transform.position;
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

    public void ReStartBallsPosition()
    {
        ball1.transform.position = initial_pos1;
        ball2.transform.position = initial_pos2;
        ball3.transform.position = initial_pos3;
        ball4.transform.position = initial_pos4;
    }
}
