using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
    public List<Items> items = new List<Items>();

    void Awake()
    {
                        //Name    id  description                                     damage    sharpness     armour   type
        items.Add(new Items("Nothing", 0, "Nothing", 0, 0, 0, Items.ItemType.Consumable)); //Don't use this

        items.Add(new Items("Shirt", 1, "A common shirt, worn by prisoners and peasants.", 0, 0, 2, Items.ItemType.Armour));
        items.Add(new Items("Glove", 2, "A glove of leather. Makes you sweat easily.", 0, 0, 1, Items.ItemType.Armour));
    }
}
