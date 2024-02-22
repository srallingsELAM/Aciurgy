using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Waypoints : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    
    public Vector2 moveDirection;
    private Waypoints Wpoints;

    private int waypointIndex;

    [SerializeField] float speed = 1f;





    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            float moveX = (transform.position.x - waypoints[currentWaypointIndex].transform.position.x) * -1f;
            float moveY = (transform.position.y - waypoints[currentWaypointIndex].transform.position.y) * -1f;
            moveDirection = new Vector2(moveX, moveY).normalized;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);

     


    }
   

}

