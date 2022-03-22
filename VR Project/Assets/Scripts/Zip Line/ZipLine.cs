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

    public CharacterController character;
    private bool zipLineOffset = false;

    private float initialDistance = 0;
    private float distance;
    

    // Start is called before the first frame update
    void Start()
    {
        //GameObject go = Instantiate(prefab, startZipLine.transform.position + new Vector3(-1, 0, 0), new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w));

        prefab.transform.position = startZipLine.transform.position + new Vector3(-1, 1, 0);
        prefab.transform.LookAt(endZipLine.transform.position);

        distance = Vector3.Distance(startZipLine.transform.position, endZipLine.transform.position);
    }

    //Update is called once per frame
    void Update()
    {
        if (Climber.climbingHand && Climber.climbingHand.name == "Right Hand" && !rightInput)
        {
            rightInput = true;
            if (rightInput)
            {
                Debug.Log("Grabbing with Right Hand :D)");
                howManyInputs++;
                Debug.Log(howManyInputs);
            }
        }
        if (Climber.climbingHand && Climber.climbingHand.name == "Left Hand" && !leftInput)
        {
            leftInput = true;
            if (leftInput)
            {
                Debug.Log("Grabbing with Left Hand :D)");
                howManyInputs++;
                Debug.Log(howManyInputs);
            }
        }
        else if (!Climber.climbingHand && howManyInputs > 0)
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
