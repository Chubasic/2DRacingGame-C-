using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    public Color lineColor;
    private List<Transform> points = new List<Transform>();
    Transform[] pathTransforms;


    void OnDrawGizmos()
    {
        Gizmos.color = lineColor;
        pathTransforms = GetComponentsInChildren<Transform>();
        points = new List<Transform>();
        points.Clear(); 

        if (pathTransforms.Length <= 0)
        {
            return;
        }

       for (int i = 0; i < pathTransforms.Length; i++) {
            if (pathTransforms[i] != transform)
            {
                points.Add(pathTransforms[i]);
            }
        }
        for (int i = 0; i < points.Count; i++)
        {
            Vector3 currentPosition = points[i].position;
            if (i > 0)
            {
                Vector3 previousPosition = points[i - 1].position;
                Gizmos.DrawLine(previousPosition, currentPosition);
                Gizmos.DrawSphere(currentPosition, 0.5f);
            }
        }
    }
}
