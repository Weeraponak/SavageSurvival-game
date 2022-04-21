using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="New Item",menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool showIntenvory = true;

    //คำสั่งกรณีใช้ Item
    public void Use()
    {
        if (name.Equals("Axe"))
        {
            PlayerMovement.instance.ShowAxe();
            RemoveItemFromInventory();
        }
        if (name.Equals("Chicken"))
        {
            FoodController.instance.Chicken();
            RemoveItemFromInventory();
        }
        if (name.Equals("Mushroom"))
        {
            FoodController.instance.Mushroom();
            RemoveItemFromInventory();
        }
        if (name.Equals("Banana"))
        {
            FoodController.instance.Banana();
            RemoveItemFromInventory();
        }
        if (name.Equals("Watermelon"))
        {
            FoodController.instance.Banana();
            RemoveItemFromInventory();
        }
        if (name.Equals("Cherry"))
        {
            FoodController.instance.Mushroom();
            RemoveItemFromInventory();
        }
        if (name.Equals("Olive"))
        {
            FoodController.instance.Mushroom();
            RemoveItemFromInventory();
        }
    }
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
