using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    private bool check_collided;
    public ParticleSystem fire_spark;
    public AudioSource audio_spark;

    public bool IsCollided
    {
        get { return check_collided; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stone")
        {
            check_collided = true;
            fire_spark.Play();
            audio_spark.Play();
        }
    }

    public void ResetCollision()
    {
        check_collided = false;
    }
}
