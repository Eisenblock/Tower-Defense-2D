using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrawGrid : MonoBehaviour
{
    [ExecuteInEditMode]

    private void OnDrawGizmos()
    {
        Vector3 startPosition = Vector3.zero;
        float cellsize = 1f;

        for (int g = 0; g < 19; g++)
        {
            for (int h = 0; h < 8; h++)
            {
                Vector3 cellPosition = Vector3.zero + new Vector3(g * cellsize, h * cellsize, 0);

                // Zeichne die Grenzen der Zelle
                Gizmos.DrawLine(cellPosition, cellPosition + new Vector3(cellsize, 0, 0));
                Gizmos.DrawLine(cellPosition + new Vector3(cellsize, 0, 0), cellPosition + new Vector3(cellsize, cellsize, 0));
                Gizmos.DrawLine(cellPosition + new Vector3(cellsize, cellsize, 0), cellPosition + new Vector3(0, cellsize, 0));
                Gizmos.DrawLine(cellPosition + new Vector3(0, cellsize, 0), cellPosition);
            }
        }
    }
}
