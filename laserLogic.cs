using UnityEngine;
using System.Collections;
using UnityEditor;

public class laserLogic: MonoBehavior {
    [ExecuteInEditMode]
    void Update()
    {
        LineRenderer renderer = GetComponent<LineRenderer>();
        renderer.SetPosition(0, Vector3.zero);
        Ray ray;
        RaycastHit hit;
    }
}