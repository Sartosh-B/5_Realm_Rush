using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoints> path;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Waypoints waypoint in path)
        {
            print(waypoint);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}