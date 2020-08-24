using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;
    private BackgroundTile[,] allTiles;
    public GameObject[] dots;
    public GameObject[,] allDots;

    // Start is called before the first frame update
    void Start()
    {
        allTiles = new BackgroundTile[width,height];
        allDots = new GameObject[width, height];
        Setup();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Creating the board
    private void Setup()
    {
        for (int i = 0;i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPos = new Vector2(i, j);
                GameObject backgroundTile = Instantiate(tilePrefab, tempPos,Quaternion.identity) as GameObject;
                backgroundTile.transform.parent = this.transform;
                backgroundTile.name = "( " + i + ',' + j + " )";
                int dotToUse = Random.Range(0, dots.Length);
                GameObject Dot = Instantiate(dots[dotToUse], tempPos, Quaternion.identity);
                Dot.transform.parent = this.transform;
                Dot.name = "Dot: ( " + i + ',' + j + " )";
                allDots[i, j] = Dot;
            }
        }
    }
}
