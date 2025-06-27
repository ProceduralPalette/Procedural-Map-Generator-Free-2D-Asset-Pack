using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Tile.Utilities;

public class mapBordersCreator : MonoBehaviour
{
    [Header("AUTOMATIC")]
    //Script tileScript
    private tileScript tileScript;

    //GameObject of the Tile
    private GameObject tileChild;

    [Header("DON'T TOUCH")]
    //Canvas Gameobject
    [SerializeField] private GameObject mapCanvasGameObject;

    //Script mapGenerator
    [SerializeField] private mapGenerator mapGenerator;


    //Function to create map borders
    public void CreateMapBorders()
    {
        //For to iterate all the tiles
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            //Seleect a tile
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;

            //Get the tile possition
            Vector2 tilePosition = tileChild.GetComponent<RectTransform>().anchoredPosition;

            //
            //CREATE MAP BORDERS
            //

            //TOP_LEFT_MAP_CORNER
            if (tilePosition.x == 0 && tilePosition.y == ((mapGenerator.ySize * 1000) - 1000))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.TOP_LEFT_MAP_CORNER_GRASS;
            }

            //LEFT_MAP_CORNER
            else if (tilePosition.x == 0 && tilePosition.y != (mapGenerator.ySize * 1000) && tilePosition.y != ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.LEFT_MAP_CORNER_GRASS;
            }

            //BOTTOM_LEFT_CORNER
            else if (tilePosition.x == 0 && tilePosition.y == ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_GRASS;
            }

            //BOTTOM_MAP_CORNER
            else if ((tilePosition.x != (mapGenerator.xSize * 1000) - (1000) && tilePosition.x != ((mapGenerator.xSize * 1000) - (mapGenerator.xSize * 1000))) && tilePosition.y == 0)
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.BOTTOM_MAP_CORNER_GRASS;
            }

            //BOTTOM_RIGHT_CORNER
            else if (tilePosition.x == ((mapGenerator.xSize * 1000) - (1000)) && tilePosition.y == ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_GRASS;
            }

            //RIGHT_MAP_CORNER
            else if (tilePosition.x == ((mapGenerator.xSize * 1000) - (1000)) && tilePosition.y != ((mapGenerator.ySize * 1000) - (1000)) && tilePosition.y != ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.RIGHT_MAP_CORNER_GRASS;
            }

            //TOP_RIGHT_MAP_CORNER
            if (tilePosition.x == ((mapGenerator.xSize * 1000) - (1000)) && tilePosition.y == ((mapGenerator.ySize * 1000) - 1000))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.TOP_RIGHT_MAP_CORNER_GRASS;
            }

            //TOP_MAP_CORNER
            else if ((tilePosition.x != (mapGenerator.xSize * 1000) - (1000) && tilePosition.x != ((mapGenerator.xSize * 1000) - (mapGenerator.xSize * 1000))) && tilePosition.y == ((mapGenerator.ySize * 1000) - 1000))
            {
                tileScript = tileChild.GetComponent<tileScript>();
                tileScript.tileType = tileScript.TileType.TOP_MAP_CORNER_GRASS;
            }
        }
    }

    //REMAKE THE BORDERS
    public void NewBorders()
    {
        //For to iterate all the tiles
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            ////Seleect a tile
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;

            //Get the tile position
            Vector2 tilePosition = tileChild.GetComponent<RectTransform>().anchoredPosition;

            //TOP_LEFT_MAP_CORNER
            if (tilePosition.x == 0 && tilePosition.y == ((mapGenerator.ySize * 1000) - 1000))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND || 
                    tileScript.bottomRightAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.TOP_LEFT_MAP_CORNER_SAND;
                }
            }

            //LEFT_MAP_CORNER
            else if (tilePosition.x == 0 && tilePosition.y != (mapGenerator.ySize * 1000) && tilePosition.y != ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.rightAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.LEFT_MAP_CORNER_SAND;
                }
            }

            //BOTTOM_LEFT_CORNER
            else if (tilePosition.x == 0 && tilePosition.y == ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.topRightAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.BOTTOM_LEFT_MAP_CORNER_SAND;
                }
            }

            //BOTTOM_MAP_CORNER
            else if ((tilePosition.x != (mapGenerator.xSize * 1000) - (1000) && tilePosition.x != ((mapGenerator.xSize * 1000) - (mapGenerator.xSize * 1000))) && tilePosition.y == 0)
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.topAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.BOTTOM_MAP_CORNER_SAND;
                }
            }

            //BOTTOM_RIGHT_CORNER
            else if (tilePosition.x == ((mapGenerator.xSize * 1000) - (1000)) && tilePosition.y == ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.topLeftAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.BOTTOM_RIGHT_MAP_CORNER_SAND;
                }
            }

            //RIGHT_MAP_CORNER
            else if (tilePosition.x == ((mapGenerator.xSize * 1000) - (1000)) && tilePosition.y != ((mapGenerator.ySize * 1000) - (1000)) && tilePosition.y != ((mapGenerator.ySize * 1000) - (mapGenerator.ySize * 1000)))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.leftAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.RIGHT_MAP_CORNER_SAND;
                }  
            }

            //TOP_RIGHT_MAP_CORNER
            if (tilePosition.x == ((mapGenerator.xSize * 1000) - (1000)) && tilePosition.y == ((mapGenerator.ySize * 1000) - 1000))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.bottomLeftAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.TOP_RIGHT_MAP_CORNER_SAND;
                }

            }

            //TOP_MAP_CORNER
            else if ((tilePosition.x != (mapGenerator.xSize * 1000) - (1000) && tilePosition.x != ((mapGenerator.xSize * 1000) - (mapGenerator.xSize * 1000))) && tilePosition.y == ((mapGenerator.ySize * 1000) - 1000))
            {
                tileScript = tileChild.GetComponent<tileScript>();

                if (tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND ||
                    tileScript.bottomAdjacentTile.tileType == tileScript.TileType.SAND_CORE)
                {
                    tileScript.tileType = tileScript.TileType.TOP_MAP_CORNER_SAND;
                }
            }
        }
    }
}
