using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectForShove : MonoBehaviour
{
    public PathWalkAI characterController;
    private Vector3 targetPos;
    private GameObject target;

    private void OnTriggerEnter(Collider collider) 
    {
        if(collider.tag == "Character")
        {
            Debug.Log("Detected!" + collider.gameObject.name);
            target = collider.gameObject;
            targetPos = target.transform.position;
            characterController.SetAiTargetLocation(targetPos);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject == target)
        {
            characterController.SetAiTargetLocation(characterController.waypointPos);
        }
    }
}
