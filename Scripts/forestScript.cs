using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tile.Utilities;

public class forestScript : MonoBehaviour
{
    public biomeSelector biomeSelector;
    public biomeScript biomeScript;
    public ChooseTileScript chooseTileScript;
    public valuesAdjusterScript valuesAdjusterScript;

    //Create the first tile of the forest group
    public void CreateForest()
    {
        int tileNumToIterate;
        int randomNumToIterate;
        int stage;

        tileNumToIterate = biomeScript.biomeCoresArray[chooseTileScript.numForTileInArray];

        biomeSelector.tileChild = biomeSelector.mapCanvasGameObject.transform.GetChild(tileNumToIterate).gameObject;
        biomeSelector.tileScript = biomeSelector.tileChild.GetComponent<tileScript>();

        randomNumToIterate = Random.Range(1, 101);

        stage = 0;
        if (biomeScript.isGrassBiome)
        {
            if (stage == 0 && biomeSelector.tileScript.tileType == tileScript.TileType.GRASS)
            {
                if (randomNumToIterate <= 50)
                {
                    biomeSelector.tileScript.tileType = tileScript.TileType.TREE;

                    randomNumToIterate = Random.Range(1, 101);
                    if (randomNumToIterate <= valuesAdjusterScript.grassBiomesForestExpansionPercentage)
                    {
                        ExtendForest();
                    }
                }

                else
                {
                    biomeSelector.tileScript.tileType = tileScript.TileType.GRASS;
                }
            }
        }

        else if (biomeScript.isSandBiome)
        {
            if (stage == 0 && biomeSelector.tileScript.tileType == tileScript.TileType.SAND)
            {
                if (randomNumToIterate <= 50)
                {
                    biomeSelector.tileScript.tileType = tileScript.TileType.TREE;

                    randomNumToIterate = Random.Range(1, 101);
                    if (randomNumToIterate <= 0)
                    {
                        ExtendForest();
                    }
                }

                else
                {
                    biomeSelector.tileScript.tileType = tileScript.TileType.SAND;
                }
            }
        }


        if (chooseTileScript.tilesIterated < biomeScript.biomeSize)
        {
            chooseTileScript.tilesIterated++;
            chooseTileScript.numForTileInArray++;
            chooseTileScript.ChooseTile();
        }
    }


    //Create the rest tiles of the rocks group
    private void ExtendForest()
    {
        int randomNumToIterate;
        randomNumToIterate = Random.Range(1, 101);
        bool canCheckTerrainTile = false;

        if (biomeScript.isGrassBiome)
        {
            if (randomNumToIterate <= valuesAdjusterScript.grassBiomesForestExpansionPercentage)
            {
                if (biomeSelector.tileScript.topAdjacentTile.tileType == tileScript.TileType.GRASS &&
                    biomeSelector.tileScript.topAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                if (biomeSelector.tileScript.rightAdjacentTile.tileType == tileScript.TileType.GRASS &&
                    biomeSelector.tileScript.rightAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                if (biomeSelector.tileScript.bottomAdjacentTile.tileType == tileScript.TileType.GRASS &&
                    biomeSelector.tileScript.bottomAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                if (biomeSelector.tileScript.leftAdjacentTile.tileType == tileScript.TileType.GRASS &&
                    biomeSelector.tileScript.leftAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                int randomNumToChooseDirection;
                randomNumToChooseDirection = Random.RandomRange(0, 4);

                if (canCheckTerrainTile)
                {
                    if (randomNumToChooseDirection == 0)
                    {
                        if (biomeSelector.tileScript.topAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.topAdjacentTile.tileType == tileScript.TileType.GRASS)
                        {
                            biomeSelector.tileScript.topAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.topAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }

                    if (randomNumToChooseDirection == 1)
                    {
                        if (biomeSelector.tileScript.rightAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.rightAdjacentTile.tileType == tileScript.TileType.GRASS)
                        {
                            biomeSelector.tileScript.rightAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.rightAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }

                    if (randomNumToChooseDirection == 2)
                    {
                        if (biomeSelector.tileScript.bottomAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.bottomAdjacentTile.tileType == tileScript.TileType.GRASS)
                        {
                            biomeSelector.tileScript.bottomAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.bottomAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }

                    if (randomNumToChooseDirection == 3)
                    {
                        if (biomeSelector.tileScript.leftAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.leftAdjacentTile.tileType == tileScript.TileType.GRASS)
                        {
                            biomeSelector.tileScript.leftAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.leftAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }
                }

                ExtendForest();
            }
        }

        if (biomeScript.isSandBiome)
        {
            if (randomNumToIterate <= 0)
            {
                if (biomeSelector.tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND &&
                    biomeSelector.tileScript.topAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                if (biomeSelector.tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND &&
                    biomeSelector.tileScript.rightAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                if (biomeSelector.tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND &&
                    biomeSelector.tileScript.bottomAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                if (biomeSelector.tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND &&
                    biomeSelector.tileScript.leftAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile)
                {
                    canCheckTerrainTile = true;
                }

                int randomNumToChooseDirection;
                randomNumToChooseDirection = Random.RandomRange(0, 4);

                if (canCheckTerrainTile)
                {
                    if (randomNumToChooseDirection == 0)
                    {
                        if (biomeSelector.tileScript.topAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND)
                        {
                            biomeSelector.tileScript.topAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.topAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }

                    if (randomNumToChooseDirection == 1)
                    {
                        if (biomeSelector.tileScript.rightAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND)
                        {
                            biomeSelector.tileScript.rightAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.rightAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }

                    if (randomNumToChooseDirection == 2)
                    {
                        if (biomeSelector.tileScript.bottomAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND)
                        {
                            biomeSelector.tileScript.bottomAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.bottomAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }

                    if (randomNumToChooseDirection == 3)
                    {
                        if (biomeSelector.tileScript.leftAdjacentTile.biomeIdOfThisTile == biomeSelector.tileScript.biomeIdOfThisTile &&
                           biomeSelector.tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND)
                        {
                            biomeSelector.tileScript.leftAdjacentTile.tileType = tileScript.TileType.TREE;
                            biomeSelector.tileScript = biomeSelector.tileScript.leftAdjacentTile;
                            canCheckTerrainTile = false;
                        }
                        else
                        {
                            ExtendForest();
                        }
                    }
                }

                ExtendForest();
            }
        }
    }
}
