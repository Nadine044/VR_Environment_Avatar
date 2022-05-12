using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class LevelRules : MonoBehaviour
{
    public GameObject barrier_green_1;

    //---- COLLECTIBLES ----------------
    public GameObject collectible_prefab;
    public Transform parent_Collectibles;
    public Quaternion rotation;

    private GameObject collectible1;
    private GameObject collectible2;
    private GameObject collectible3;
    private GameObject collectible4;
    private GameObject collectible5;
    private GameObject collectible6;

    public int total_collectibles_discovered = 0;
    //COUNTERS

    public int TUTORIAL_green_counter;
    public int green_1_counter;

    //LEVERS
    public Material activated_green;
    public GameObject TUTORIAL_Lever;

    // Start is called before the first frame update
    void Start()
    {
        collectible1 = Instantiate(collectible_prefab, new Vector3(-173.8f, 31.55f, 14.68f), rotation);
        collectible1.transform.parent = parent_Collectibles;
        collectible2 = Instantiate(collectible_prefab, new Vector3(-183.08f, 31.55f, -15.44f), rotation);
        collectible2.transform.parent = parent_Collectibles;
        collectible3 = Instantiate(collectible_prefab, new Vector3(-162.68f, 25.5f, 6.95f), rotation);
        collectible3.transform.parent = parent_Collectibles;
        collectible4 = Instantiate(collectible_prefab, new Vector3(-108.60f, 6.83f, -52.19f), rotation);
        collectible4.transform.parent = parent_Collectibles;
        collectible5 = Instantiate(collectible_prefab, new Vector3(-166.80f, 20.28f, -37.94f), rotation);
        collectible5.transform.parent = parent_Collectibles;
        collectible6 = Instantiate(collectible_prefab, new Vector3(-140.52f, 13.28f, 94.46f), rotation);
        collectible6.transform.parent = parent_Collectibles;
    }

    // Update is called once per frame
    void Update()
    {

        if (TUTORIAL_green_counter == 4)
        {
            TUTORIAL_green_counter = 0;
            TUTORIAL_Lever.GetComponent<MeshRenderer>().material = activated_green;
        }

        if (green_1_counter == 3)
        {
            green_1_counter = 0;
            barrier_green_1.SetActive(false);
        }

        //if (InputBridge.Instance.AButton)
        //{
        //    Destroy(collectible1);

        //    if (button_pressed)
        //    {
        //        total_collectibles_discovered++;
        //        button_pressed = false;
        //    }
        //}
    }
}
