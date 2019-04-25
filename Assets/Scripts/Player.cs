using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Bench bench;
    public int gold;
    public bool shopOpen;
    public GameObject shop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shopOpen = !shopOpen;
            shop.SetActive(shopOpen);
        }
    }
}
