using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Tile.Utilities;

public class biomeSelector : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    //Canvas Gameobject
    public GameObject mapCanvasGameObject;

    //Array with the biomeScripts
    public biomeScript[] biomeScriptArray;

    //Script mapGenerator
    [SerializeField] private mapGenerator mapGenerator;

    [Header("AUTOMATIC")]
    //Script tileScript
    public tileScript tileScript;

    //tileScript of the otherTile
    [SerializeField] tileScript otherTileScript;

    //Gameobject of the child
    public GameObject tileChild;

    //randomTile int
    public int randomTile;

    bool allCoresPlaced = false;



    /*private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            NewRivers();
        }

        if (Input.GetKeyDown("2"))
        {
            NewBiomesTransitions();
        }
    }*/
    public void CreateBiomes()
    {
        //Plaace the cores of the biomes
        PlaceBiomeCores();

        if (allCoresPlaced)
        {
            //For to iterate the childs
            for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
            {
                for (int j = 0; j < mapGenerator.biomesAmount; j++)
                {
                    //Creation of the biomes
                    biomeScriptArray[j].VoronoiFunction();
                }

                for (int j = 0; j < mapGenerator.biomesAmount; j++)
                {
                    biomeScriptArray[j].chooseTileScript.numForTileInArray = 1;

                    biomeScriptArray[j].chooseTileScript.Invoke("ChooseTile", 1.0f);
                }
            }
        }
    }

    //Function toe create the cores of the biomes
    public void PlaceBiomeCores()
    {
        for (int j = 0; j < mapGenerator.biomesAmount; j++)
        {
            //Place cores
            biomeScriptArray[j].PlaceCore();
        }

        allCoresPlaced = true;
    }

    public void NewRivers()
    {
        //For que itera todos los tiles 
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            //Select a tile from the map
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;
            tileScript = tileChild.GetComponent<tileScript>();

            //Change the water sprite of the rivers 

            //GRASS BIOME
            if (tileScript.tileType == tileScript.TileType.WATER &&
                tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
                tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
                tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
                tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)

            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 1;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
               tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
               tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
               tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
               tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)

            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 2;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
               tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
               tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
               tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
               tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)

            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 3;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
              tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
              tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
              tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
              tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)

            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 4;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
             tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
             tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
             tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
             tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)

            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 5;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
             tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
             tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
             tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
             tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)

            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 6;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 7;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 8;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 9;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 10;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 11;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 12;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 13;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 14;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 15;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 16;
            }

            //FULL WATERS

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 17;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 18;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 19;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 20;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 21;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 22;
            }


            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 23;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 24;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 25;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 26;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 27;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 28;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 29;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 30;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 31;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 32;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 33;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 34;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 35;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 36;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 37;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 38;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 39;
            }


            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 40;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 41;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 42;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 43;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 44;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 45;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 46;
            }

            if (tileScript.tileType == tileScript.TileType.WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.WATER)
            {
                tileScript.tileType = tileScript.TileType.WATER;
                tileScript.randomNumToChooseTileVariant = 47;
            }

            //SAND BIOME
            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
                tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
                tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
                tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
                tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)

            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 1;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
               tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
               tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
               tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
               tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)

            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 2;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
               tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
               tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
               tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
               tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)

            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 3;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
              tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
              tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
              tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
              tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)

            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 4;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
             tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
             tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
             tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
             tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)

            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 5;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
             tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
             tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
             tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
             tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)

            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 6;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 7;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 8;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 9;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 10;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 11;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 12;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 13;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 14;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 15;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 16;
            }


            //FULL WATERS

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 17;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 18;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 19;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 20;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 21;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 22;
            }


            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 23;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 24;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 25;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 26;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 27;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 28;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 29;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&

            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 30;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 31;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 32;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 33;
            }


            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 34;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 35;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 36;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 37;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 38;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 39;
            }


            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 40;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 41;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 42;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 43;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 44;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 45;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 46;
            }

            if (tileScript.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topAdjacentTile != null && tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.rightAdjacentTile != null && tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.bottomAdjacentTile != null && tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.leftAdjacentTile != null && tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&

            tileScript.bottomLeftAdjacentTile != null && tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topLeftAdjacentTile != null && tileScript.topLeftAdjacentTile.tileType != tileScript.TileType.SAND_WATER &&
            tileScript.bottomRightAdjacentTile != null && tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_WATER &&
            tileScript.topRightAdjacentTile != null && tileScript.topRightAdjacentTile.tileType != tileScript.TileType.SAND_WATER)
            {
                tileScript.tileType = tileScript.TileType.SAND_WATER;
                tileScript.randomNumToChooseTileVariant = 47;
            }

        }
    }

    //Create the transitions between biomes
    public void NewBiomesTransitions()
    {
        //For to iterate the tiles
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            ClearLonelyGrassTiles();

            //Select a tile from the map
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;
            tileScript = tileChild.GetComponent<tileScript>();; 


            //TOP LEFT TRANSITION L
            if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.topLeftAdjacentTile != null && biomeScriptArray[tileScript.topLeftAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TRANSITION_L_TOP_LEFT;
            }

            //TOP RIGHT TRANSITION L
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.topRightAdjacentTile != null && biomeScriptArray[tileScript.topRightAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TRANSITION_L_TOP_RIGHT;
            }

            //BOTTOM RIGHT TRANSITION L
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.bottomRightAdjacentTile != null && biomeScriptArray[tileScript.bottomRightAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TRANSITION_L_BOTTOM_RIGHT;
            }

            //BOTTOM LEFT TRANSITION L
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isGrassBiome &&
            tileScript.bottomLeftAdjacentTile != null && biomeScriptArray[tileScript.bottomLeftAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TRANSITION_L_BOTTOM_LEFT;
            }


            //TOP LEFT GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TOP_LEFT_GRASS;
            }


            //TOP RIGHT GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TOP_RIGHT_GRASS;
            }



            //BOTTOM RIGHT GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.BOTTOM_RIGHT_GRASS;
            }


            //BOTTOM LEFT GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.BOTTOM_LEFT_GRASS;
            }


            //LEFT GRASS RIGHT SAND
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isSandBiome)
            {
                tileScript.tileType = tileScript.TileType.LEFT_GRASS_RIGHT_SAND;
            }


            //LEFT SAND RIGHT GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.LEFT_SAND_RIGHT_GRASS;
            }

            //TOP SAND BOTTOM GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TOP_SAND_BOTTOM_GRASS;
            }

            //BOTTOM SAND TOP GRASS
            else if (tileScript.tileType == tileScript.TileType.GRASS &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isSandBiome)

            {
                tileScript.tileType = tileScript.TileType.TOP_GRASS_BOTTOM_SAND;
            }

        }
    }

    // Erase the grass tiles that don't fit with the transitions
    public void ClearLonelyGrassTiles()
    {
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;
            tileScript = tileChild.GetComponent<tileScript>();

            //REMOVE LONELY GRASS
            if (biomeScriptArray[tileScript.biomeIdOfThisTile].isGrassBiome &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isSandBiome)
            {
                tileScript.tileType = tileScript.TileType.SAND;
                tileScript.biomeIdOfThisTile = tileScript.topAdjacentTile.biomeIdOfThisTile;
            }


            if (biomeScriptArray[tileScript.biomeIdOfThisTile].isGrassBiome &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isSandBiome)
            {
                tileScript.tileType = tileScript.TileType.SAND;
                tileScript.biomeIdOfThisTile = tileScript.bottomAdjacentTile.biomeIdOfThisTile;
            }

            if (biomeScriptArray[tileScript.biomeIdOfThisTile].isGrassBiome &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.rightAdjacentTile != null && biomeScriptArray[tileScript.rightAdjacentTile.biomeIdOfThisTile].isSandBiome)
            {
                tileScript.tileType = tileScript.TileType.SAND;
                tileScript.biomeIdOfThisTile = tileScript.topAdjacentTile.biomeIdOfThisTile;
            }

            if (biomeScriptArray[tileScript.biomeIdOfThisTile].isGrassBiome &&
            tileScript.bottomAdjacentTile != null && biomeScriptArray[tileScript.bottomAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.topAdjacentTile != null && biomeScriptArray[tileScript.topAdjacentTile.biomeIdOfThisTile].isSandBiome &&
            tileScript.leftAdjacentTile != null && biomeScriptArray[tileScript.leftAdjacentTile.biomeIdOfThisTile].isSandBiome)
            {
                tileScript.tileType = tileScript.TileType.SAND;
                tileScript.biomeIdOfThisTile = tileScript.topAdjacentTile.biomeIdOfThisTile;
            }
        }
    }

    
    //Set a bimoe for the borders
    public void SetBordersBiome()
    {
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            //Select a tile from the map
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;
            tileScript = tileChild.GetComponent<tileScript>();

            if (tileScript.tileType == tileScript.TileType.TOP_LEFT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.TOP_LEFT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.LEFT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.LEFT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.RIGHT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.RIGHT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.BOTTOM_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.BOTTOM_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.RIGHT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.RIGHT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.TOP_RIGHT_MAP_CORNER_GRASS ||
                tileScript.tileType == tileScript.TileType.TOP_RIGHT_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.TOP_MAP_CORNER_SAND ||
                tileScript.tileType == tileScript.TileType.TOP_MAP_CORNER_GRASS)
            {
                tileScript.biomeIdOfThisTile = 9;
            }
        }
        biomeScriptArray[9].isSandBiome = false;
        biomeScriptArray[9].isGrassBiome = true;
        biomeScriptArray[10].isGrassBiome = false;
        biomeScriptArray[10].isSandBiome = true;
    }

}

