using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PieceTypes
{
    Mallard = 0,
    Bluey = 1,
    Red = 2,
    Squeaky = 3,
    Frank = 4
}
public class Pieces : MonoBehaviour
{
    private Vector3 position;
    private Vector2 gridPosition;
    private PieceTypes pieceType;

    public Pieces()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;
        pieceType = PieceTypes.Mallard;
    }

    public Pieces(Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = PieceTypes.Squeaky;
    }

    public Pieces(Vector3 position, Vector2 gridPosition, PieceTypes pieceType)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = pieceType;
    }

    public void SetPieceType(PieceTypes pieceType)
    {
        this.pieceType = pieceType;
    }

    public Vector3 GetPosition()
    {
        return position;
    }

    public Vector3 GetGridPosition()
    {
        return gridPosition;
    }

    public PieceTypes GetPieceType()
    {
        return pieceType;
    }
}
