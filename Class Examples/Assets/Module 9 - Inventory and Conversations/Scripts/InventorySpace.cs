using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySpace : MonoBehaviour
{
    [SerializeField]
    private GameObject inventoryHUDManager;
    [SerializeField]
    private GameObject textObject;
    private Item item;
    private TextMeshProUGUI text;
    private Image image;
    public void Start()
    {
        image = GetComponent<Image>();
        text = textObject.GetComponent<TextMeshProUGUI>();
        image.sprite = null;
        textObject.SetActive(false);
    }

    public void setItem(Item itemToSet)
    {
        item = itemToSet;
        image.sprite = item.GetSprite();
        textObject.SetActive(true);
        text.SetText(item.getName());
    }

    public void clearItem()
    {
        image.sprite = null;
        textObject.SetActive(false);
        inventoryHUDManager.GetComponent<InventoryHUDManager>().deleteItem(item);
    }
}
