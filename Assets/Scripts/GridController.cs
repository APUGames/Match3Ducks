using System;
using UnityEngine;


public class GridController : MonoBehaviour
{
    [SerializeField]
    private GameObject mallardDuck;
    [SerializeField]
    private GameObject blueyDuck;
    [SerializeField]
    private GameObject redDuck;
    [SerializeField]
    private GameObject squeakyDuck;
    [SerializeField]
    private GameObject frankDuck;



    [SerializeField]
    private Vector3 originPosition;

    // This script will manage the grid of pieces
    private Pieces[,] grid = new Pieces[8, 8];

    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                Vector3 newWorldPosition = new Vector3(originPosition.x + row, originPosition.y, originPosition.z - column);

                grid[row, column] = new Pieces(newWorldPosition, new Vector2(row, column));

                System.Random rand = new System.Random();

                int randomNum = rand.Next(1, 75);

                if (randomNum >= 1 && randomNum < 15)
                {
                    Instantiate(mallardDuck, grid[row, column].GetPosition(), Quaternion.identity);
                }
                else if (randomNum >= 15 && randomNum < 30)
                {
                    Instantiate(blueyDuck, grid[row, column].GetPosition(), Quaternion.identity);

                }
                else if (randomNum >= 30 && randomNum < 45)
                {
                    Instantiate(redDuck, grid[row, column].GetPosition(), Quaternion.identity);

                }
                else if (randomNum >= 45 && randomNum < 60)
                {
                    Instantiate(squeakyDuck, grid[row, column].GetPosition(), Quaternion.identity);

                }
                else if (randomNum >= 60 && randomNum < 75)
                {
                    Instantiate(frankDuck, grid[row, column].GetPosition(), Quaternion.identity);

                }
            }

        }

    }

    void Update()
    {
        
    }
}