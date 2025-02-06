using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    //public Transform[] waypoints;
    int currentWaypoint = 0;
    int newWaypoint = 0;
    public float speed;
    [SerializeField] PlanetsTrack planetsTrack;
    void Start()
    {
        
    }

    void Update()
    {
       MovePlayer();
    }

    public void MovePlayer()
    {
        transform.LookAt(planetsTrack.planets[currentWaypoint].transform.position);
        if (Vector3.Distance(transform.position, planetsTrack.planets[currentWaypoint].transform.position) >= 0.1f)
        {
            transform.Translate(0,0, speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(0,0, 0);
        }
    }

    public void MoveForward()
    {
        currentWaypoint++;
        if (currentWaypoint > planetsTrack.planets.Count - 1)
        {
            currentWaypoint = 0;
        }
    }

    public void MoveBackwards()
    {
        currentWaypoint--;
        if (currentWaypoint < 0)
        {
            currentWaypoint = planetsTrack.planets.Count - 1;
        }
    }
}
