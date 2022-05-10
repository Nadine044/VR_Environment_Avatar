using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRules : MonoBehaviour
{
    public GameObject barrier;
    public int counter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 3)
        {
            barrier.active = false;
        }
    }
}
