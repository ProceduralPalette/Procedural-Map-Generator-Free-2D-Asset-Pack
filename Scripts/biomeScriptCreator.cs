using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biomeScriptCreator : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    public GameObject biomePrefab;
    [SerializeField] private biomeScript biomeScript;
    [SerializeField] private GameObject biomesGameObject;
    [SerializeField] private biomeSelector biomeSelector;

    [SerializeField] private GameObject gameManagerGameobject;
    [SerializeField] private mapGenerator mapGenerator;

    [Header("AUTOMATIC")]
    private int biomeIDCounter = 0;


    public void IntantiateBiomesFunction()
    {
        GameObject newBiome = Instantiate(biomePrefab);
        biomeScript = newBiome.GetComponent<biomeScript>();
        biomeScript.biomeID = biomeIDCounter;
        biomeIDCounter++;

        newBiome.transform.SetParent(biomesGameObject.transform, false);
        biomeSelector newBiomeSelector = gameManagerGameobject.transform.GetComponent<biomeSelector>();
        valuesAdjusterScript valuesAdjusterScript = gameManagerGameobject.transform.GetComponent<valuesAdjusterScript>();

        biomeScript.biomeSelector = newBiomeSelector;

        biomeScript.riverScript.biomeSelector = newBiomeSelector;
        biomeScript.riverScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.riverSandScript.biomeSelector = newBiomeSelector;
        biomeScript.riverSandScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.forestScript.biomeSelector = newBiomeSelector;
        biomeScript.forestScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.sandRocksScript.biomeSelector = newBiomeSelector;
        biomeScript.sandRocksScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.cactusScript.biomeSelector = newBiomeSelector;
        biomeScript.cactusScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.palmTreeScript.biomeSelector = newBiomeSelector;
        biomeScript.palmTreeScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.jungleRocksScript.biomeSelector = newBiomeSelector;
        biomeScript.jungleRocksScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.flowersScript.biomeSelector = newBiomeSelector;
        biomeScript.flowersScript.valuesAdjusterScript = valuesAdjusterScript;

        biomeScript.chooseTileScript.valuesAdjusterScript = valuesAdjusterScript;
    }

    public void PlaceBiomesIntoBiomesArray()
    {
        for (int i = 0; i < 11; i++)
        {
            biomeScript = biomesGameObject.transform.GetChild(i).GetComponent<biomeScript>();
            biomeSelector.biomeScriptArray[i] = biomeScript;

            int randomNum = Random.RandomRange(0, 5);

            if (randomNum == 0 || randomNum == 1 || randomNum == 2)
            {
                biomeScript.isGrassBiome = true;
                biomeScript.isSandBiome = false;
            }

            if (randomNum == 3 || randomNum == 4)
            {
                biomeScript.isGrassBiome = false;
                biomeScript.isSandBiome = true;
            }
        }
    }
}
