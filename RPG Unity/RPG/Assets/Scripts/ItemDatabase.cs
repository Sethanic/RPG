using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
    public List<Items> items = new List<Items>();

    void Awake()
    {
                        //Name    id  description                                     damage    sharpness     armour   type
        items.Add(new Items("Shirt", 0, "A common shirt, worn by prisoners and peasants.", 0, 0, 2, Items.ItemType.Armour));
        items.Add(new Items("Glove", 1, "A glove of leather. Makes you sweat easily.", 0, 0, 1, Items.ItemType.Armour));
    }
}
