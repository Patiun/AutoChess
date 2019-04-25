using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bench : MonoBehaviour
{

    public List<GameObject> slots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetFirstOpenSlot()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            GameObject slot = slots[i];
            BenchSlot benchSlot = slot.GetComponent<BenchSlot>();
            if (benchSlot.empty)
            {
                return slot;
            }
        }
        return null;
    }
}
