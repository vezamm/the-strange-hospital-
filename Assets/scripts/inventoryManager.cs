using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class inventoryManager : MonoBehaviour
{
    public static inventoryManager Instance;
    public List <item> items = new List <item> ();
    public Transform itemContent;
    public GameObject inventoryItemPrefab;
    public Toggle enableRemove;
    public inventoryItemController[] inventoryItems;
    public void Awake()
    {
       Instance = this;
    }
    public void Add(item item)
    {
        items.Add (item);   

    }
    public void Remove(item item)
    {
        items.Remove (item);
    }
    public void listItem()
    {
        foreach(Transform item in itemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in items)
        {
            GameObject obj = Instantiate(inventoryItemPrefab, itemContent);
            var itemName = obj.transform.Find("itemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("itemIcon").GetComponent<Image>();
            var removeButton = obj.transform.Find("removeButton").GetComponent<Button>();

           

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
            if(enableRemove.isOn)
            {
                removeButton.gameObject.SetActive(true);
            }
        }
        setInventoryItem();
    }
    public void enableItemRemove()
    {
        if (enableRemove.isOn)
        {
            foreach (Transform item in itemContent)
            {
                item.Find("removeButton").gameObject.SetActive(true);  
            }

        }
        else
        {
            foreach (Transform item in itemContent)
            {
                item.Find("removeButton").gameObject.SetActive(false);
            }
        }
    }
    public void setInventoryItem()
    {
        inventoryItems=itemContent.GetComponentsInChildren<inventoryItemController>();

        for (int i =0; i<items.Count; i++)
        {
            inventoryItems[i].Additem(items[i]);
        }
    }

}
