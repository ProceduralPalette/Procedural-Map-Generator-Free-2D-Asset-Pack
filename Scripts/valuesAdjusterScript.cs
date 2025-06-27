using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class valuesAdjusterScript : MonoBehaviour
{
    [Header("GRASS BIOME SPAWN VALUES (0-5)")]
    //GRASS BIOME SPAWN VALUES
    public int grassBiomesRiverSpawn;
    public int grassBiomesForestSpawn;
    public int grassBiomesRocksSpawn;
    public int grassBiomesFlowersSpawn;


    [Header("GRASS BIOME EXPANSION VALUES (0-100)")]
    //GRASS BIOME EXPANSION VALUES
    public int grassBiomesRiverExpansionPercentage;
    public int grassBiomesForestExpansionPercentage;
    public int grassBiomesJungleRocksExpansionPercentage;
    public int grassBiomesFlowersExpansionPercentage;


    [Header("SAND BIOME SPAWN VALUES (0-5)")]
    //GRASS BIOME SPAWN VALUES
    public int sandBiomesRiverSpawn;
    public int sandBiomesSandRocksSpawn;
    public int sandBiomesCactusSpawn;
    public int sandBiomesPalmTreeSpawn;

    [Header("SAND BIOME EXPANSION VALUES (0-100)")]
    //SAND BIOME VALUES
    public int sandBiomesRiverExpansionPercentage;
    public int sandBiomesPalmTreeExpansionPercentage;
    public int sandBiomesCactusExpansionPercentage;
    public int sandBiomesSandRocksExpansionPercentage;


    [Header("CHOOSE TILE SCRIPT VALUES")]
    //LENGHT MUST BE 20
    public int[] weightedChoicesGrass = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    public int[] weightedChoicesSand = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    private void Update()
    {

        //RIVER GRASS
        if (grassBiomesRiverSpawn == 0)
        {
            weightedChoicesGrass[0] = 1;
            weightedChoicesGrass[1] = 1;
            weightedChoicesGrass[2] = 1;
            weightedChoicesGrass[3] = 1;
            weightedChoicesGrass[4] = 1;
        }

        if (grassBiomesRiverSpawn == 1)
        {
            weightedChoicesGrass[0] = 2;
            weightedChoicesGrass[1] = 1;
            weightedChoicesGrass[2] = 1;
            weightedChoicesGrass[3] = 1;
            weightedChoicesGrass[4] = 1;
        }

        if (grassBiomesRiverSpawn == 2)
        {
            weightedChoicesGrass[0] = 2;
            weightedChoicesGrass[1] = 2;
            weightedChoicesGrass[2] = 1;
            weightedChoicesGrass[3] = 1;
            weightedChoicesGrass[4] = 1;
        }

        if (grassBiomesRiverSpawn == 3)
        {
            weightedChoicesGrass[0] = 2;
            weightedChoicesGrass[1] = 2;
            weightedChoicesGrass[2] = 2;
            weightedChoicesGrass[3] = 1;
            weightedChoicesGrass[4] = 1;
        }

        if (grassBiomesRiverSpawn == 4)
        {
            weightedChoicesGrass[0] = 2;
            weightedChoicesGrass[1] = 2;
            weightedChoicesGrass[2] = 2;
            weightedChoicesGrass[3] = 2;
            weightedChoicesGrass[4] = 1;
        }

        if (grassBiomesRiverSpawn == 5)
        {
            weightedChoicesGrass[0] = 2;
            weightedChoicesGrass[1] = 2;
            weightedChoicesGrass[2] = 2;
            weightedChoicesGrass[3] = 2;
            weightedChoicesGrass[4] = 2;
        }


        //FOREST
        if (grassBiomesForestSpawn == 0)
        {
            weightedChoicesGrass[5] = 1;
            weightedChoicesGrass[6] = 1;
            weightedChoicesGrass[7] = 1;
            weightedChoicesGrass[8] = 1;
            weightedChoicesGrass[9] = 1;
        }

        if (grassBiomesForestSpawn == 1)
        {
            weightedChoicesGrass[5] = 3;
            weightedChoicesGrass[6] = 1;
            weightedChoicesGrass[7] = 1;
            weightedChoicesGrass[8] = 1;
            weightedChoicesGrass[9] = 1;
        }

        if (grassBiomesForestSpawn == 2)
        {
            weightedChoicesGrass[5] = 3;
            weightedChoicesGrass[6] = 3;
            weightedChoicesGrass[7] = 1;
            weightedChoicesGrass[8] = 1;
            weightedChoicesGrass[9] = 1;
        }

        if (grassBiomesForestSpawn == 3)
        {
            weightedChoicesGrass[5] = 3;
            weightedChoicesGrass[6] = 3;
            weightedChoicesGrass[7] = 3;
            weightedChoicesGrass[8] = 1;
            weightedChoicesGrass[9] = 1;
        }

        if (grassBiomesForestSpawn == 4)
        {
            weightedChoicesGrass[5] = 3;
            weightedChoicesGrass[6] = 3;
            weightedChoicesGrass[7] = 3;
            weightedChoicesGrass[8] = 3;
            weightedChoicesGrass[9] = 1;
        }

        if (grassBiomesForestSpawn == 5)
        {
            weightedChoicesGrass[5] = 3;
            weightedChoicesGrass[6] = 3;
            weightedChoicesGrass[7] = 3;
            weightedChoicesGrass[8] = 3;
            weightedChoicesGrass[9] = 3;
        }


        //ROCKS
        if (grassBiomesRocksSpawn == 0)
        {
            weightedChoicesGrass[10] = 1;
            weightedChoicesGrass[11] = 1;
            weightedChoicesGrass[12] = 1;
            weightedChoicesGrass[13] = 1;
            weightedChoicesGrass[14] = 1;
        }

        if (grassBiomesRocksSpawn == 1)
        {
            weightedChoicesGrass[10] = 4;
            weightedChoicesGrass[11] = 1;
            weightedChoicesGrass[12] = 1;
            weightedChoicesGrass[13] = 1;
            weightedChoicesGrass[14] = 1;
        }

        if (grassBiomesRocksSpawn == 2)
        {
            weightedChoicesGrass[10] = 4;
            weightedChoicesGrass[11] = 4;
            weightedChoicesGrass[12] = 1;
            weightedChoicesGrass[13] = 1;
            weightedChoicesGrass[14] = 1;
        }

        if (grassBiomesRocksSpawn == 3)
        {
            weightedChoicesGrass[10] = 4;
            weightedChoicesGrass[11] = 4;
            weightedChoicesGrass[12] = 4;
            weightedChoicesGrass[13] = 1;
            weightedChoicesGrass[14] = 1;
        }

        if (grassBiomesRocksSpawn == 4)
        {
            weightedChoicesGrass[10] = 4;
            weightedChoicesGrass[11] = 4;
            weightedChoicesGrass[12] = 4;
            weightedChoicesGrass[13] = 4;
            weightedChoicesGrass[14] = 1;
        }

        if (grassBiomesRocksSpawn == 5)
        {
            weightedChoicesGrass[10] = 4;
            weightedChoicesGrass[11] = 4;
            weightedChoicesGrass[12] = 4;
            weightedChoicesGrass[13] = 4;
            weightedChoicesGrass[14] = 4;
        }


        //FLOWERS
        if (grassBiomesFlowersSpawn == 0)
        {
            weightedChoicesGrass[15] = 1;
            weightedChoicesGrass[16] = 1;
            weightedChoicesGrass[17] = 1;
            weightedChoicesGrass[18] = 1;
            weightedChoicesGrass[19] = 1;
        }

        if (grassBiomesFlowersSpawn == 1)
        {
            weightedChoicesGrass[15] = 5;
            weightedChoicesGrass[16] = 1;
            weightedChoicesGrass[17] = 1;
            weightedChoicesGrass[18] = 1;
            weightedChoicesGrass[19] = 1;
        }

        if (grassBiomesFlowersSpawn == 2)
        {
            weightedChoicesGrass[15] = 5;
            weightedChoicesGrass[16] = 5;
            weightedChoicesGrass[17] = 1;
            weightedChoicesGrass[18] = 1;
            weightedChoicesGrass[19] = 1;
        }

        if (grassBiomesFlowersSpawn == 3)
        {
            weightedChoicesGrass[15] = 5;
            weightedChoicesGrass[16] = 5;
            weightedChoicesGrass[17] = 5;
            weightedChoicesGrass[18] = 1;
            weightedChoicesGrass[19] = 1;
        }

        if (grassBiomesFlowersSpawn == 4)
        {
            weightedChoicesGrass[15] = 5;
            weightedChoicesGrass[16] = 5;
            weightedChoicesGrass[17] = 5;
            weightedChoicesGrass[18] = 5;
            weightedChoicesGrass[19] = 1;
        }

        if (grassBiomesFlowersSpawn == 5)
        {
            weightedChoicesGrass[15] = 5;
            weightedChoicesGrass[16] = 5;
            weightedChoicesGrass[17] = 5;
            weightedChoicesGrass[18] = 5;
            weightedChoicesGrass[19] = 5;
        }


        //RIVER SAND
        if (sandBiomesRiverSpawn == 0)
        {
            weightedChoicesSand[0] = 1;
            weightedChoicesSand[1] = 1;
            weightedChoicesSand[2] = 1;
            weightedChoicesSand[3] = 1;
            weightedChoicesSand[4] = 1;
        }

        if (sandBiomesRiverSpawn == 1)
        {
            weightedChoicesSand[0] = 6;
            weightedChoicesSand[1] = 1;
            weightedChoicesSand[2] = 1;
            weightedChoicesSand[3] = 1;
            weightedChoicesSand[4] = 1;
        }

        if (sandBiomesRiverSpawn == 2)
        {
            weightedChoicesSand[0] = 6;
            weightedChoicesSand[1] = 6;
            weightedChoicesSand[2] = 1;
            weightedChoicesSand[3] = 1;
            weightedChoicesSand[4] = 1;
        }

        if (sandBiomesRiverSpawn == 3)
        {
            weightedChoicesSand[0] = 6;
            weightedChoicesSand[1] = 6;
            weightedChoicesSand[2] = 6;
            weightedChoicesSand[3] = 1;
            weightedChoicesSand[4] = 1;
        }

        if (sandBiomesRiverSpawn == 4)
        {
            weightedChoicesSand[0] = 6;
            weightedChoicesSand[1] = 6;
            weightedChoicesSand[2] = 6;
            weightedChoicesSand[3] = 6;
            weightedChoicesSand[4] = 1;
        }

        if (sandBiomesRiverSpawn == 5)
        {
            weightedChoicesSand[0] = 6;
            weightedChoicesSand[1] = 6;
            weightedChoicesSand[2] = 6;
            weightedChoicesSand[3] = 6;
            weightedChoicesSand[4] = 6;
        }


        // SAND ROCKS
        if (sandBiomesSandRocksSpawn == 0)
        {
            weightedChoicesSand[5] = 1;
            weightedChoicesSand[6] = 1;
            weightedChoicesSand[7] = 1;
            weightedChoicesSand[8] = 1;
            weightedChoicesSand[9] = 1;
        }

        if (sandBiomesSandRocksSpawn == 1)
        {
            weightedChoicesSand[5] = 3;
            weightedChoicesSand[6] = 1;
            weightedChoicesSand[7] = 1;
            weightedChoicesSand[8] = 1;
            weightedChoicesSand[9] = 1;
        }

        if (sandBiomesSandRocksSpawn == 2)
        {
            weightedChoicesSand[5] = 3;
            weightedChoicesSand[6] = 3;
            weightedChoicesSand[7] = 1;
            weightedChoicesSand[8] = 1;
            weightedChoicesSand[9] = 1;
        }

        if (sandBiomesSandRocksSpawn == 3)
        {
            weightedChoicesSand[5] = 3;
            weightedChoicesSand[6] = 3;
            weightedChoicesSand[7] = 3;
            weightedChoicesSand[8] = 1;
            weightedChoicesSand[9] = 1;
        }

        if (sandBiomesSandRocksSpawn == 4)
        {
            weightedChoicesSand[5] = 3;
            weightedChoicesSand[6] = 3;
            weightedChoicesSand[7] = 3;
            weightedChoicesSand[8] = 3;
            weightedChoicesSand[9] = 1;
        }

        if (sandBiomesSandRocksSpawn == 5)
        {
            weightedChoicesSand[5] = 3;
            weightedChoicesSand[6] = 3;
            weightedChoicesSand[7] = 3;
            weightedChoicesSand[8] = 3;
            weightedChoicesSand[9] = 3;
        }


        // CACTUS 
        if (sandBiomesCactusSpawn == 0)
        {
            weightedChoicesSand[10] = 1;
            weightedChoicesSand[11] = 1;
            weightedChoicesSand[12] = 1;
            weightedChoicesSand[13] = 1;
            weightedChoicesSand[14] = 1;
        }

        if (sandBiomesCactusSpawn == 1)
        {
            weightedChoicesSand[10] = 4;
            weightedChoicesSand[11] = 1;
            weightedChoicesSand[12] = 1;
            weightedChoicesSand[13] = 1;
            weightedChoicesSand[14] = 1;
        }

        if (sandBiomesCactusSpawn == 2)
        {
            weightedChoicesSand[10] = 4;
            weightedChoicesSand[11] = 4;
            weightedChoicesSand[12] = 1;
            weightedChoicesSand[13] = 1;
            weightedChoicesSand[14] = 1;
        }

        if (sandBiomesCactusSpawn == 3)
        {
            weightedChoicesSand[10] = 4;
            weightedChoicesSand[11] = 4;
            weightedChoicesSand[12] = 4;
            weightedChoicesSand[13] = 1;
            weightedChoicesSand[14] = 1;
        }

        if (sandBiomesCactusSpawn == 4)
        {
            weightedChoicesSand[10] = 4;
            weightedChoicesSand[11] = 4;
            weightedChoicesSand[12] = 4;
            weightedChoicesSand[13] = 4;
            weightedChoicesSand[14] = 1;
        }

        if (sandBiomesCactusSpawn == 5)
        {
            weightedChoicesSand[10] = 4;
            weightedChoicesSand[11] = 4;
            weightedChoicesSand[12] = 4;
            weightedChoicesSand[13] = 4;
            weightedChoicesSand[14] = 4;
        }


        // PALM TREE 
        if (sandBiomesPalmTreeSpawn == 0)
        {
            weightedChoicesSand[15] = 1;
            weightedChoicesSand[16] = 1;
            weightedChoicesSand[17] = 1;
            weightedChoicesSand[18] = 1;
            weightedChoicesSand[19] = 1;
        }

        if (sandBiomesPalmTreeSpawn == 1)
        {
            weightedChoicesSand[15] = 5;
            weightedChoicesSand[16] = 1;
            weightedChoicesSand[17] = 1;
            weightedChoicesSand[18] = 1;
            weightedChoicesSand[19] = 1;
        }

        if (sandBiomesPalmTreeSpawn == 2)
        {
            weightedChoicesSand[15] = 5;
            weightedChoicesSand[16] = 5;
            weightedChoicesSand[17] = 1;
            weightedChoicesSand[18] = 1;
            weightedChoicesSand[19] = 1;
        }

        if (sandBiomesPalmTreeSpawn == 3)
        {
            weightedChoicesSand[15] = 5;
            weightedChoicesSand[16] = 5;
            weightedChoicesSand[17] = 5;
            weightedChoicesSand[18] = 1;
            weightedChoicesSand[19] = 1;
        }

        if (sandBiomesPalmTreeSpawn == 4)
        {
            weightedChoicesSand[15] = 5;
            weightedChoicesSand[16] = 5;
            weightedChoicesSand[17] = 5;
            weightedChoicesSand[18] = 5;
            weightedChoicesSand[19] = 1;
        }

        if (sandBiomesPalmTreeSpawn == 5)
        {
            weightedChoicesSand[15] = 5;
            weightedChoicesSand[16] = 5;
            weightedChoicesSand[17] = 5;
            weightedChoicesSand[18] = 5;
            weightedChoicesSand[19] = 5;
        }
    }
}
