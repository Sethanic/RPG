using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

    public int slotsX, slotsY;
    public GUISkin skin;

    public List<Items> slots = new List<Items>();
    public List<Items> inventory = new List<Items>();
    private bool showInventory;
    private ItemDatabase database;

	void Start () 
    {
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new Items());
        }
        database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
        inventory.Add(database.items[0]);
        inventory.Add(database.items[1]);
	}

    void Update ()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            showInventory = !showInventory;
        }
    }
	
	void OnGUI () 
    {
        if (showInventory)
        {
            DrawInventory();
        }
	}

    void DrawInventory ()
    {
        for (int x  = 0; x < slotsX; x++)
        {
            for (int y = 0; x < slotsY; y++)
            {
                GUI.Box(new Rect(x *  20, y * 20, 20, 20), y.ToString());
            }
        }

    }
}
