using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;
using Tile.Utilities;

public class mapGenerator : MonoBehaviour
{
    [Header("DON'T TOUCH")]

    //Variables to iterate
    private int tileX;
    private int tileY;
    private int tileXCounter;
    private int tileYCounter;

    //Tile prefab to instantiate
    public GameObject tilePrefab;

    //Canvas with all the tiles
    public Canvas mapCanvas;

    //Script mapBordersCreator
    [SerializeField] mapBordersCreator mapBordersCreator;

    //Script biomeSelector
    [SerializeField] biomeSelector biomeSelector;

    //Script tileAdjacentChecker
    [SerializeField] tileAdjacentChecker tileAdjacentChecker;

    //Script biomeScriptCreator
    [SerializeField] private biomeScriptCreator biomeScriptCreator;

    [Header("AUTOMATIC")]

    //Map Max X 
    public int xSize;

    //Map Max Y 
    public int ySize;

    //Amount of biomes
    public int biomesAmount;

    //Id for the tiles
    public int tileIdCounter;

    //Script tileScript
    [SerializeField] private tileScript tileScript;

    [SerializeField] private GameObject editModeCanvas;
    [SerializeField] private GameObject introductionCanvas;

    private bool canStartTimer = false;
    private float timer;
    private bool canActivateRivers = true;

    [SerializeField] private Transform cameraTansform;

    public void GenerateMap()
    {   
        //
        //STEP 1
        //

        //Resetet values to 0
        tileX = 0;
        tileY = 0;
        tileXCounter = 0;
        tileYCounter = 0;

        CalculateMapSize();
        introductionCanvas.SetActive(false);
        editModeCanvas.SetActive(true);

        //
        //STEP 2
        //

        //Create the empty tiles
        for (int i = 0; i < (xSize * ySize); i++)
        {
            //Instantiate tiles in tileX and tileY
            GameObject newTile = Instantiate(tilePrefab, new Vector3(tileX, tileY, 0), Quaternion.identity);
            tileScript = newTile.GetComponent<tileScript>();
            tileScript.tileId = tileIdCounter;

            tileIdCounter++;

            //Make the child tiles of the canvas
            newTile.transform.SetParent(mapCanvas.transform, false);

            //If the Y of the tile does not exceed the maximum Y, create tiles one above the other in a column
            if (tileYCounter < (ySize - 1))
            {
                tileY += 1000;
                tileYCounter++;
            }

            //If the Y of the tile exceeds the maximum Y, create the next tile at Y = 0 and one position to the right to start a new column of tiles
            else
            {
                tileYCounter = 0;
                tileXCounter++;
                tileY = 0;
                tileX = 1000 * tileXCounter;
            }
        }

        //
        //STEP 3
        //

        //Initialize the biomes to be created
        for (int i = 0; i < 11; i++)
        {
            biomeScriptCreator.IntantiateBiomesFunction();
        }

        biomeScriptCreator.PlaceBiomesIntoBiomesArray();


        //
        //STEP 4
        //

        //Create map borders
        mapBordersCreator.CreateMapBorders();

        //
        //STEP 5
        //

        //Check adjacent tiles
        tileAdjacentChecker.CheckAdjacentTiles();

        //
        //STEP 6
        //

        //Create biomes
        biomeSelector.CreateBiomes();

        //
        //STEP 7
        //

        //Remake the borders
        mapBordersCreator.NewBorders();


        //
        //STEP 8
        //

        //Remake the rivers
        biomeSelector.NewRivers();

        //
        //STEP 9
        //

        //Create transitions between biomes
        biomeSelector.SetBordersBiome();
        biomeSelector.NewBiomesTransitions();
        canStartTimer = true;
    }

    //Calculate the size of the map
    private void CalculateMapSize()
    {
        xSize = (int)Mathf.Sqrt(biomesAmount * 100);
        ySize = (int)Mathf.Sqrt(biomesAmount * 100);

        //And place the camera
        cameraTansform.position = new Vector3(xSize*4, ySize*4, cameraTansform.position.z);
    }

    //Remake rivers
    private void ActivateNewRivers()
    {
        biomeSelector.NewRivers();
    }

    private void Update()
    {
        if (canStartTimer)
        {
            timer += Time.deltaTime;
        }

        if (timer > 2 && canActivateRivers)
        {
            ActivateNewRivers();
            canStartTimer = false;
            canActivateRivers = false;
        }

    }
}
