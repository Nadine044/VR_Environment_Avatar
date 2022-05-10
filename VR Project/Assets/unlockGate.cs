using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockGate : MonoBehaviour
{
    [HideInInspector]
    public int count = 0;
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 3)
        {
            barrier.active = false;
        }
    }

    public void AddPoint()
    {
        count++;
    }
}
