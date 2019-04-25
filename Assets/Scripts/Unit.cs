using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    private Game game;

    public bool onField;
    public Tile currentTile;
    public BenchSlot currentSlot;

    // Start is called before the first frame update
    void Start()
    {
        game = Game._instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("Clicked on " + gameObject.name);
        if (!game) { game = Game._instance; }
        game.SelectUnit(gameObject);
    }

    public void MoveToTile(GameObject tileObj)
    {
        if (currentTile)
        {
            currentTile.RemoveUnit(gameObject);
        }
        if (currentSlot)
        {
            currentSlot.RemoveUnit(gameObject);
        }
        Tile tile = tileObj.GetComponent<Tile>();
        currentTile = tile;
        transform.position = tile.GetUnitSlotPosition();
        tile.PlaceUnit(gameObject);
        onField = true;
    }

    public void MoveToSlot(GameObject slotObj)
    {
        if (currentTile)
        {
            currentTile.RemoveUnit(gameObject);
        }
        if (currentSlot)
        {
            currentSlot.RemoveUnit(gameObject);
        }
        BenchSlot slot = slotObj.GetComponent<BenchSlot>();
        currentSlot = slot;
        transform.position = slot.GetUnitSlotPosition();
        slot.PlaceUnit(gameObject);
        onField = false;
    }
}
