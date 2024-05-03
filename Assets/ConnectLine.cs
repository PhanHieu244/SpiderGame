using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectLine : MonoBehaviour
{
    private LineRenderer _lineRenderer;

    public Transform point1, point2;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();

        _lineRenderer.positionCount = 2;
    }

    void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {
        _lineRenderer.SetPosition(0, point1.transform.position);
        _lineRenderer.SetPosition(1, point2.transform.position);
    }
}