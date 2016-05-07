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
        inventory.Add(database.items[1]);
        print(InventoryContains(1));
        RemoveItem(1);
        print(InventoryContains(1));
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
            for (int y = 0; y < slotsY; y++)
            {
                GUI.Box(new Rect(x *  50, y * 50, 40, 40), y.ToString());
            }
        }

    }

    void RemoveItem(int id)
    {
        for(int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemID ==id)
            {
                inventory[i] = new Items();
                break;
            }
        }
    }

    bool InventoryContains(int id)
    {
        foreach (Items item in inventory)
        {
            if (item.itemID == id) return true;
        }
        return false;
    }
}
