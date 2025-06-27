using UnityEngine;
using UnityEngine.UI;


namespace Tile.Utilities
{


public class tileScript : MonoBehaviour
{
    [Header("DON'T TOUCH")]
    //Tile image
    public Image tileImage;

    //Sprites
    [SerializeField] Sprite topLeftMapCornerGrass;
    [SerializeField] Sprite topLeftMapCornerSand;
    [SerializeField] Sprite leftMapCornerGrass;
    [SerializeField] Sprite leftMapCornerSand;
    [SerializeField] Sprite bottomLeftMapCornerGrass;
    [SerializeField] Sprite bottomLeftMapCornerSand;
    [SerializeField] Sprite bottomMapCornerGrass;
    [SerializeField] Sprite bottomMapCornerSand;
    [SerializeField] Sprite bottomRightMapCornerGrass;
    [SerializeField] Sprite bottomRightMapCornerSand;
    [SerializeField] Sprite rightMapCornerGrass;
    [SerializeField] Sprite rightMapCornerSand;
    [SerializeField] Sprite topRightMapCornerGrass;
    [SerializeField] Sprite topRightMapCornerSand;
    [SerializeField] Sprite topMapCornerGrass;
    [SerializeField] Sprite topMapCornerSand;

    [SerializeField] Sprite sandCoreSprite;

    [SerializeField] Sprite sandSprite_1;
    [SerializeField] Sprite sandSprite_2;
    [SerializeField] Sprite sandSprite_3;
    [SerializeField] Sprite sandSprite_4;
    [SerializeField] Sprite sandSprite_5;
    [SerializeField] Sprite sandSprite_6;
    [SerializeField] Sprite sandSprite_7;
    [SerializeField] Sprite sandSprite_8;
    [SerializeField] Sprite sandSprite_9;
    [SerializeField] Sprite sandSprite_10;

    [SerializeField] Sprite cactusSprite_1;
    [SerializeField] Sprite cactusSprite_2;
    [SerializeField] Sprite cactusSprite_3;
    [SerializeField] Sprite cactusSprite_4;
    [SerializeField] Sprite cactusSprite_5;
    [SerializeField] Sprite cactusSprite_6;
    [SerializeField] Sprite cactusSprite_7;
    [SerializeField] Sprite cactusSprite_8;
    [SerializeField] Sprite cactusSprite_9;
    [SerializeField] Sprite cactusSprite_10;

    [SerializeField] Sprite palmTreeSprite_1;
    [SerializeField] Sprite palmTreeSprite_2;
    [SerializeField] Sprite palmTreeSprite_3;
    [SerializeField] Sprite palmTreeSprite_4;
    [SerializeField] Sprite palmTreeSprite_5;
    [SerializeField] Sprite palmTreeSprite_6;
    [SerializeField] Sprite palmTreeSprite_7;
    [SerializeField] Sprite palmTreeSprite_8;
    [SerializeField] Sprite palmTreeSprite_9;
    [SerializeField] Sprite palmTreeSprite_10;

    [SerializeField] Sprite grassCoreSprite;

    [SerializeField] Sprite grassSprite_1;
    [SerializeField] Sprite grassSprite_2;
    [SerializeField] Sprite grassSprite_3;
    [SerializeField] Sprite grassSprite_4;
    [SerializeField] Sprite grassSprite_5;
    [SerializeField] Sprite grassSprite_6;
    [SerializeField] Sprite grassSprite_7;
    [SerializeField] Sprite grassSprite_8;
    [SerializeField] Sprite grassSprite_9;
    [SerializeField] Sprite grassSprite_10;

    [SerializeField] Sprite grassWaterSprite_1;
    [SerializeField] Sprite grassWaterSprite_2;
    [SerializeField] Sprite grassWaterSprite_3;
    [SerializeField] Sprite grassWaterSprite_4;
    [SerializeField] Sprite grassWaterSprite_5;
    [SerializeField] Sprite grassWaterSprite_6;
    [SerializeField] Sprite grassWaterSprite_7;
    [SerializeField] Sprite grassWaterSprite_8;
    [SerializeField] Sprite grassWaterSprite_9;
    [SerializeField] Sprite grassWaterSprite_10;
    [SerializeField] Sprite grassWaterSprite_11;
    [SerializeField] Sprite grassWaterSprite_12;
    [SerializeField] Sprite grassWaterSprite_13;
    [SerializeField] Sprite grassWaterSprite_14;
    [SerializeField] Sprite grassWaterSprite_15;
    [SerializeField] Sprite grassWaterSprite_16;
    [SerializeField] Sprite grassWaterSprite_17;
    [SerializeField] Sprite grassWaterSprite_18;
    [SerializeField] Sprite grassWaterSprite_19;
    [SerializeField] Sprite grassWaterSprite_20;
    [SerializeField] Sprite fullWaterSprite;
    [SerializeField] Sprite grassWaterSprite_22;
    [SerializeField] Sprite grassWaterSprite_23;
    [SerializeField] Sprite grassWaterSprite_24;
    [SerializeField] Sprite grassWaterSprite_25;
    [SerializeField] Sprite grassWaterSprite_26;
    [SerializeField] Sprite grassWaterSprite_27;
    [SerializeField] Sprite grassWaterSprite_28;
    [SerializeField] Sprite grassWaterSprite_29;
    [SerializeField] Sprite grassWaterSprite_30;
    [SerializeField] Sprite grassWaterSprite_31;
    [SerializeField] Sprite grassWaterSprite_32;
    [SerializeField] Sprite grassWaterSprite_33;
    [SerializeField] Sprite grassWaterSprite_34;
    [SerializeField] Sprite grassWaterSprite_35;
    [SerializeField] Sprite grassWaterSprite_36;
    [SerializeField] Sprite grassWaterSprite_37;
    [SerializeField] Sprite grassWaterSprite_38;
    [SerializeField] Sprite grassWaterSprite_39;
    [SerializeField] Sprite grassWaterSprite_40;
    [SerializeField] Sprite grassWaterSprite_41;
    [SerializeField] Sprite grassWaterSprite_42;
    [SerializeField] Sprite grassWaterSprite_43;
    [SerializeField] Sprite grassWaterSprite_44;
    [SerializeField] Sprite grassWaterSprite_45;
    [SerializeField] Sprite grassWaterSprite_46;
    [SerializeField] Sprite grassWaterSprite_47;

    [SerializeField] Sprite sandWaterSprite_1;
    [SerializeField] Sprite sandWaterSprite_2;
    [SerializeField] Sprite sandWaterSprite_3;
    [SerializeField] Sprite sandWaterSprite_4;
    [SerializeField] Sprite sandWaterSprite_5;
    [SerializeField] Sprite sandWaterSprite_6;
    [SerializeField] Sprite sandWaterSprite_7;
    [SerializeField] Sprite sandWaterSprite_8;
    [SerializeField] Sprite sandWaterSprite_9;
    [SerializeField] Sprite sandWaterSprite_10;
    [SerializeField] Sprite sandWaterSprite_11;
    [SerializeField] Sprite sandWaterSprite_12;
    [SerializeField] Sprite sandWaterSprite_13;
    [SerializeField] Sprite sandWaterSprite_14;
    [SerializeField] Sprite sandWaterSprite_15;
    [SerializeField] Sprite sandWaterSprite_16;
    [SerializeField] Sprite sandWaterSprite_17;
    [SerializeField] Sprite sandWaterSprite_18;
    [SerializeField] Sprite sandWaterSprite_19;
    [SerializeField] Sprite sandWaterSprite_20;
    [SerializeField] Sprite sandWaterSprite_21;
    [SerializeField] Sprite sandWaterSprite_22;
    [SerializeField] Sprite sandWaterSprite_23;
    [SerializeField] Sprite sandWaterSprite_24;
    [SerializeField] Sprite sandWaterSprite_25;
    [SerializeField] Sprite sandWaterSprite_26;
    [SerializeField] Sprite sandWaterSprite_27;
    [SerializeField] Sprite sandWaterSprite_28;
    [SerializeField] Sprite sandWaterSprite_29;
    [SerializeField] Sprite sandWaterSprite_30;
    [SerializeField] Sprite sandWaterSprite_31;
    [SerializeField] Sprite sandWaterSprite_32;
    [SerializeField] Sprite sandWaterSprite_33;
    [SerializeField] Sprite sandWaterSprite_34;
    [SerializeField] Sprite sandWaterSprite_35;
    [SerializeField] Sprite sandWaterSprite_36;
    [SerializeField] Sprite sandWaterSprite_37;
    [SerializeField] Sprite sandWaterSprite_38;
    [SerializeField] Sprite sandWaterSprite_39;
    [SerializeField] Sprite sandWaterSprite_40;
    [SerializeField] Sprite sandWaterSprite_41;
    [SerializeField] Sprite sandWaterSprite_42;
    [SerializeField] Sprite sandWaterSprite_43;
    [SerializeField] Sprite sandWaterSprite_44;
    [SerializeField] Sprite sandWaterSprite_45;
    [SerializeField] Sprite sandWaterSprite_46;
    [SerializeField] Sprite sandWaterSprite_47;

    [SerializeField] Sprite treeSprite_1;
    [SerializeField] Sprite treeSprite_2;
    [SerializeField] Sprite treeSprite_3;
    [SerializeField] Sprite treeSprite_4;
    [SerializeField] Sprite treeSprite_5;
    [SerializeField] Sprite treeSprite_6;
    [SerializeField] Sprite treeSprite_7;
    [SerializeField] Sprite treeSprite_8;
    [SerializeField] Sprite treeSprite_9;
    [SerializeField] Sprite treeSprite_10;

    [SerializeField] Sprite sandRocksSprite;

    [SerializeField] Sprite jungleRocksSprite_1;
    [SerializeField] Sprite jungleRocksSprite_2;
    [SerializeField] Sprite jungleRocksSprite_3;
    [SerializeField] Sprite jungleRocksSprite_4;
    [SerializeField] Sprite jungleRocksSprite_5;

    [SerializeField] Sprite flowersSprite_1;
    [SerializeField] Sprite flowersSprite_2;
    [SerializeField] Sprite flowersSprite_3;
    [SerializeField] Sprite flowersSprite_4;
    [SerializeField] Sprite flowersSprite_5;
    [SerializeField] Sprite flowersSprite_6;
    [SerializeField] Sprite flowersSprite_7;
    [SerializeField] Sprite flowersSprite_8;
    [SerializeField] Sprite flowersSprite_9;
    [SerializeField] Sprite flowersSprite_10;

    [SerializeField] private GameObject bottomSquarePalmTree;
    [SerializeField] private GameObject topSquarePalmTree;
    [SerializeField] private GameObject topSquareForestTree;
    [SerializeField] private GameObject bottomSquareForestTree;

    [SerializeField] Sprite leftGrassRightSandSprite;
    [SerializeField] Sprite leftSandRightGrassSprite;
    [SerializeField] Sprite topSandBottomGrassSprite;
    [SerializeField] Sprite topGrassBottomSandSprite;
    [SerializeField] Sprite topLeftGrassSprite;
    [SerializeField] Sprite topRightGrassSprite;
    [SerializeField] Sprite bottomRightGrassSprite;
    [SerializeField] Sprite bottomLeftGrassSprite;

    [SerializeField] Sprite transitionLTopLeft;
    [SerializeField] Sprite transitionLTopRight;
    [SerializeField] Sprite transitionLBottomRight;
    [SerializeField] Sprite transitionLBottomLeft;


    [Header("AUTOMATIC")]
    //Tile ID 
    public int tileId;

    //adjacentTiles
    public tileScript topAdjacentTile;
    public tileScript leftAdjacentTile;
    public tileScript bottomAdjacentTile;
    public tileScript rightAdjacentTile;

    public tileScript topLeftAdjacentTile;
    public tileScript topRightAdjacentTile;
    public tileScript bottomLeftAdjacentTile;
    public tileScript bottomRightAdjacentTile;

    public int biomeIdOfThisTile;

    public int randomNumToChooseTileVariant;

    [SerializeField] private GameObject gameManagerGameObject;
    [SerializeField] private editModeScript editModeScript;

    //Tile types
    public enum TileType
    {
        EMPTY,
        TOP_LEFT_MAP_CORNER_GRASS,
        TOP_LEFT_MAP_CORNER_SAND,
        LEFT_MAP_CORNER_GRASS,
        LEFT_MAP_CORNER_SAND,
        BOTTOM_LEFT_MAP_CORNER_GRASS,
        BOTTOM_LEFT_MAP_CORNER_SAND,
        BOTTOM_MAP_CORNER_GRASS,
        BOTTOM_MAP_CORNER_SAND,
        BOTTOM_RIGHT_MAP_CORNER_GRASS,
        BOTTOM_RIGHT_MAP_CORNER_SAND,
        RIGHT_MAP_CORNER_GRASS,
        RIGHT_MAP_CORNER_SAND,
        TOP_RIGHT_MAP_CORNER_GRASS,
        TOP_RIGHT_MAP_CORNER_SAND,
        TOP_MAP_CORNER_GRASS,
        TOP_MAP_CORNER_SAND,
        SAND_CORE,
        SAND,
        GRASS_CORE,
        GRASS,
        WATER,
        SAND_WATER,
        TREE,
        SAND_ROCKS,
        CACTUS,
        PALM_TREE,
        JUNGLE_ROCKS,
        FLOWERS,
        LEFT_GRASS_RIGHT_SAND,
        LEFT_SAND_RIGHT_GRASS,
        TOP_GRASS_BOTTOM_SAND,
        TOP_SAND_BOTTOM_GRASS,
        TOP_LEFT_GRASS,
        TOP_RIGHT_GRASS,
        BOTTOM_LEFT_GRASS,
        BOTTOM_RIGHT_GRASS,
        TRANSITION_L_TOP_LEFT,
        TRANSITION_L_TOP_RIGHT,
        TRANSITION_L_BOTTOM_LEFT,
        TRANSITION_L_BOTTOM_RIGHT,
    };

    //Tiletype Initialization
    public TileType tileType;

    private void Start()
    {
        //Choose random variant for each tile
        randomNumToChooseTileVariant = Random.Range(1, 11);

        //Find GAME MANAGER
        gameManagerGameObject = GameObject.Find("--- GAME MANAGER ---");

        //Find editModeScript
        editModeScript = gameManagerGameObject.GetComponent<editModeScript>();
    }

    //Change Tile when selected in the editor mode
    public void ChangeTileSelected()
    {
        switch (editModeScript.selectedTypeOfTile)
        {
            default:
                break;

            case 0:
                tileType = TileType.GRASS;
                biomeIdOfThisTile = 9;
                break;

            case 1:
                tileType = TileType.WATER;
                biomeIdOfThisTile = 9;
                break;

            case 2:
                tileType = TileType.TREE;
                biomeIdOfThisTile = 9;
                break;

            case 3:
                tileType = TileType.JUNGLE_ROCKS;
                biomeIdOfThisTile = 9;
                break;

            case 4:
                tileType = TileType.FLOWERS;
                biomeIdOfThisTile = 9;
                break;

            case 5:
                tileType = TileType.SAND;
                biomeIdOfThisTile = 10;
                break;

            case 6:
                tileType = TileType.SAND_WATER;
                biomeIdOfThisTile = 10;
                break;

            case 7:
                tileType = TileType.SAND_ROCKS;
                biomeIdOfThisTile = 10;
                break;

            case 8:
                tileType = TileType.CACTUS;
                biomeIdOfThisTile = 10;
                break;

            case 9:
                tileType = TileType.PALM_TREE;
                biomeIdOfThisTile = 10;
                break;
        }
    }

    //Change tile when holding paint button in the editor mode
    public void ChangeTileSelectedWhenHolding()
    {
        if (editModeScript.isHoldingPaintButton)
        {
            switch (editModeScript.selectedTypeOfTile)
            {
                default:
                    break;

                case 0:
                    tileType = TileType.GRASS;
                    biomeIdOfThisTile = 9;
                    break;

                case 1:
                    tileType = TileType.WATER;
                    biomeIdOfThisTile = 9;
                    break;

                case 2:
                    tileType = TileType.TREE;
                    biomeIdOfThisTile = 9;
                    break;

                case 3:
                    tileType = TileType.JUNGLE_ROCKS;
                    biomeIdOfThisTile = 9;
                    break;

                case 4:
                    tileType = TileType.FLOWERS;
                    biomeIdOfThisTile = 9;
                    break;

                case 5:
                    tileType = TileType.SAND;
                    biomeIdOfThisTile = 10;
                    break;

                case 6:
                    tileType = TileType.SAND_WATER;
                    biomeIdOfThisTile = 10;
                    break;

                case 7:
                    tileType = TileType.SAND_ROCKS;
                    biomeIdOfThisTile = 10;
                    break;

                case 8:
                    tileType = TileType.CACTUS;
                    biomeIdOfThisTile = 10;
                    break;

                case 9:
                    tileType = TileType.PALM_TREE;
                    biomeIdOfThisTile = 10;
                    break;
            }
        }
    }

    private void Update()
    {
        //Assign the corresponding sprite to each tile 
        switch (tileType)
        {
            //GRASS BORDERS
            case TileType.TOP_LEFT_MAP_CORNER_GRASS:
                if (tileImage.sprite != topLeftMapCornerGrass)
                {
                    tileImage.sprite = topLeftMapCornerGrass;
                }
                break;

            case TileType.LEFT_MAP_CORNER_GRASS:
                if (tileImage.sprite != leftMapCornerGrass)
                {
                    tileImage.sprite = leftMapCornerGrass;
                }
                break;

            case TileType.BOTTOM_LEFT_MAP_CORNER_GRASS:
                if (tileImage.sprite != bottomLeftMapCornerGrass)
                {
                    tileImage.sprite = bottomLeftMapCornerGrass;
                }
                break;

            case TileType.BOTTOM_MAP_CORNER_GRASS:
                if (tileImage.sprite != bottomMapCornerGrass)
                {
                    tileImage.sprite = bottomMapCornerGrass;
                }
                break;

            case TileType.BOTTOM_RIGHT_MAP_CORNER_GRASS:
                if (tileImage.sprite != bottomRightMapCornerGrass)
                {
                    tileImage.sprite = bottomRightMapCornerGrass;
                }
                break;

            case TileType.RIGHT_MAP_CORNER_GRASS:
                if (tileImage.sprite != rightMapCornerGrass)
                {
                    tileImage.sprite = rightMapCornerGrass;
                }
                break;

            case TileType.TOP_RIGHT_MAP_CORNER_GRASS:
                if (tileImage.sprite != topRightMapCornerGrass)
                {
                    tileImage.sprite = topRightMapCornerGrass;
                }
                break;

            case TileType.TOP_MAP_CORNER_GRASS:
                if (tileImage.sprite != topMapCornerGrass)
                {
                    tileImage.sprite = topMapCornerGrass;
                }
                break;


            //SAND BORDERS
            case TileType.TOP_LEFT_MAP_CORNER_SAND:
                if (tileImage.sprite != topLeftMapCornerSand)
                {
                    tileImage.sprite = topLeftMapCornerSand;
                }
                break;

            case TileType.LEFT_MAP_CORNER_SAND:
                if (tileImage.sprite != leftMapCornerSand)
                {
                    tileImage.sprite = leftMapCornerSand;
                }
                break;

            case TileType.BOTTOM_LEFT_MAP_CORNER_SAND:
                if (tileImage.sprite != bottomLeftMapCornerSand)
                {
                    tileImage.sprite = bottomLeftMapCornerSand;
                }
                break;

            case TileType.BOTTOM_MAP_CORNER_SAND:
                if (tileImage.sprite != bottomMapCornerSand)
                {
                    tileImage.sprite = bottomMapCornerSand;
                }
                break;

            case TileType.BOTTOM_RIGHT_MAP_CORNER_SAND:
                if (tileImage.sprite != bottomRightMapCornerSand)
                {
                    tileImage.sprite = bottomRightMapCornerSand;
                }
                break;

            case TileType.RIGHT_MAP_CORNER_SAND:
                if (tileImage.sprite != rightMapCornerSand)
                {
                    tileImage.sprite = rightMapCornerSand;
                }
                break;

            case TileType.TOP_RIGHT_MAP_CORNER_SAND:
                if (tileImage.sprite != topRightMapCornerSand)
                {
                    tileImage.sprite = topRightMapCornerSand;
                }
                break;

            case TileType.TOP_MAP_CORNER_SAND:
                if (tileImage.sprite != topMapCornerSand)
                {
                    tileImage.sprite = topMapCornerSand;
                }
                break;


            case TileType.SAND_CORE:
                if (tileImage.sprite != sandCoreSprite)
                {
                    tileImage.sprite = sandCoreSprite;
                }
                break;

            //SAND
            case TileType.SAND:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != sandSprite_1)
                    {
                        tileImage.sprite = sandSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != sandSprite_2)
                    {
                        tileImage.sprite = sandSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != sandSprite_3)
                    {
                        tileImage.sprite = sandSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != sandSprite_4)
                    {
                        tileImage.sprite = sandSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != sandSprite_5)
                    {
                        tileImage.sprite = sandSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != sandSprite_6)
                    {
                        tileImage.sprite = sandSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != sandSprite_7)
                    {
                        tileImage.sprite = sandSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != sandSprite_8)
                    {
                        tileImage.sprite = sandSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != sandSprite_9)
                    {
                        tileImage.sprite = sandSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != sandSprite_10)
                    {
                        tileImage.sprite = sandSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant > 10)
                {
                    if (tileImage.sprite != sandSprite_10)
                    {
                        tileImage.sprite = sandSprite_10;
                    }
                }

                break;

            //GRASS CORE
            case TileType.GRASS_CORE:
                if (tileImage.sprite != grassCoreSprite)
                {
                    tileImage.sprite = grassCoreSprite;
                }
                break;

            //GRASS
            case TileType.GRASS:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != grassSprite_1)
                    {
                        tileImage.sprite = grassSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != grassSprite_2)
                    {
                        tileImage.sprite = grassSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != grassSprite_3)
                    {
                        tileImage.sprite = grassSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != grassSprite_4)
                    {
                        tileImage.sprite = grassSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != grassSprite_5)
                    {
                        tileImage.sprite = grassSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != grassSprite_6)
                    {
                        tileImage.sprite = grassSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != grassSprite_7)
                    {
                        tileImage.sprite = grassSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != grassSprite_8)
                    {
                        tileImage.sprite = grassSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != grassSprite_9)
                    {
                        tileImage.sprite = grassSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != grassSprite_10)
                    {
                        tileImage.sprite = grassSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant > 10)
                {
                    if (tileImage.sprite != grassSprite_10)
                    {
                        tileImage.sprite = grassSprite_10;
                    }
                }

                break;

            //WATER
            case TileType.WATER:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != grassWaterSprite_1)
                    {
                        tileImage.sprite = grassWaterSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != grassWaterSprite_2)
                    {
                        tileImage.sprite = grassWaterSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != grassWaterSprite_3)
                    {
                        tileImage.sprite = grassWaterSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != grassWaterSprite_4)
                    {
                        tileImage.sprite = grassWaterSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != grassWaterSprite_5)
                    {
                        tileImage.sprite = grassWaterSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != grassWaterSprite_6)
                    {
                        tileImage.sprite = grassWaterSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != grassWaterSprite_7)
                    {
                        tileImage.sprite = grassWaterSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != grassWaterSprite_8)
                    {
                        tileImage.sprite = grassWaterSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != grassWaterSprite_9)
                    {
                        tileImage.sprite = grassWaterSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != grassWaterSprite_10)
                    {
                        tileImage.sprite = grassWaterSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant == 11)
                {
                    if (tileImage.sprite != grassWaterSprite_11)
                    {
                        tileImage.sprite = grassWaterSprite_11;
                    }
                }

                if (randomNumToChooseTileVariant == 12)
                {
                    if (tileImage.sprite != grassWaterSprite_12)
                    {
                        tileImage.sprite = grassWaterSprite_12;
                    }
                }

                if (randomNumToChooseTileVariant == 13)
                {
                    if (tileImage.sprite != grassWaterSprite_13)
                    {
                        tileImage.sprite = grassWaterSprite_13;
                    }
                }

                if (randomNumToChooseTileVariant == 14)
                {
                    if (tileImage.sprite != grassWaterSprite_14)
                    {
                        tileImage.sprite = grassWaterSprite_14;
                    }
                }

                if (randomNumToChooseTileVariant == 15)
                {
                    if (tileImage.sprite != grassWaterSprite_15)
                    {
                        tileImage.sprite = grassWaterSprite_15;
                    }
                }

                if (randomNumToChooseTileVariant == 16)
                {
                    if (tileImage.sprite != grassWaterSprite_16)
                    {
                        tileImage.sprite = grassWaterSprite_16;
                    }
                }

                if (randomNumToChooseTileVariant == 17)
                {
                    if (tileImage.sprite != grassWaterSprite_17)
                    {
                        tileImage.sprite = grassWaterSprite_17;
                    }
                }

                if (randomNumToChooseTileVariant == 18)
                {
                    if (tileImage.sprite != grassWaterSprite_18)
                    {
                        tileImage.sprite = grassWaterSprite_18;
                    }
                }

                if (randomNumToChooseTileVariant == 19)
                {
                    if (tileImage.sprite != grassWaterSprite_19)
                    {
                        tileImage.sprite = grassWaterSprite_19;
                    }
                }

                if (randomNumToChooseTileVariant == 20)
                {
                    if (tileImage.sprite != grassWaterSprite_20)
                    {
                        tileImage.sprite = grassWaterSprite_20;
                    }
                }

                if (randomNumToChooseTileVariant == 21)
                {
                    if (tileImage.sprite != fullWaterSprite)
                    {
                        tileImage.sprite = fullWaterSprite;
                    }
                }

                if (randomNumToChooseTileVariant == 22)
                {
                    if (tileImage.sprite != grassWaterSprite_22)
                    {
                        tileImage.sprite = grassWaterSprite_22;
                    }
                }

                if (randomNumToChooseTileVariant == 23)
                {
                    if (tileImage.sprite != grassWaterSprite_23)
                    {
                        tileImage.sprite = grassWaterSprite_23;
                    }
                }

                if (randomNumToChooseTileVariant == 24)
                {
                    if (tileImage.sprite != grassWaterSprite_24)
                    {
                        tileImage.sprite = grassWaterSprite_24;
                    }
                }

                if (randomNumToChooseTileVariant == 25)
                {
                    if (tileImage.sprite != grassWaterSprite_25)
                    {
                        tileImage.sprite = grassWaterSprite_25;
                    }
                }

                if (randomNumToChooseTileVariant == 26)
                {
                    if (tileImage.sprite != grassWaterSprite_26)
                    {
                        tileImage.sprite = grassWaterSprite_26;
                    }
                }

                if (randomNumToChooseTileVariant == 27)
                {
                    if (tileImage.sprite != grassWaterSprite_27)
                    {
                        tileImage.sprite = grassWaterSprite_27;
                    }
                }

                if (randomNumToChooseTileVariant == 28)
                {
                    if (tileImage.sprite != grassWaterSprite_28)
                    {
                        tileImage.sprite = grassWaterSprite_28;
                    }
                }


                if (randomNumToChooseTileVariant == 29)
                {
                    if (tileImage.sprite != grassWaterSprite_29)
                    {
                        tileImage.sprite = grassWaterSprite_29;
                    }
                }

                if (randomNumToChooseTileVariant == 30)
                {
                    if (tileImage.sprite != grassWaterSprite_30)
                    {
                        tileImage.sprite = grassWaterSprite_30;
                    }
                }

                if (randomNumToChooseTileVariant == 31)
                {
                    if (tileImage.sprite != grassWaterSprite_31)
                    {
                        tileImage.sprite = grassWaterSprite_31;
                    }
                }

                if (randomNumToChooseTileVariant == 32)
                {
                    if (tileImage.sprite != grassWaterSprite_32)
                    {
                        tileImage.sprite = grassWaterSprite_32;
                    }
                }

                if (randomNumToChooseTileVariant == 33)
                {
                    if (tileImage.sprite != grassWaterSprite_33)
                    {
                        tileImage.sprite = grassWaterSprite_33;
                    }
                }

                if (randomNumToChooseTileVariant == 34)
                {
                    if (tileImage.sprite != grassWaterSprite_34)
                    {
                        tileImage.sprite = grassWaterSprite_34;
                    }
                }

                if (randomNumToChooseTileVariant == 35)
                {
                    if (tileImage.sprite != grassWaterSprite_35)
                    {
                        tileImage.sprite = grassWaterSprite_35;
                    }
                }

                if (randomNumToChooseTileVariant == 36)
                {
                    if (tileImage.sprite != grassWaterSprite_36)
                    {
                        tileImage.sprite = grassWaterSprite_36;
                    }
                }

                if (randomNumToChooseTileVariant == 37)
                {
                    if (tileImage.sprite != grassWaterSprite_37)
                    {
                        tileImage.sprite = grassWaterSprite_37;
                    }
                }

                if (randomNumToChooseTileVariant == 38)
                {
                    if (tileImage.sprite != grassWaterSprite_38)
                    {
                        tileImage.sprite = grassWaterSprite_38;
                    }
                }

                if (randomNumToChooseTileVariant == 39)
                {
                    if (tileImage.sprite != grassWaterSprite_39)
                    {
                        tileImage.sprite = grassWaterSprite_39;
                    }
                }

                if (randomNumToChooseTileVariant == 40)
                {
                    if (tileImage.sprite != grassWaterSprite_40)
                    {
                        tileImage.sprite = grassWaterSprite_40;
                    }
                }

                if (randomNumToChooseTileVariant == 41)
                {
                    if (tileImage.sprite != grassWaterSprite_41)
                    {
                        tileImage.sprite = grassWaterSprite_41;
                    }
                }

                if (randomNumToChooseTileVariant == 42)
                {
                    if (tileImage.sprite != grassWaterSprite_42)
                    {
                        tileImage.sprite = grassWaterSprite_42;
                    }
                }

                if (randomNumToChooseTileVariant == 43)
                {
                    if (tileImage.sprite != grassWaterSprite_43)
                    {
                        tileImage.sprite = grassWaterSprite_43;
                    }
                }

                if (randomNumToChooseTileVariant == 44)
                {
                    if (tileImage.sprite != grassWaterSprite_44)
                    {
                        tileImage.sprite = grassWaterSprite_44;
                    }
                }

                if (randomNumToChooseTileVariant == 45)
                {
                    if (tileImage.sprite != grassWaterSprite_45)
                    {
                        tileImage.sprite = grassWaterSprite_45;
                    }
                }

                if (randomNumToChooseTileVariant == 46)
                {
                    if (tileImage.sprite != grassWaterSprite_46)
                    {
                        tileImage.sprite = grassWaterSprite_46;
                    }
                }

                if (randomNumToChooseTileVariant == 47)
                {
                    if (tileImage.sprite != grassWaterSprite_47)
                    {
                        tileImage.sprite = grassWaterSprite_47;
                    }
                }

                break;

            //SAND WATER
            case TileType.SAND_WATER:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);
                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != sandWaterSprite_1)
                    {
                        tileImage.sprite = sandWaterSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != sandWaterSprite_2)
                    {
                        tileImage.sprite = sandWaterSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != sandWaterSprite_3)
                    {
                        tileImage.sprite = sandWaterSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != sandWaterSprite_4)
                    {
                        tileImage.sprite = sandWaterSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != sandWaterSprite_5)
                    {
                        tileImage.sprite = sandWaterSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != sandWaterSprite_6)
                    {
                        tileImage.sprite = sandWaterSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != sandWaterSprite_7)
                    {
                        tileImage.sprite = sandWaterSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != sandWaterSprite_8)
                    {
                        tileImage.sprite = sandWaterSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != sandWaterSprite_9)
                    {
                        tileImage.sprite = sandWaterSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != sandWaterSprite_10)
                    {
                        tileImage.sprite = sandWaterSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant == 11)
                {
                    if (tileImage.sprite != sandWaterSprite_11)
                    {
                        tileImage.sprite = sandWaterSprite_11;
                    }
                }

                if (randomNumToChooseTileVariant == 12)
                {
                    if (tileImage.sprite != sandWaterSprite_12)
                    {
                        tileImage.sprite = sandWaterSprite_12;
                    }
                }

                if (randomNumToChooseTileVariant == 13)
                {
                    if (tileImage.sprite != sandWaterSprite_13)
                    {
                        tileImage.sprite = sandWaterSprite_13;
                    }
                }

                if (randomNumToChooseTileVariant == 14)
                {
                    if (tileImage.sprite != sandWaterSprite_14)
                    {
                        tileImage.sprite = sandWaterSprite_14;
                    }
                }

                if (randomNumToChooseTileVariant == 15)
                {
                    if (tileImage.sprite != sandWaterSprite_15)
                    {
                        tileImage.sprite = sandWaterSprite_15;
                    }
                }

                if (randomNumToChooseTileVariant == 16)
                {
                    if (tileImage.sprite != sandWaterSprite_16)
                    {
                        tileImage.sprite = sandWaterSprite_16;
                    }
                }

                if (randomNumToChooseTileVariant == 17)
                {
                    if (tileImage.sprite != sandWaterSprite_17)
                    {
                        tileImage.sprite = sandWaterSprite_17;
                    }
                }

                if (randomNumToChooseTileVariant == 18)
                {
                    if (tileImage.sprite != sandWaterSprite_18)
                    {
                        tileImage.sprite = sandWaterSprite_18;
                    }
                }

                if (randomNumToChooseTileVariant == 19)
                {
                    if (tileImage.sprite != sandWaterSprite_19)
                    {
                        tileImage.sprite = sandWaterSprite_19;
                    }
                }

                if (randomNumToChooseTileVariant == 20)
                {
                    if (tileImage.sprite != sandWaterSprite_20)
                    {
                        tileImage.sprite = sandWaterSprite_20;
                    }
                }

                if (randomNumToChooseTileVariant == 21)
                {
                    if (tileImage.sprite != sandWaterSprite_21)
                    {
                        tileImage.sprite = sandWaterSprite_21;
                    }
                }

                if (randomNumToChooseTileVariant == 22)
                {
                    if (tileImage.sprite != sandWaterSprite_22)
                    {
                        tileImage.sprite = sandWaterSprite_22;
                    }
                }


                if (randomNumToChooseTileVariant == 23)
                {
                    if (tileImage.sprite != sandWaterSprite_23)
                    {
                        tileImage.sprite = sandWaterSprite_23;
                    }
                }


                if (randomNumToChooseTileVariant == 24)
                {
                    if (tileImage.sprite != sandWaterSprite_24)
                    {
                        tileImage.sprite = sandWaterSprite_24;
                    }
                }


                if (randomNumToChooseTileVariant == 25)
                {
                    if (tileImage.sprite != sandWaterSprite_25)
                    {
                        tileImage.sprite = sandWaterSprite_25;
                    }
                }


                if (randomNumToChooseTileVariant == 26)
                {
                    if (tileImage.sprite != sandWaterSprite_26)
                    {
                        tileImage.sprite = sandWaterSprite_26;
                    }
                }


                if (randomNumToChooseTileVariant == 27)
                {
                    if (tileImage.sprite != sandWaterSprite_27)
                    {
                        tileImage.sprite = sandWaterSprite_27;
                    }
                }


                if (randomNumToChooseTileVariant == 28)
                {
                    if (tileImage.sprite != sandWaterSprite_28)
                    {
                        tileImage.sprite = sandWaterSprite_28;
                    }
                }


                if (randomNumToChooseTileVariant == 29)
                {
                    if (tileImage.sprite != sandWaterSprite_29)
                    {
                        tileImage.sprite = sandWaterSprite_29;
                    }
                }


                if (randomNumToChooseTileVariant == 30)
                {
                    if (tileImage.sprite != sandWaterSprite_30)
                    {
                        tileImage.sprite = sandWaterSprite_30;
                    }
                }


                if (randomNumToChooseTileVariant == 31)
                {
                    if (tileImage.sprite != sandWaterSprite_31)
                    {
                        tileImage.sprite = sandWaterSprite_31;
                    }
                }


                if (randomNumToChooseTileVariant == 32)
                {
                    if (tileImage.sprite != sandWaterSprite_32)
                    {
                        tileImage.sprite = sandWaterSprite_32;
                    }
                }


                if (randomNumToChooseTileVariant == 33)
                {
                    if (tileImage.sprite != sandWaterSprite_33)
                    {
                        tileImage.sprite = sandWaterSprite_33;
                    }
                }

                if (randomNumToChooseTileVariant == 34)
                {
                    if (tileImage.sprite != sandWaterSprite_34)
                    {
                        tileImage.sprite = sandWaterSprite_34;
                    }
                }

                if (randomNumToChooseTileVariant == 35)
                {
                    if (tileImage.sprite != sandWaterSprite_35)
                    {
                        tileImage.sprite = sandWaterSprite_35;
                    }
                }

                if (randomNumToChooseTileVariant == 36)
                {
                    if (tileImage.sprite != sandWaterSprite_36)
                    {
                        tileImage.sprite = sandWaterSprite_36;
                    }
                }

                if (randomNumToChooseTileVariant == 37)
                {
                    if (tileImage.sprite != sandWaterSprite_37)
                    {
                        tileImage.sprite = sandWaterSprite_37;
                    }
                }

                if (randomNumToChooseTileVariant == 38)
                {
                    if (tileImage.sprite != sandWaterSprite_38)
                    {
                        tileImage.sprite = sandWaterSprite_38;
                    }
                }

                if (randomNumToChooseTileVariant == 39)
                {
                    if (tileImage.sprite != sandWaterSprite_39)
                    {
                        tileImage.sprite = sandWaterSprite_39;
                    }
                }

                if (randomNumToChooseTileVariant == 40)
                {
                    if (tileImage.sprite != sandWaterSprite_40)
                    {
                        tileImage.sprite = sandWaterSprite_40;
                    }
                }

                if (randomNumToChooseTileVariant == 41)
                {
                    if (tileImage.sprite != sandWaterSprite_41)
                    {
                        tileImage.sprite = sandWaterSprite_41;
                    }
                }

                if (randomNumToChooseTileVariant == 42)
                {
                    if (tileImage.sprite != sandWaterSprite_42)
                    {
                        tileImage.sprite = sandWaterSprite_42;
                    }
                }

                if (randomNumToChooseTileVariant == 43)
                {
                    if (tileImage.sprite != sandWaterSprite_43)
                    {
                        tileImage.sprite = sandWaterSprite_43;
                    }
                }

                if (randomNumToChooseTileVariant == 44)
                {
                    if (tileImage.sprite != sandWaterSprite_44)
                    {
                        tileImage.sprite = sandWaterSprite_44;
                    }
                }

                if (randomNumToChooseTileVariant == 45)
                {
                    if (tileImage.sprite != sandWaterSprite_45)
                    {
                        tileImage.sprite = sandWaterSprite_45;
                    }
                }

                if (randomNumToChooseTileVariant == 46)
                {
                    if (tileImage.sprite != sandWaterSprite_46)
                    {
                        tileImage.sprite = sandWaterSprite_46;
                    }
                }

                if (randomNumToChooseTileVariant == 47)
                {
                    if (tileImage.sprite != sandWaterSprite_47)
                    {
                        tileImage.sprite = sandWaterSprite_47;
                    }
                }

                break;

            //TREE
            case TileType.TREE:

                bottomSquareForestTree.SetActive(true);
                topSquareForestTree.SetActive(true);
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);


                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != treeSprite_1)
                    {
                        tileImage.sprite = treeSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != treeSprite_2)
                    {
                        tileImage.sprite = treeSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != treeSprite_3)
                    {
                        tileImage.sprite = treeSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != treeSprite_4)
                    {
                        tileImage.sprite = treeSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != treeSprite_5)
                    {
                        tileImage.sprite = treeSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != treeSprite_6)
                    {
                        tileImage.sprite = treeSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != treeSprite_7)
                    {
                        tileImage.sprite = treeSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != treeSprite_8)
                    {
                        tileImage.sprite = treeSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != treeSprite_9)
                    {
                        tileImage.sprite = treeSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != treeSprite_10)
                    {
                        tileImage.sprite = treeSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant > 10)
                {
                    if (tileImage.sprite != treeSprite_10)
                    {
                        tileImage.sprite = treeSprite_10;
                    }
                }
                break;

            //SAND ROCKS
            case TileType.SAND_ROCKS:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (tileImage.sprite != sandRocksSprite)
                {
                    tileImage.sprite = sandRocksSprite;
                }
                break;

            //CACTUS
            case TileType.CACTUS:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != cactusSprite_1)
                    {
                        tileImage.sprite = cactusSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != cactusSprite_2)
                    {
                        tileImage.sprite = cactusSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != cactusSprite_3)
                    {
                        tileImage.sprite = cactusSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != cactusSprite_4)
                    {
                        tileImage.sprite = cactusSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != cactusSprite_5)
                    {
                        tileImage.sprite = cactusSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != cactusSprite_6)
                    {
                        tileImage.sprite = cactusSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != cactusSprite_7)
                    {
                        tileImage.sprite = cactusSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != cactusSprite_8)
                    {
                        tileImage.sprite = cactusSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != cactusSprite_9)
                    {
                        tileImage.sprite = cactusSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != cactusSprite_10)
                    {
                        tileImage.sprite = cactusSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant > 10)
                {
                    if (tileImage.sprite != cactusSprite_10)
                    {
                        tileImage.sprite = cactusSprite_10;
                    }
                }

                break;
            
            //PALM TREE
            case TileType.PALM_TREE:

                bottomSquarePalmTree.SetActive(true);
                topSquarePalmTree.SetActive(true);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != palmTreeSprite_1)
                    {
                        tileImage.sprite = palmTreeSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != palmTreeSprite_2)
                    {
                        tileImage.sprite = palmTreeSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != palmTreeSprite_3)
                    {
                        tileImage.sprite = palmTreeSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != palmTreeSprite_4)
                    {
                        tileImage.sprite = palmTreeSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != palmTreeSprite_5)
                    {
                        tileImage.sprite = palmTreeSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != palmTreeSprite_6)
                    {
                        tileImage.sprite = palmTreeSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != palmTreeSprite_7)
                    {
                        tileImage.sprite = palmTreeSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != palmTreeSprite_8)
                    {
                        tileImage.sprite = palmTreeSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != palmTreeSprite_9)
                    {
                        tileImage.sprite = palmTreeSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != palmTreeSprite_10)
                    {
                        tileImage.sprite = palmTreeSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant > 10)
                {
                    if (tileImage.sprite != palmTreeSprite_10)
                    {
                        tileImage.sprite = palmTreeSprite_10;
                    }
                }

                break;

            //JUNGLE ROCKS
            case TileType.JUNGLE_ROCKS:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != jungleRocksSprite_1)
                    {
                        tileImage.sprite = jungleRocksSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != jungleRocksSprite_2)
                    {
                        tileImage.sprite = jungleRocksSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != jungleRocksSprite_3)
                    {
                        tileImage.sprite = jungleRocksSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != jungleRocksSprite_4)
                    {
                        tileImage.sprite = jungleRocksSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != jungleRocksSprite_5)
                    {
                        tileImage.sprite = jungleRocksSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant > 5)
                {
                    if (tileImage.sprite != jungleRocksSprite_5)
                    {
                        tileImage.sprite = jungleRocksSprite_5;
                    }
                }
                break;

            //FLOWERS
            case TileType.FLOWERS:
                bottomSquarePalmTree.SetActive(false);
                topSquarePalmTree.SetActive(false);
                bottomSquareForestTree.SetActive(false);
                topSquareForestTree.SetActive(false);

                if (randomNumToChooseTileVariant == 1)
                {
                    if (tileImage.sprite != flowersSprite_1)
                    {
                        tileImage.sprite = flowersSprite_1;
                    }
                }

                if (randomNumToChooseTileVariant == 2)
                {
                    if (tileImage.sprite != flowersSprite_2)
                    {
                        tileImage.sprite = flowersSprite_2;
                    }
                }

                if (randomNumToChooseTileVariant == 3)
                {
                    if (tileImage.sprite != flowersSprite_3)
                    {
                        tileImage.sprite = flowersSprite_3;
                    }
                }

                if (randomNumToChooseTileVariant == 4)
                {
                    if (tileImage.sprite != flowersSprite_4)
                    {
                        tileImage.sprite = flowersSprite_4;
                    }
                }

                if (randomNumToChooseTileVariant == 5)
                {
                    if (tileImage.sprite != flowersSprite_5)
                    {
                        tileImage.sprite = flowersSprite_5;
                    }
                }

                if (randomNumToChooseTileVariant == 6)
                {
                    if (tileImage.sprite != flowersSprite_6)
                    {
                        tileImage.sprite = flowersSprite_6;
                    }
                }

                if (randomNumToChooseTileVariant == 7)
                {
                    if (tileImage.sprite != flowersSprite_7)
                    {
                        tileImage.sprite = flowersSprite_7;
                    }
                }

                if (randomNumToChooseTileVariant == 8)
                {
                    if (tileImage.sprite != flowersSprite_8)
                    {
                        tileImage.sprite = flowersSprite_8;
                    }
                }

                if (randomNumToChooseTileVariant == 9)
                {
                    if (tileImage.sprite != flowersSprite_9)
                    {
                        tileImage.sprite = flowersSprite_9;
                    }
                }

                if (randomNumToChooseTileVariant == 10)
                {
                    if (tileImage.sprite != flowersSprite_10)
                    {
                        tileImage.sprite = flowersSprite_10;
                    }
                }

                if (randomNumToChooseTileVariant > 10)
                {
                    if (tileImage.sprite != flowersSprite_10)
                    {
                        tileImage.sprite = flowersSprite_10;
                    }
                }

                break;

            //TRANSITIONS
            case TileType.LEFT_GRASS_RIGHT_SAND:


                if (tileImage.sprite != leftGrassRightSandSprite)
                {
                    tileImage.sprite = leftGrassRightSandSprite;
                }
                break;

            case TileType.LEFT_SAND_RIGHT_GRASS:
                if (tileImage.sprite != leftSandRightGrassSprite)
                {
                    tileImage.sprite = leftSandRightGrassSprite;
                }
                break;

            case TileType.TOP_SAND_BOTTOM_GRASS:
                if (tileImage.sprite != topSandBottomGrassSprite)
                {
                    tileImage.sprite = topSandBottomGrassSprite;
                }
                break;

            case TileType.TOP_GRASS_BOTTOM_SAND:
                if (tileImage.sprite != topGrassBottomSandSprite)
                {
                    tileImage.sprite = topGrassBottomSandSprite;
                }
                break;

            case TileType.TOP_LEFT_GRASS:
                if (tileImage.sprite != topLeftGrassSprite)
                {
                    tileImage.sprite = topLeftGrassSprite;
                }
                break;

            case TileType.TOP_RIGHT_GRASS:
                if (tileImage.sprite != topRightGrassSprite)
                {
                    tileImage.sprite = topRightGrassSprite;
                }
                break;

            case TileType.BOTTOM_RIGHT_GRASS:
                if (tileImage.sprite != bottomRightGrassSprite)
                {
                    tileImage.sprite = bottomRightGrassSprite;
                }
                break;

            case TileType.BOTTOM_LEFT_GRASS:
                if (tileImage.sprite != bottomLeftGrassSprite)
                {
                    tileImage.sprite = bottomLeftGrassSprite;
                }
                break;

            case TileType.TRANSITION_L_BOTTOM_LEFT:
                if (tileImage.sprite != transitionLBottomLeft)
                {
                    tileImage.sprite = transitionLBottomLeft;
                }
                break;

            case TileType.TRANSITION_L_BOTTOM_RIGHT:
                if (tileImage.sprite != transitionLBottomRight)
                {
                    tileImage.sprite = transitionLBottomRight;
                }
                break;


            case TileType.TRANSITION_L_TOP_RIGHT:
                if (tileImage.sprite != transitionLTopRight)
                {
                    tileImage.sprite = transitionLTopRight;
                }
                break;

            case TileType.TRANSITION_L_TOP_LEFT:
                if (tileImage.sprite != transitionLTopLeft)
                {
                    tileImage.sprite = transitionLTopLeft;
                }
                break;

            //EMPTY
            case TileType.EMPTY:
                if (tileImage.sprite != null)
                {
                    tileImage.sprite = null;
                }
                break;

            default:
                break;
        }
    }
}

}
