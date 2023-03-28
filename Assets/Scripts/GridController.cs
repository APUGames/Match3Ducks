using System;
using UnityEngine;

public class GridController : MonoBehaviour
{
    // This script will manage the grid of pieces

    [SerializeField]
    private GameObject piecePrefab;
    [SerializeField]
    private Vector3 originPosition;

    [Header("The Duckies")]

    [SerializeField]
    private GameObject Mallard;

    [SerializeField]
    private GameObject Bluey;

    [SerializeField]
    private GameObject Red;

    [SerializeField]
    private GameObject Squeaky;

    [SerializeField]
    private GameObject Frank
        ;
    public bool pressedDown;
    public Vector2 pressedDownPosition;
    public Vector2 pressedUpPosition;
    public GameObject pressedDownGameObject;
    public GameObject pressedUpGameObject;

    private Vector2 startMovementPiecePosition;
    private Vector2 endMovementPiecePosition;

    private bool validMoveInProcess = false;

    // Section for tuning

    private Pieces[,] grid = new Pieces[8, 8];

    // [[0, 1, 2, 3, 4], [], [], []]

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(grid);

        pressedDown = false;

        System.Random rand = new System.Random();

        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                // 4-0=4, 4-1=3, 4-2=2, 4-3=1, 4-4=0, 4-5=-1, 4-6=-2, 4-7=-3
                Vector3 newWorldPosition = new Vector3(originPosition.x + row, originPosition.y, originPosition.z - column);
                Pieces newPiece = new Pieces(newWorldPosition, new Vector2(row, column));

                // Debug.Log(grid[row, column]);

                GameObject gameObject = Instantiate(piecePrefab, newPiece.GetPosition(), Quaternion.identity);
                int theNumber = rand.Next(13, 101);

                PieceController controller = gameObject.GetComponent<PieceController>();
                controller.SetPiece(newPiece);

                grid[row, column] = newPiece;
            }
        }
    }


}