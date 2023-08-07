using System.Collections.Generic;
using UnityEngine;

public class InventoryHUDManager : MonoBehaviour
{
    [SerializeField]
    private GameObject inventoryRoot;
    [SerializeField]
    private List<GameObject> inventoryList;
    private InventoryManager inventoryManager;

    public void Start()
    {
        inventoryManager = inventoryRoot.GetComponent<InventoryManager>();
    }

    public void showHUD()
    {
        List<Item> items = inventoryManager.getItems();
        int index = 0;
        foreach(Item item in items)
        {
            inventoryList[index++].GetComponent<InventorySpace>().setItem(item);
        }
    }

    public void deleteItem(Item item)
    {
        inventoryManager.deleteItem(item);
        showHUD();
    }

}
