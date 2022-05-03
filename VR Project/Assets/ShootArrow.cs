using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootArrow : TwoHandGrabInteractable
{
    public float speed = 10;
    public GameObject arrow;
    public Transform spawnPos;

    //possible way to interact with controller

    public void Shoot()
    {
        GameObject spawnedArrow = Instantiate(arrow, spawnPos.position, spawnPos.rotation);


        //audioSource.PlayOneShot();

        //implement corruoutine to destroy arrow after X amount of seconds. 7 maybe
    }
}
