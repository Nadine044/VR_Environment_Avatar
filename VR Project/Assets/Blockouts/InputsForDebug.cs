using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InputsForDebug : MonoBehaviour
{
    public GameObject VRRig;
    public GameObject newTeleportPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void newTeleport()
    {
        VRRig.transform.position = newTeleportPos.transform.position;
    }
}
