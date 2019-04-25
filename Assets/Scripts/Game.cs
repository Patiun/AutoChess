using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game _instance;

    public GameObject prefab_unit;

    public GameObject selectedUnit;
    public GameObject selectedTile;
    public GameObject selectedSlot;

    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectTile(GameObject tileObj)
    {
        selectedTile = tileObj;
        if (selectedUnit)
        {
            print("HAS UNIT");
            Tile tile = tileObj.GetComponent<Tile>();
            if (tile.playerSide && tile.empty)
            {
                print("NOT EMPTY");
                MoveUnitToTile(selectedUnit, selectedTile);
            }
        }
    }

    public void SelectSlot(GameObject slotObj)
    {
        selectedSlot = slotObj;
        if (selectedUnit)
        {
            print("HAS UNIT");
            BenchSlot slot = slotObj.GetComponent<BenchSlot>();
            if (slot.empty)
            {
                print("NOT EMPTY");
                MoveUnitToSlot(selectedUnit, selectedSlot);
            }
        }
    }

    public void SelectUnit(GameObject unit)
    {
        DeselectAll();
        selectedUnit = unit;
    }


    public void MoveUnitToTile(GameObject unitObj, GameObject tileObj)
    {
        Unit unit = unitObj.GetComponent<Unit>();
        unit.MoveToTile(tileObj);
        DeselectAll();
        print("UNIT MOVED TO TILE");
    }

    public void MoveUnitToSlot(GameObject unitObj, GameObject slotObj)
    {
        Unit unit = unitObj.GetComponent<Unit>();
        unit.MoveToSlot(slotObj);
        DeselectAll();
        print("UNIT MOVED TO BENCH");
    }

    public void DeselectAll()
    {
        selectedTile = null;
        selectedUnit = null;
        selectedSlot = null;
    }

}
