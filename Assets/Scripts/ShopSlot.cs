using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSlot : MonoBehaviour
{
    public Player player;
    public GameObject unit;
    public GameObject unitData;

    public bool purchased;
    public GameObject unitImage, unitName, unitCost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Press()
    {
        if (!purchased)
        {
            GameObject slot = player.bench.GetFirstOpenSlot();
            if (slot)
            {
                purchased = true;
                unitImage.SetActive(false);
                unitName.SetActive(false);
                unitCost.SetActive(false);
                GameObject newUnit = Instantiate(unit);
                Unit unitFunctions = newUnit.GetComponent<Unit>();
                unitFunctions.MoveToSlot(slot);
            } else
            {
                print("NO OPEN SLOTS");
            }
        }
    }
}
