using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bezier : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform t0;
    private Vector3 p0, p1, p2;
    private int size = 100;
    private Vector3[] positions = new Vector3[100];

    // Start is called before the first frame update
    void Start()
    {
        p0 = t0.position;
        p0[2] = 0;
        lineRenderer.positionCount = size;
    }
    
    // Update is called once per frame
    void Update()
    {
        p2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        p2[2] = 0;
        p1 = new Vector3((p0[0] + p2[0]) / 2, Mathf.Max(p0[1], p2[1]) + 1, 0);
        Draw();
    }

    private void Draw()
    {
        for (int i = 0; i < size; i++)
        {
            float t = (i + 1) / (float)size;
            positions[i] = BezierCurve(t, p0, p1, p2);
        }
        lineRenderer.SetPositions(positions);
    }

    private Vector3 BezierCurve(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        return uu * p0 + 2 * u * t * p1 + tt * p2;
    }
}
