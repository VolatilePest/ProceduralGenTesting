using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float radius = 1;
    public Vector2 regionSize = Vector2.one;
    public int rejectionSamples = 30;

    List<Vector2> points;

    void OnValidate(){
        points = PoissonDiskSampling.GeneratePoints(radius, regionSize, rejectionSamples);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(new Vector3(regionSize.x / 2,1, regionSize.y/2), new Vector3(regionSize.x, 1, regionSize.y));
        if(points != null)
        {
            foreach (Vector2 point in points)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawSphere(new Vector3(point.x,1,point.y),0.5f);
            }
        }
    }
}
