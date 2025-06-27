using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class editModeScript : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    [SerializeField] private GameObject editPanel;

    public int selectedTypeOfTile;

    [SerializeField] private Image grassImage;
    [SerializeField] private Image riverImage;
    [SerializeField] private Image forestImage;
    [SerializeField] private Image rocksImage;
    [SerializeField] private Image flowersImage;
    [SerializeField] private Image sandImage;
    [SerializeField] private Image sandRiverImage;
    [SerializeField] private Image sandRocksImage;
    [SerializeField] private Image cactusImage;
    [SerializeField] private Image palmTreeImage;

    public bool isHoldingPaintButton;

    [SerializeField] private biomeSelector biomeSelector;

    private void Update()
    {
        //When holding painting button in edit mode
        if (Input.GetMouseButton(0))
        {
            isHoldingPaintButton = true;
        }

        //When unholding painting button in edit mode
        if (Input.GetMouseButtonUp(0))
        {
            isHoldingPaintButton = false;
            biomeSelector.NewRivers();
            //biomeSelector.NewBiomesTransitions();
        }
    }


    public void grassSelected()
    {
        selectedTypeOfTile = 0;
        deselectOtherTypes();
        grassImage.color = new Color32(255, 255, 255, 255);
    }

    public void riverSelected()
    {
        selectedTypeOfTile = 1;
        deselectOtherTypes();
        riverImage.color = new Color32(255, 255, 255, 255);
    }

    public void forestSelected()
    {
        selectedTypeOfTile = 2;
        deselectOtherTypes();
        forestImage.color = new Color32(255, 255, 255, 255);
    }

    public void rocksSelected()
    {
        selectedTypeOfTile = 3;
        deselectOtherTypes();
        rocksImage.color = new Color32(255, 255, 255, 255);
    }

    public void flowersSelected()
    {
        selectedTypeOfTile = 4;
        deselectOtherTypes();
        flowersImage.color = new Color32(255, 255, 255, 255);
    }

    public void sandSelected()
    {
        selectedTypeOfTile = 5;
        deselectOtherTypes();
        sandImage.color = new Color32(255, 255, 255, 255);
    }

    public void sandRiverSelected()
    {
        selectedTypeOfTile = 6;
        deselectOtherTypes();
        sandRiverImage.color = new Color32(255, 255, 255, 255);
    }

    public void sandRocksSelected()
    {
        selectedTypeOfTile = 7;
        deselectOtherTypes();
        sandRocksImage.color = new Color32(255, 255, 255, 255);
    }

    public void cactusSelected()
    {
        selectedTypeOfTile = 8;
        deselectOtherTypes();
        cactusImage.color = new Color32(255, 255, 255, 255);
    }

    public void palmTreeSelected()
    {
        selectedTypeOfTile = 9;
        deselectOtherTypes();
        palmTreeImage.color = new Color32(255, 255, 255, 255);
    }

    //Deselect all the tile types buttons
    public void deselectOtherTypes()
    {
        grassImage.color = new Color32(150, 150, 150, 255);
        riverImage.color = new Color32(150, 150, 150, 255);
        forestImage.color = new Color32(150, 150, 150, 255);
        rocksImage.color = new Color32(150, 150, 150, 255);
        flowersImage.color = new Color32(150, 150, 150, 255);
        sandImage.color = new Color32(150, 150, 150, 255);
        sandRiverImage.color = new Color32(150, 150, 150, 255);
        sandRocksImage.color = new Color32(150, 150, 150, 255);
        cactusImage.color = new Color32(150, 150, 150, 255);
        palmTreeImage.color = new Color32(150, 150, 150, 255);
    }
}
