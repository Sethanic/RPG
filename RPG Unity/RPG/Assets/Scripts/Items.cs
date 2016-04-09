using UnityEngine;
using System.Collections;

[System.Serializable]
public class Items {
    
	public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public int itemDamage;
    public int itemArmour;
    public int itemSharpness;
    public ItemType itemType;

    public enum ItemType
    {
        Weapon,
        Armour,
        Consumable,
        Quest           //Essential for Quest
    }

    public Items(string name, int id, string desc, int damage, int sharpness, int armour, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemIcon = Resources.Load<Texture2D>("tem Icons/" + id);
        itemDamage = damage;
        itemSharpness = sharpness;
        itemArmour = armour;
    }

    public Items()
    {

    }
}
