using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ZipLine : MonoBehaviour
{
    public GameObject prefab;
    public GameObject startZipLine;
    public GameObject endZipLine;

    int howManyInputs = 0;
    bool rightInput = false;
    bool leftInput = false;

    private bool zipLineOffset = false;
    private float distance;

    public CharacterController character;

    // Start is called before the first frame update
    void Start()
    {
        prefab.transform.position = startZipLine.transform.position + new Vector3(-1, 1, 0);
        prefab.transform.LookAt(endZipLine.transform.position);

        distance = Vector3.Distance(startZipLine.transform.position, endZipLine.transform.position);
    }

    //Update is called once per frame
    void Update()
    {
        if (ZipLiner.hand && ZipLiner.hand.name == "Right Hand" && !rightInput)
        {
            rightInput = true;

            if (rightInput)
            {
                Debug.Log("Grabbing with Right Hand :D)");
                howManyInputs++;
                Debug.Log(howManyInputs);
            }
        }
        if (ZipLiner.hand && ZipLiner.hand.name == "Left Hand" && !leftInput)
        {
            leftInput = true;

            if (leftInput)
            {
                Debug.Log("Grabbing with Left Hand :D)");
                howManyInputs++;
                Debug.Log(howManyInputs);
            }
        }

        //if (Climber.climbingHand && Climber.climbingHand.name == "Right Hand" && !rightInput)
        //{
        //    rightInput = true;
        //    if (rightInput)
        //    {
        //        Debug.Log("Grabbing with Right Hand :D)");
        //        howManyInputs++;
        //        Debug.Log(howManyInputs);
        //    }
        //}
        //if (Climber.climbingHand && Climber.climbingHand.name == "Left Hand" && !leftInput)
        //{
        //    leftInput = true;
        //    if (leftInput)
        //    {
        //        Debug.Log("Grabbing with Left Hand :D)");
        //        howManyInputs++;
        //        Debug.Log(howManyInputs);
        //    }
        //}
        else if (!ZipLiner.hand && howManyInputs > 0)
        {
            howManyInputs--;
            rightInput = false;
            leftInput = false;
            Debug.Log(howManyInputs);
        }

        if (howManyInputs == 2)
        {
            MoveZipLine();
        }
    }

    void MoveZipLine()
    {
        //Lock component Y character

        Debug.Log("USING ZIPLINE!");

        //character.transform.position = Vector3.Lerp(prefab.transform.position, endZipLine.transform.position, 0.02f);
        
        Vector3 pos = character.transform.position;
        Vector3 direc = (endZipLine.transform.position - pos).normalized;

        if (!zipLineOffset)
        {
            prefab.transform.position = prefab.transform.position + new Vector3(0, 0.25f, 0);
            zipLineOffset = true;
        }

        prefab.transform.position += direc * 0.1f;
        character.Move(direc * 0.1f);    
    }
}
