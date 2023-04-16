using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GetUp : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.GetComponent<NavMeshAgent>().enabled == false)
        {
            StartCoroutine(StandUp());
        }
    }

    IEnumerator StandUp()
    {
        yield return new WaitForSeconds(15);
        this.gameObject.GetComponent<NavMeshAgent>().enabled = true;
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
}
