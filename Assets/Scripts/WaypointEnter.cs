using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnter : MonoBehaviour
{
    public PathWalkAI player;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "player")
        {
        Debug.Log("Entered!");
        player.NextWaypoint();
        }
    }
}
