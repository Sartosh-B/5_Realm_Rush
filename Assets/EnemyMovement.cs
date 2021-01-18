using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoints> path;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintAllWaypionts());
    }

    IEnumerator PrintAllWaypionts()
    {
        print("Starting patrol...");
        foreach (Waypoints waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("Visiting block: " + waypoint.name);
            yield return new WaitForSeconds(1f);
        }
        print("Ending patrol...");
    }

    // Update is called once per frame
    void Update()
    {

    }
}