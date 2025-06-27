using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnRateButtonScript : MonoBehaviour
{
    public int contentAmount;
    public TextMeshProUGUI contentText;
    [SerializeField] private valuesAdjusterScript valuesAdjusterScript;

    //GRASS
    [SerializeField] private bool isRiverGrass;
    [SerializeField] private bool isForestGrass;
    [SerializeField] private bool isRocksGrass;
    [SerializeField] private bool isFlowersGrass;

    //SAND
    [SerializeField] private bool isRiverSand;
    [SerializeField] private bool isRocksSand;
    [SerializeField] private bool isCactusSand;
    [SerializeField] private bool isPalmSand;
}
