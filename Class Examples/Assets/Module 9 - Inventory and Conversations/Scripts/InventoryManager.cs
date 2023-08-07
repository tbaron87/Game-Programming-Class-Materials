using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private float currentWeight = 0.0f;
    private float totalWeightCapacity = 100.0f;
    private int goldHeld = 0;
    private List<Item> items = new List<Item>();

    private const string ADDED_ITEM_SUCCESS = "Added";

    public string addItemToInventory(Item item)
    {
        float weight = item.getWeight();
        if(weight + currentWeight < totalWeightCapacity)
        {
            currentWeight += weight;
            items.Add(item);
            return ADDED_ITEM_SUCCESS;
        }
        else
        {
            return "This weighs too much for me to carry!";
        }
    }

    public List<Item> getItems()
    {
        return items;
    }

    public void deleteItem(Item item)
    {
        items.Remove(item);
    }

    public void dummy()
    {
        Debug.Log(goldHeld);
    }
}
