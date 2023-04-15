using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathWalkAI : MonoBehaviour
{
    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint4;
    public GameObject waypoint5;
    public GameObject waypoint6;
    public GameObject waypoint7;
    public GameObject waypoint8;
    private Queue<GameObject> waypoints = new Queue<GameObject>();
    private Vector3 waypointPos;
    private GameObject nextWaypoint;

    private NavMeshAgent _navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        waypoints.Enqueue(waypoint1);
        waypoints.Enqueue(waypoint2);
        waypoints.Enqueue(waypoint3);
        waypoints.Enqueue(waypoint4);
        waypoints.Enqueue(waypoint5);
        waypoints.Enqueue(waypoint6);
        waypoints.Enqueue(waypoint7);
        waypoints.Enqueue(waypoint8);
        NextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered!");
        NextWaypoint();
    }

    public void NextWaypoint()
    {
        nextWaypoint = waypoints.Dequeue();
        Debug.Log("going to " + nextWaypoint);
        waypoints.Enqueue(nextWaypoint);
        waypointPos = nextWaypoint.transform.position;
        SetAiTargetLocation(waypointPos);
    }
    private void SetAiTargetLocation(Vector3 targetLocation)
    {
        _navMeshAgent.SetDestination(targetLocation);
    }
}
