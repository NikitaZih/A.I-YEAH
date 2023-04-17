using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BadZombies : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Transform otherPlayer;

    public float timer, wanderTime;

    public enum State
    {
        FindCharacter,
    }

    private State currentState;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        currentState = State.FindCharacter;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case State.FindCharacter:

                SetAITargetLocation(otherPlayer.position);
                break;
        }
    }

    private void SetAITargetLocation(Vector3 targetLocation)
    {
        navMeshAgent.SetDestination(targetLocation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;
        {
            Destroy(gameObject);
        }
    }
}
