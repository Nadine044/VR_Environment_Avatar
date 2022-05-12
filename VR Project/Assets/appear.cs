using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    private GameObject collectible;
    public GameObject PREFAB_COLLECTIBLE;
    public Vector3 position;
    public Quaternion rotation;

    public GameObject destroyLever;


    private bool instantiated = false;
    public void AppearAfterLever()
    {
        if (!instantiated)
        {
            collectible = Instantiate(PREFAB_COLLECTIBLE, position, rotation);
        }
        instantiated = true;
        Destroy(destroyLever);
    }

    public void DestroyLever()
    {
        Destroy(destroyLever);
    }
}
