using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Ladder : MonoBehaviour
{
    float speed = 10;
    ActionBasedContinuousMoveProvider mover;
    bool moveUp = false;
    bool moveForward = false;
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        mover = GetComponent<ActionBasedContinuousMoveProvider>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveUp == true)
        {
            mover.useGravity = false;
            cc.Move(transform.up * speed * Time.fixedDeltaTime);
        }

        if (moveForward == true)
        {
            moveUp = false;
            mover.useGravity = true;
            cc.Move(transform.forward * speed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ladder End")
        {
            moveUp = true;
        }

        if (other.tag == "Ladder End 2")
        {
            moveForward = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ladder End 2")
        {
            moveForward = false;
        }
    }
}
