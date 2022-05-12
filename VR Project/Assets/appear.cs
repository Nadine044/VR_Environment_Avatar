using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public GameObject PREFAB_COLLECTIBLE;
    private GameObject collectibleActivatedLever;
    public Transform parent_Collectibles;
    public Vector3 position;
    public Quaternion rotation;

    public GameObject destroyLever;


    private bool instantiated = false;
    public void AppearAfterLever()
    {
        if (!instantiated)
        {
            collectibleActivatedLever = Instantiate(PREFAB_COLLECTIBLE, position, rotation);
            collectibleActivatedLever.transform.parent = parent_Collectibles;
        }
        instantiated = true;
        Destroy(destroyLever);
    }

    public void DestroyLever()
    {
        Destroy(destroyLever);
    }
}
