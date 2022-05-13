using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTag : MonoBehaviour
{
    public string tagName;

    // Start is called before the first frame update
    void Start()
    {
        tagName = gameObject.tag;
    }
}
