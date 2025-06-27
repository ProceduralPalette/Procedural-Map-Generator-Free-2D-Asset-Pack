using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tile.Utilities;

public class biomeScript : MonoBehaviour
{
    public biomeSelector biomeSelector;

    //Grass Variables
    public int[] biomeCoresArray;
    public int terrainArrayIteratorNumForTiles;
    public int terrainArrayIteratorNumForCores;
    public bool canExpandThisBiome = true;
    public bool isGrassBiome;
    public bool isSandBiome;

    public int biomeID;
    public riverScript riverScript;
    public riverSandScript riverSandScript;
    public forestScript forestScript;
    public sandRocksScript sandRocksScript;
    public cactusScript cactusScript;
    public palmTreeScript palmTreeScript;
    public jungleRocksScript jungleRocksScript;
    public flowersScript flowersScript;

    public int biomeSize;

    public ChooseTileScript chooseTileScript;

    public void PlaceCore()
    {
        biomeSelector.randomTile = UnityEngine.Random.Range(0, biomeSelector.mapCanvasGameObject.transform.childCount);

        biomeSelector.tileChild = biomeSelector.mapCanvasGameObject.transform.GetChild(biomeSelector.randomTile).gameObject;

        biomeSelector.tileScript = biomeSelector.tileChild.GetComponent<tileScript>();

        //If is forest biome
        if (isGrassBiome)
        {
            if (biomeSelector.tileScript.tileType == tileScript.TileType.EMPTY &&
            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_LEFT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.LEFT_MAP_CORNER_GRASS &&

            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_LEFT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.LEFT_MAP_CORNER_SAND &&

            biomeSelector.tileScript.tileType != tileScript.TileType.SAND_CORE)
            {
                biomeSelector.tileScript.tileType = tileScript.TileType.GRASS;
                biomeSelector.tileScript.biomeIdOfThisTile = biomeID;
                biomeCoresArray[0] = biomeSelector.randomTile;
            }

            else
            {
                PlaceCore();
            }
        }

        //If is dessert biome
        else if (isSandBiome)
        {
            if (biomeSelector.tileScript.tileType == tileScript.TileType.EMPTY &&
            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_LEFT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_GRASS &&
            biomeSelector.tileScript.tileType != tileScript.TileType.LEFT_MAP_CORNER_GRASS &&

            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_LEFT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.TOP_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.RIGHT_MAP_CORNER_SAND &&
            biomeSelector.tileScript.tileType != tileScript.TileType.LEFT_MAP_CORNER_SAND &&

            biomeSelector.tileScript.tileType != tileScript.TileType.GRASS_CORE)
            {
                biomeSelector.tileScript.tileType = tileScript.TileType.SAND;
                biomeSelector.tileScript.biomeIdOfThisTile = biomeID;
                biomeCoresArray[0] = biomeSelector.randomTile;
            }

            else
            {
                PlaceCore();
            }
        }
    }

    public void VoronoiFunction()
    {
        if (biomeCoresArray[terrainArrayIteratorNumForTiles] == biomeCoresArray[terrainArrayIteratorNumForCores] && terrainArrayIteratorNumForCores > 0)
        {
            canExpandThisBiome = false;
        }

        if (canExpandThisBiome)
        {
            //Select the gameObject of a tile
            biomeSelector.tileChild = biomeSelector.mapCanvasGameObject.transform.GetChild(biomeCoresArray[terrainArrayIteratorNumForTiles]).gameObject;

            //Select the tileScript of that gameObject
            biomeSelector.tileScript = biomeSelector.tileChild.GetComponent<tileScript>();

            VoronoiTerrain();
        }
    }

    private void VoronoiTerrain()
    {
        bool canCheckTerrainTile = false;

        if (biomeSelector.tileScript.topAdjacentTile.tileType == tileScript.TileType.EMPTY)
        {
            canCheckTerrainTile = true;
        }

        if (biomeSelector.tileScript.rightAdjacentTile.tileType == tileScript.TileType.EMPTY)
        {
            canCheckTerrainTile = true;
        }

        if (biomeSelector.tileScript.bottomAdjacentTile.tileType == tileScript.TileType.EMPTY)
        {
            canCheckTerrainTile = true;
        }

        if (biomeSelector.tileScript.leftAdjacentTile.tileType == tileScript.TileType.EMPTY)
        {
            canCheckTerrainTile = true;
        }

        if (canCheckTerrainTile)
        {
            //Choose a random direction if there is empty space
            biomeSelector.randomTile = UnityEngine.Random.Range(0, 4);
            if (biomeSelector.randomTile == 0)
            {
                if (biomeSelector.tileScript.topAdjacentTile.tileType == tileScript.TileType.EMPTY)
                {
                    if (isGrassBiome)
                    {
                        biomeSelector.tileScript.topAdjacentTile.tileType = tileScript.TileType.GRASS;
                        biomeSelector.tileScript.topAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    else if (isSandBiome)
                    {
                        biomeSelector.tileScript.topAdjacentTile.tileType = tileScript.TileType.SAND;
                        biomeSelector.tileScript.topAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    canCheckTerrainTile = false;
                    terrainArrayIteratorNumForCores++;
                    biomeCoresArray[terrainArrayIteratorNumForCores] = biomeSelector.tileScript.topAdjacentTile.tileId;
                }

                else
                {
                    VoronoiTerrain();
                }
            }

            else if (biomeSelector.randomTile == 1)
            {
                if (biomeSelector.tileScript.rightAdjacentTile.tileType == tileScript.TileType.EMPTY)
                {
                    if (isGrassBiome)
                    {
                        biomeSelector.tileScript.rightAdjacentTile.tileType = tileScript.TileType.GRASS;
                        biomeSelector.tileScript.rightAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    else if (isSandBiome)
                    {
                        biomeSelector.tileScript.rightAdjacentTile.tileType = tileScript.TileType.SAND;
                        biomeSelector.tileScript.rightAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    canCheckTerrainTile = false;
                    terrainArrayIteratorNumForCores++;
                    biomeCoresArray[terrainArrayIteratorNumForCores] = biomeSelector.tileScript.rightAdjacentTile.tileId;
                }

                else
                {
                    VoronoiTerrain();
                }
            }


            else if (biomeSelector.randomTile == 2)
            {
                if (biomeSelector.tileScript.bottomAdjacentTile.tileType == tileScript.TileType.EMPTY)
                {
                    if (isGrassBiome)
                    {
                        biomeSelector.tileScript.bottomAdjacentTile.tileType = tileScript.TileType.GRASS; ;
                        biomeSelector.tileScript.bottomAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    else if (isSandBiome)
                    {
                        biomeSelector.tileScript.bottomAdjacentTile.tileType = tileScript.TileType.SAND;
                        biomeSelector.tileScript.bottomAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    canCheckTerrainTile = false;
                    terrainArrayIteratorNumForCores++;
                    biomeCoresArray[terrainArrayIteratorNumForCores] = biomeSelector.tileScript.bottomAdjacentTile.tileId;
                }

                else
                {
                    VoronoiTerrain();
                }
            }


            else if (biomeSelector.randomTile == 3)
            {
                if (biomeSelector.tileScript.leftAdjacentTile.tileType == tileScript.TileType.EMPTY)
                {
                    if (isGrassBiome)
                    {
                        biomeSelector.tileScript.leftAdjacentTile.tileType = tileScript.TileType.GRASS;
                        biomeSelector.tileScript.leftAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    else if (isSandBiome)
                    {
                        biomeSelector.tileScript.leftAdjacentTile.tileType = tileScript.TileType.SAND;
                        biomeSelector.tileScript.leftAdjacentTile.biomeIdOfThisTile = biomeID;
                        biomeSize++;
                    }

                    canCheckTerrainTile = false;
                    terrainArrayIteratorNumForCores++;
                    biomeCoresArray[terrainArrayIteratorNumForCores] = biomeSelector.tileScript.leftAdjacentTile.tileId;
                }

                else
                {
                    VoronoiTerrain();
                }
            }
        }

        else
        {
            terrainArrayIteratorNumForTiles++;
            VoronoiFunction();
        }
    }
}
