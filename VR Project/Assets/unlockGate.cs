using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockGate : MonoBehaviour
{
    public int count = 0;
    public int targetRequirement = 1;
    public GameObject barrier;

    // Update is called once per frame
    void Update()
    {
        if (count == targetRequirement)
        {
            barrier.active = false;
            count = 0;
        }
    }

    public void AddPoint()
    {
        count++;
    }

    public void RemoveBarrier_Lever()
    {
        barrier.SetActive(false);
    }

    public void ActivateBarrier_Lever()
    {
        barrier.SetActive(true);
    }
}
