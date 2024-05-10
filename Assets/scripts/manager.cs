using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // Added this using directive

public class manager : MonoBehaviour
{
    public static manager Instance;
    public List<item> items = new List<item>();
    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ADD(item newItem)
    {
        items.Add(newItem);
    }

    public void RemoveItem(item itemToRemove)
    {
        items.Remove(itemToRemove);
    }

    public void ListItem()
    {
        foreach (item item in items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("itemName").GetComponent<TextMeshProUGUI>();
            var itemImage = obj.transform.Find("itemImage").GetComponent<Image>();

            itemName.text = item.itemName;
            itemImage.sprite = item.icon; // Changed from ItemIcon.text = item.icon; to ItemIcon.sprite = item.icon;
        }
    }
}
