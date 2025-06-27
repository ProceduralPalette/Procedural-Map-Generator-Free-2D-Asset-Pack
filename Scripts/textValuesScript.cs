using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textValuesScript : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    [SerializeField] private mapGenerator mapGenerator;
    [SerializeField] private valuesAdjusterScript valuesAdjusterScript;
    [SerializeField] private GameObject UICanva;

    [Header("GRASS BIOME")]
    //Grass River
    [SerializeField] private TextMeshProUGUI grassBiomeRiverExtensionAmountText;
    [SerializeField] private Slider grassBiomeRiverExtensionSlider;
    public int grassBiomeRiverExtensionAmount;

    [SerializeField] private Slider grassBiomeRiverAmountSlider;
    public int grassBiomeRiverAmount;


    //Forest
    [SerializeField] private TextMeshProUGUI grassBiomeForestExtensionAmountText;
    [SerializeField] private Slider grassBiomeForestExtensionSlider;
    public int grassBiomeForestExtensionAmount;

    [SerializeField] private Slider grassBiomeForestAmountSlider;
    public int grassBiomeForestAmount;

    //Jungle Rocks 
    [SerializeField] private TextMeshProUGUI grassBiomeJungleRocksExtensionAmountText;
    [SerializeField] private Slider grassBiomeJungleRocksExtensionSlider;
    public int grassBiomeJungleRocksExtensionAmount;

    [SerializeField] private Slider grassBiomeJungleRocksAmountSlider;
    public int grassBiomeJungleRocksAmount;

    //Flowers 
    [SerializeField] private TextMeshProUGUI grassBiomeFlowersExtensionAmountText;
    [SerializeField] private Slider grassBiomeFlowersExtensionSlider;
    public int grassBiomeFlowersExtensionAmount;

    [SerializeField] private Slider grassBiomeFlowersAmountSlider;
    public int grassBiomeFlowersAmount;


    [Header("SAND BIOME")]
    //Sand River
    [SerializeField] private TextMeshProUGUI sandBiomeRiverExtensionAmountText;
    [SerializeField] private Slider sandBiomeRiverExtensionSlider;
    public int sandBiomeRiverExtensionAmount;

    [SerializeField] private Slider sandBiomeRiverAmountSlider;
    public int sandBiomeRiverAmount;

    //Sand Rocks
    [SerializeField] private TextMeshProUGUI sandBiomeSandRocksExtensionAmountText;
    [SerializeField] private Slider sandBiomeSandRocksExtensionSlider;
    public int sandBiomeSandRocksExtensionAmount;

    [SerializeField] private Slider sandBiomeRocksAmountSlider;
    public int sandBiomeRocksAmount;

    //Palm Tree
    [SerializeField] private TextMeshProUGUI sandBiomePalmTreeExtensionAmountText;
    [SerializeField] private Slider sandBiomePalmTreeExtensionSlider;
    public int sandBiomePalmTreeExtensionAmount;

    [SerializeField] private Slider sandBiomePalmTreeAmountSlider;
    public int sandBiomePalmTreeAmount;

    //Cactus
    [SerializeField] private TextMeshProUGUI sandBiomeCactusExtensionAmountText;
    [SerializeField] private Slider sandBiomeCactusExtensionSlider;
    public int sandBiomeCactusExtensionAmount;

    [SerializeField] private Slider sandBiomeCactusAmountSlider;
    public int sandBiomeCactusAmount;

    //Biomes Amount
    [SerializeField] private TextMeshProUGUI biomesAmountText;

    [SerializeField] private GameObject forestScreen;
    [SerializeField] private GameObject desertScreen;

    [SerializeField] private GameObject forestIconSelected;
    [SerializeField] private GameObject desertIconSelected;

    [SerializeField] private GameObject forestScreen2;
    [SerializeField] private GameObject desertScreen2;

    [SerializeField] private GameObject forestIconSelected2;
    [SerializeField] private GameObject desertIconSelected2;

    //Others
    [SerializeField] TextMeshProUGUI grassWaterAmountText;
    [SerializeField] TextMeshProUGUI grassForestAmountText;
    [SerializeField] TextMeshProUGUI grassRocksAmountText;
    [SerializeField] TextMeshProUGUI grassFlowersAmountText;

    [SerializeField] TextMeshProUGUI sandWaterAmountText;
    [SerializeField] TextMeshProUGUI sandPalmTreeAmountText;
    [SerializeField] TextMeshProUGUI sandRocksAmountText;
    [SerializeField] TextMeshProUGUI sandCactusAmountText;


    [SerializeField] private Slider biomesAmountSlider;
    public int biomesAmount;

    //Forest Biome Selected in the editor
    public void ForestScreenSelected()
    {
        forestScreen.SetActive(true);
        desertScreen.SetActive(false);
        desertIconSelected.SetActive(false);
        forestIconSelected.SetActive(true);

        forestScreen2.SetActive(true);
        desertScreen2.SetActive(false);
        desertIconSelected2.SetActive(false);
        forestIconSelected2.SetActive(true);
    }

    //Desert Biome Selected in the editor
    public void DesertScreenSelected()
    {
        forestScreen.SetActive(false);
        desertScreen.SetActive(true);
        desertIconSelected.SetActive(true);
        forestIconSelected.SetActive(false);

        forestScreen2.SetActive(false);
        desertScreen2.SetActive(true);
        forestIconSelected2.SetActive(false);
        desertIconSelected2.SetActive(true);
    }

    private void Update()
    {
        biomesAmount = (int)biomesAmountSlider.value;
        mapGenerator.biomesAmount = biomesAmount;

        //Update texts
        sandWaterAmountText.text = valuesAdjusterScript.sandBiomesRiverSpawn.ToString();
        sandPalmTreeAmountText.text = valuesAdjusterScript.sandBiomesPalmTreeSpawn.ToString();
        sandRocksAmountText.text = valuesAdjusterScript.sandBiomesSandRocksSpawn.ToString();
        sandCactusAmountText.text = valuesAdjusterScript.sandBiomesCactusSpawn.ToString();

        grassWaterAmountText.text = valuesAdjusterScript.grassBiomesRiverSpawn.ToString();
        grassForestAmountText.text = valuesAdjusterScript.grassBiomesForestSpawn.ToString();
        grassRocksAmountText.text = valuesAdjusterScript.grassBiomesRocksSpawn.ToString();
        grassFlowersAmountText.text = valuesAdjusterScript.grassBiomesFlowersSpawn.ToString();


        //Biomes Amount
        biomesAmountText.text = mapGenerator.biomesAmount.ToString();

        //GRASS

        //Grass River
        grassBiomeRiverExtensionAmount = (int)grassBiomeRiverExtensionSlider.value;
        grassBiomeRiverExtensionAmountText.text = grassBiomeRiverExtensionAmount.ToString();
        valuesAdjusterScript.grassBiomesRiverExpansionPercentage = grassBiomeRiverExtensionAmount;

        grassBiomeRiverAmount = (int)grassBiomeRiverAmountSlider.value;
        valuesAdjusterScript.grassBiomesRiverSpawn = grassBiomeRiverAmount;


        //Forest
        grassBiomeForestExtensionAmount = (int)grassBiomeForestExtensionSlider.value;
        grassBiomeForestExtensionAmountText.text = grassBiomeForestExtensionAmount.ToString();
        valuesAdjusterScript.grassBiomesForestExpansionPercentage = grassBiomeForestExtensionAmount;

        grassBiomeForestAmount = (int)grassBiomeForestAmountSlider.value;
        valuesAdjusterScript.grassBiomesForestSpawn = grassBiomeForestAmount;

        //Jungle Rocks
        grassBiomeJungleRocksExtensionAmount = (int)grassBiomeJungleRocksExtensionSlider.value;
        grassBiomeJungleRocksExtensionAmountText.text = grassBiomeJungleRocksExtensionAmount.ToString();
        valuesAdjusterScript.grassBiomesJungleRocksExpansionPercentage = grassBiomeJungleRocksExtensionAmount;

        grassBiomeJungleRocksAmount = (int)grassBiomeJungleRocksAmountSlider.value;
        valuesAdjusterScript.grassBiomesRocksSpawn = grassBiomeJungleRocksAmount;

        //Flowers
        grassBiomeFlowersExtensionAmount = (int)grassBiomeFlowersExtensionSlider.value;
        grassBiomeFlowersExtensionAmountText.text = grassBiomeFlowersExtensionAmount.ToString();
        valuesAdjusterScript.grassBiomesFlowersExpansionPercentage = grassBiomeFlowersExtensionAmount;

        grassBiomeFlowersAmount = (int)grassBiomeFlowersAmountSlider.value;
        valuesAdjusterScript.grassBiomesFlowersSpawn = grassBiomeFlowersAmount;

        //SAND

        //Sand River
        sandBiomeRiverExtensionAmount = (int)sandBiomeRiverExtensionSlider.value;
        sandBiomeRiverExtensionAmountText.text = sandBiomeRiverExtensionAmount.ToString();
        valuesAdjusterScript.sandBiomesRiverExpansionPercentage = sandBiomeRiverExtensionAmount;

        sandBiomeRiverAmount = (int)sandBiomeRiverAmountSlider.value;
        valuesAdjusterScript.sandBiomesRiverSpawn = sandBiomeRiverAmount;

        //Sand Rocks
        sandBiomeSandRocksExtensionAmount = (int)sandBiomeSandRocksExtensionSlider.value;
        sandBiomeSandRocksExtensionAmountText.text = sandBiomeSandRocksExtensionAmount.ToString();
        valuesAdjusterScript.sandBiomesSandRocksExpansionPercentage = sandBiomeSandRocksExtensionAmount;

        sandBiomeRocksAmount = (int)sandBiomeRocksAmountSlider.value;
        valuesAdjusterScript.sandBiomesSandRocksSpawn = sandBiomeRocksAmount;

        //Palm Tree
        sandBiomePalmTreeExtensionAmount = (int)sandBiomePalmTreeExtensionSlider.value;
        sandBiomePalmTreeExtensionAmountText.text = sandBiomePalmTreeExtensionAmount.ToString();
        valuesAdjusterScript.sandBiomesPalmTreeExpansionPercentage = sandBiomePalmTreeExtensionAmount;

        sandBiomePalmTreeAmount = (int)sandBiomePalmTreeAmountSlider.value;
        valuesAdjusterScript.sandBiomesPalmTreeSpawn = sandBiomePalmTreeAmount;

        //Cactus
        sandBiomeCactusExtensionAmount = (int)sandBiomeCactusExtensionSlider.value;
        sandBiomeCactusExtensionAmountText.text = sandBiomeCactusExtensionAmount.ToString();
        valuesAdjusterScript.sandBiomesCactusExpansionPercentage = sandBiomeCactusExtensionAmount;

        sandBiomeCactusAmount = (int)sandBiomeCactusAmountSlider.value;
        valuesAdjusterScript.sandBiomesCactusSpawn = sandBiomeCactusAmount;
    }
}
