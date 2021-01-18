using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    const int gridSize = 10;

    Vector3 gridPos;
    TextMesh textMesh;
    Waypoints waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoints>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        gridPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        gridPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(gridPos.x, 0f, gridPos.z);
    }

    private void UpdateLabel()
    {
        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = gridPos.x / gridSize + "," + gridPos.z / gridSize;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}