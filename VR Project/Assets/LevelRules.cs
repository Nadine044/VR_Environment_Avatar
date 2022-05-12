using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class LevelRules : MonoBehaviour
{
    public GameObject barrier;

    //---- COLLECTIBLES ----------------
    public GameObject collectible_prefab;

    private GameObject collectible1;

    public int total_collectibles_discovered = 0;
    public int TUTORIAL_green_counter;

    //HAND COLLISION
    bool button_pressed = true;

    //LEVERS
    public Material activated_green;
    public GameObject TUTORIAL_Lever;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (counter == 3)
        //{
        //    barrier.SetActive(false);
        //}

        if (TUTORIAL_green_counter == 4)
        {
            //barrier.SetActive(false);
            //collectible1 = Instantiate(collectible_prefab, new Vector3(-167.10f, 0.35f, 63.85f), new Quaternion(90.0f, 0.0f, 0.0f, 0.0f));
            TUTORIAL_green_counter = 0;
            TUTORIAL_Lever.GetComponent<MeshRenderer>().material = activated_green;
        }

        if (InputBridge.Instance.AButton)
        {
            Destroy(collectible1);

            if (button_pressed)
            {
                total_collectibles_discovered++;
                button_pressed = false;
            }
        }
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.gameObject.tag == "RightController")
    //    {
    //        Destroy(collectible1);
    //        total_collectibles_discovered++;
    //    }        
    //}
}
