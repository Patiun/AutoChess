using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool playerSide;
    public bool empty = true;
    public GameObject unit;

    private GameObject unitSlot;
    private Game game;

    // Start is called before the first frame update
    void Start()
    {
        unitSlot = transform.GetChild(0).gameObject;
        game = Game._instance;
        empty = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("Clicked on "+gameObject.name);
        if (!game) { game = Game._instance; }
        game.SelectTile(gameObject);
    }

    public Vector3 GetUnitSlotPosition()
    {
        return unitSlot.transform.position;
    }

    public void PlaceUnit(GameObject unitObj)
    {
        empty = false;
        unit = unitObj;
        unitObj.transform.parent = unitSlot.transform;
    }

    public void RemoveUnit(GameObject unitObj)
    {
        if (unitObj == unit)
        {
            empty = true;
            unit = null;
        } else
        {
            print("INCORRECT UNIT TO REMOVE");
        }
    }
}
