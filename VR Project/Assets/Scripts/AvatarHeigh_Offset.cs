using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarHeigh_Offset : MonoBehaviour
{
    public Transform avatarHeigh;
    private Vector3 offset;
    private bool onceDone = false;

    void Start()
    {
        offset = new Vector3(0.0f, 0.9f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!onceDone)
        {
            avatarHeigh.position = avatarHeigh.position + offset;
            onceDone = true;
        }
    }
}
