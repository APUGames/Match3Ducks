using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces
{
    private Vector3 position;
    private Vector2 gridPosition;


    public Pieces()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;

    }

    public Pieces(Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
    }

    public Vector3 GetPosition()
    {
        return position;
    }
}
