using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class GameManager : MonoBehaviour
{




    /* 		Author : Saad Khawaja
         *  http://www.saadkhawaja.com
         * 	http://www.twitter.com/saadskhawaja

         *     This file is part of Grid Based A* - Tower Defense.

                Grid Based A* - Tower Defense is free software: you can redistribute it and/or modify
                it under the terms of the GNU General Public License as published by
                the Free Software Foundation, either version 3 of the License, or
                (at your option) any later version.

                Grid Based A* - Tower Defense is distributed in the hope that it will be useful,
                but WITHOUT ANY WARRANTY; without even the implied warranty of
                MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
                GNU General Public License for more details.


         * 
    */

    public MyPathNode[,] grid;
    public GameObject enemy;
    [SerializeField]
    private Sprite towerPrefab;
    public Sprite TowerPrefab { get { return towerPrefab; } }
    public GameObject gridBox;
    public int gridWidth;
    public int gridHeight;
    public Sprite enemyUp;
    public Sprite enemyDown;
    public Sprite enemyFront;
    public Sprite enemyBack;
    public float gridSize;
    public GUIStyle lblStyle;
    public GameObject[,] cases;
    public static string distanceType;


    //This is what you need to show in the inspector.
    public static int distance = 2;


    void Start()
    {

        //lock orientation of smartphone
        Screen.orientation = ScreenOrientation.Landscape;

        //Generate a grid - nodes according to the specified size
        grid = new MyPathNode[gridWidth, gridHeight];

        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                //Boolean isWall = ((y % 2) != 0) && (rnd.Next (0, 10) != 8);
                Boolean isWall = false;


                grid[x, y] = new MyPathNode()
                {
                    IsWall = isWall,
                    X = x,
                    Y = y,
                };
            }
        }

        //instantiate grid gameobjects to display on the scene
        createGrid();

        //create base map
        
        addBlockable(0, 3);
        addBlockable(0, 5);
        addBlockable(1, 3);
        addBlockable(2, 3);
        addBlockable(2, 5);
        addBlockable(3, 3);
        addBlockable(3, 5);
        addBlockable(4, 5);
        addBlockable(4, 6);
        addBlockable(4, 7);
        addBlockable(4, 9);
        addBlockable(5, 0);
        addBlockable(5, 1);
        addBlockable(5, 2);
        addBlockable(5, 3);
        addBlockable(5, 5);
        addBlockable(7, 3);
        
        addBlockable(7, 5);
        addBlockable(8, 3);
        addBlockable(8, 5);
        addBlockable(9, 0);
        addBlockable(9, 2);
        addBlockable(9, 3);
        addBlockable(9, 5);
        addBlockable(9, 6);
        addBlockable(9, 7);
        addBlockable(9, 9);
        addBlockable(10, 3);
        addBlockable(10, 6);
        addBlockable(11, 3);
        addBlockable(11, 4);
        addBlockable(11, 6);
        addBlockable(13, 0);
        addBlockable(13, 2);
        addBlockable(13, 3);
        addBlockable(13, 4);
        addBlockable(13, 0);
        addBlockable(13, 6);
        addBlockable(13, 7);
        addBlockable(13, 9);
        addBlockable(14, 4);
        addBlockable(14, 6);
        addBlockable(15, 4);
        addBlockable(15, 6);
        addBlockable(17, 4);
        addBlockable(17, 6);


        //instantiate enemy object
        createEnemy();




    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(0f, 0f, 200f, 50f), "Créer un ennemi"))
        {
            createEnemy();
        }
        if (GUI.Button(new Rect(0f, 60f, 200f, 50f), "Recharger"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }


    void createGrid()
    {
        cases = new GameObject[gridWidth, gridHeight];
        //Generate Gameobjects of GridBox to show on the Screen
        for (int i = 0; i < gridHeight; i++)
        {
            for (int j = 0; j < gridWidth; j++)
            {
                GameObject nobj = (GameObject)GameObject.Instantiate(gridBox);
                nobj.transform.position = new Vector2(gridBox.transform.position.x + (gridSize * j), gridBox.transform.position.y + (0.87f * i));
                nobj.name = j + "," + i;

                nobj.gameObject.transform.parent = gridBox.transform.parent;
                cases[j, i] = nobj;
                nobj.SetActive(true);

            }
        }
    }

    void createEnemy()
    {
        GameObject nb = (GameObject)GameObject.Instantiate(enemy);
        nb.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void addBlockable(int x, int y)
    {
        grid[x, y].IsBlockable = true;
        cases[x, y].GetComponent<Renderer>().material.color = Color.black;
        grid[x, y].IsWall = true;
    }

    public void addWall(int x, int y)
    {
        if (grid[x, y].IsBlockable != true)
        {
            cases[x, y].GetComponent<Renderer>().material.color = Color.red;
            grid[x, y].IsWall = true;
        }

    }

    public void removeWall(int x, int y)
    {
        if (grid[x, y].IsBlockable != true)
        {
            cases[x, y].GetComponent<Renderer>().material.color = Color.white;
            grid[x, y].IsWall = false;
        }
    }

    public void addTower(int x, int y)
    {
        if (grid[x, y].IsBlockable != true)
        {
            cases[x,y].GetComponent<SpriteRenderer>().sprite = towerPrefab;
            //cases[x, y].GetComponent<Renderer>().material.color = Color.blue;
            grid[x, y].IsWall = true;
        }

    }


}
