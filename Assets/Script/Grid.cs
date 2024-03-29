using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Grid : MonoBehaviour { 

    private int  height;
    private int width;
    private float cellsize;
    private bool isEmpty;
    public bool[,] gridArray;

    public Grid( int height , int width , float cellsize ) 
    {
        this.height = height;
        this.width = width;
        this.cellsize = cellsize;

        gridArray = new bool[width,height];  
        for ( int x = 0; x < gridArray.GetLength(0); x++ )
        {
            for ( int y = 0; y < gridArray.GetLength(1); y++)
            {
                gridArray[x,y] = true;
            }
        }
    }
}
