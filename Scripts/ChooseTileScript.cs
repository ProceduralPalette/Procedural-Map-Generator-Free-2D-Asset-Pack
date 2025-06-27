using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTileScript : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    public biomeSelector biomeSelector;
    public biomeScript biomeScript;

    public riverScript riverScript;
    public riverSandScript riverSandScript;
    public forestScript forestScript;
    public sandRocksScript sandRocksScript;
    public cactusScript cactusScript;
    public palmTreeScript palmTreeScript;
    public jungleRocksScript jungleRocksScript;
    public flowersScript flowersScript;

    public int numForTileInArray;
    public int tilesIterated;

    [Header("AUTOMATIC")]
    private int randomNumToChooseItemGrass;
    private int randomNumToChooseItemSand;

    public valuesAdjusterScript valuesAdjusterScript;


    public void ChooseTile()
    {
        randomNumToChooseItemGrass = valuesAdjusterScript.weightedChoicesGrass[Random.Range(0, valuesAdjusterScript.weightedChoicesGrass.Length)];

        randomNumToChooseItemSand = valuesAdjusterScript.weightedChoicesSand[Random.Range(0, valuesAdjusterScript.weightedChoicesSand.Length)];

        // GRASS BIOME

        if (randomNumToChooseItemGrass == 2)
        {
            riverScript.CreateRiver();
        }


        if (biomeScript.isGrassBiome)
        {
            if (randomNumToChooseItemGrass == 3)
            {
                forestScript.CreateForest();
            }
        }

        
        if (biomeScript.isGrassBiome)
        {
            if (randomNumToChooseItemGrass == 4)
            {
                jungleRocksScript.CreateJungleRocks();
            }
        }


        if (biomeScript.isGrassBiome)
        {
            if (randomNumToChooseItemGrass == 5)
            {
                flowersScript.CreateFlowers();
            }
        }


        // SAND BIOME
        if (randomNumToChooseItemSand == 6)
        {
            riverSandScript.CreateRiver();
        }

        if (biomeScript.isSandBiome)
        {
            if (randomNumToChooseItemSand == 3)
            {
                sandRocksScript.CreateSandRocks();
            }
        }

        if (biomeScript.isSandBiome)
        {
            if (randomNumToChooseItemSand == 4)
            {
                cactusScript.CreateCactus();
            }
        }
        if (biomeScript.isSandBiome)
        {
            if (randomNumToChooseItemSand == 5)
            {
                palmTreeScript.CreatePalmTree();
            }
        }
    }
}
