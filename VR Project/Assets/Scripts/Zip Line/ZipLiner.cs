using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ZipLiner : MonoBehaviour
{
    private CharacterController character;
    public static XRController hand;
    private ContinuousMovement continuousMovement;

    void Start()
    {
        character = GetComponent<CharacterController>();
        continuousMovement = GetComponent<ContinuousMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hand)
        {
            continuousMovement.enabled = false;
            Grab();
        }
        else
        {
            continuousMovement.enabled = true;
        }
    }

    //Climbing Computations
    void Grab()
    {
        InputDevices.GetDeviceAtXRNode(hand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);
        character.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
    }
}
