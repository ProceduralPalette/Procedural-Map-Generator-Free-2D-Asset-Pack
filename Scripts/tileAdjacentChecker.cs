using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Tile.Utilities;

public class tileAdjacentChecker : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    //mapCanvas Gameobject
    [SerializeField] private GameObject mapCanvasGameObject;

    [Header("AUTOMATIC")]

    //tileScript Script
    [SerializeField] tileScript tileScript;

    //tileScript Script to iterate
    [SerializeField] tileScript otherTileScript;

    //Gameobject of the tile
    [SerializeField] private GameObject tileChild;

    //Gameobject of the tile to iterate
    [SerializeField] private GameObject otherTileChild;


    //Function to check the adjacent tiles
    public void CheckAdjacentTiles()
    {
        //For to iterate all the current tiles
        for (int i = 0; i < mapCanvasGameObject.transform.childCount; i++)
        {
            //Select tile iterating
            tileChild = mapCanvasGameObject.transform.GetChild(i).gameObject;

            //tile location
            Vector2 tilePosition = tileChild.GetComponent<RectTransform>().anchoredPosition;
            
            //tilescript of the tile
            tileScript = tileChild.GetComponent<tileScript>();

            //For to iterate all the current tiles
            for (int j = 0; j < mapCanvasGameObject.transform.childCount; j++)
            {
                //Position of the other tile
                otherTileChild = mapCanvasGameObject.transform.GetChild(j).gameObject;

                //tileScript of the other tile
                Vector2 otherTilePosition = otherTileChild.GetComponent<RectTransform>().anchoredPosition;

                //Check LEFT
                //Find left tile
                if (otherTilePosition.x == (tilePosition.x -1000) && otherTilePosition.y == tilePosition.y)
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.leftAdjacentTile = otherTileScript;
                }

                //Check RIGHT
                //Find right tile
                if (otherTilePosition.x == (tilePosition.x + 1000) && otherTilePosition.y == tilePosition.y)
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.rightAdjacentTile = otherTileScript;
                }

                //Check TOP
                //Find top tile
                if (otherTilePosition.x == tilePosition.x && otherTilePosition.y == (tilePosition.y +1000))
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.topAdjacentTile = otherTileScript;
                }

                //Check BOTTOM
                //Find bottom tile
                if (otherTilePosition.x == tilePosition.x && otherTilePosition.y == (tilePosition.y - 1000))
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.bottomAdjacentTile = otherTileScript;
                }

                //Check TOP LEFT
                //Find top left tile
                if (otherTilePosition.x == (tilePosition.x - 1000) && otherTilePosition.y == (tilePosition.y + 1000))
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.topLeftAdjacentTile = otherTileScript;
                }

                //Check TOP RIGHT
                //Find top right tile
                if (otherTilePosition.x == (tilePosition.x + 1000) && otherTilePosition.y == (tilePosition.y + 1000))
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.topRightAdjacentTile = otherTileScript;
                }

                //Check BOTTOM LEFT
                //Find bottom left tile
                if (otherTilePosition.x == (tilePosition.x - 1000) && otherTilePosition.y == (tilePosition.y - 1000))
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.bottomLeftAdjacentTile = otherTileScript;
                }

                //Check BOTTOM RIGHT
                //Find bottom right tile
                if (otherTilePosition.x == (tilePosition.x + 1000) && otherTilePosition.y == (tilePosition.y - 1000))
                {
                    otherTileScript = otherTileChild.GetComponent<tileScript>();
                    tileScript.bottomRightAdjacentTile = otherTileScript;
                }
            }
        }
    }
}
